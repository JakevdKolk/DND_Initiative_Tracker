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

        [HttpGet]
        public async Task<ActionResult<List<TDto>>> GetAll(CancellationToken ct) =>
            Ok(await _dbSet.AsNoTracking().Select(MapToDto()).ToListAsync());
        
        [HttpGet("{id}")]
        public async Task<ActionResult<TDto>> GetById([FromRoute] TKey id, CancellationToken ct)
        {
            var item = await _dbSet.AsNoTracking().Where(ById(id)).Select(MapToDto()).SingleOrDefaultAsync();
            return item is null ? NotFound() : Ok(item);


        }
    }
}
