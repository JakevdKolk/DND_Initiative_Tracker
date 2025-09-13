using DND_Initiative_Tracker.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DND_Initiative_Tracker.Controllers
{
    public abstract class BaseController<TEntity, TDto, TCreateDto, TKey> : Controller
        where TEntity : class
    {

        protected readonly DbContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseController(DnDDbContext dbcontext)
        {
            this._dbContext = dbcontext;
            this._dbSet = _dbContext.Set<TEntity>();
        }

        protected abstract Expression<Func<TEntity, TDto>> MapToDto();
        protected abstract TEntity MapToEntity(TCreateDto dto);
        protected abstract Expression<Func<TEntity, bool>> ById(TKey id);
        protected abstract TKey GetKey(TEntity entity);
        protected abstract void ApplyUpdate(TEntity entity, TCreateDto dto);

        [HttpGet]
        public async Task<ActionResult<List<TDto>>> GetAll(CancellationToken ct) =>
            Ok(await _dbSet.AsNoTracking().Select(MapToDto()).ToListAsync());
        
        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> GetById([FromRoute] TKey id, CancellationToken ct)
        {
            var item = await _dbSet.AsNoTracking().Where(ById(id)).Select(MapToDto()).SingleOrDefaultAsync();
            return item is null ? NotFound() : Ok(item);


        }

        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<TCreateDto>> Create([FromBody] TCreateDto dto, CancellationToken ct)
        {
            var item = MapToEntity(dto);
            await _dbSet.AddAsync(item, ct);
            await _dbContext.SaveChangesAsync();

            var id = GetKey(item);
            var created = await _dbSet.AsNoTracking().Where(ById(id)).Select(MapToDto()).SingleAsync();

            return CreatedAtAction(nameof(GetById), new { id }, created);
            
        }

        [HttpPut("{id:int}")]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TCreateDto>> Update([FromRoute] TKey id, [FromBody] TCreateDto dto, CancellationToken ct)
        {
            var item = await _dbSet.FirstOrDefaultAsync(ById(id), ct);
            if(item == null) return NotFound();

            ApplyUpdate(item, dto);
            await _dbContext.SaveChangesAsync(ct);

            var result = await _dbSet.AsNoTracking().Where(ById(id)).Select(MapToDto()).SingleAsync(ct);

            return Ok(result);


        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete([FromRoute] TKey id, CancellationToken ct) 
        {
            var item = await _dbSet.FirstOrDefaultAsync(ById(id), ct);
            if (item == null) return NotFound();

            _dbSet.Remove(item);

            await _dbContext.SaveChangesAsync(ct);
            return NoContent();

        }
    }
}
