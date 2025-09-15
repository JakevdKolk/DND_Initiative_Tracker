using DND_Initiative_Tracker.Contracts;
using DND_Initiative_Tracker.Data;
using DND_Initiative_Tracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using static DND_Initiative_Tracker.Contracts.CampaignDTO;

namespace DND_Initiative_Tracker.Controllers
{

    [ApiController]
    [Route("api/campaigns")]
    public class CampaignController : BaseController<Campaign, CampaignDto, CreateCampaignDto, int>
    {

        public CampaignController(DnDDbContext context) : base(context) { }
        protected override void ApplyUpdate(Campaign entity, CreateCampaignDto dto)
        {
            entity.Name = dto.Name;
            entity.Description = dto.Description;
            entity.VttLink = dto.VttLink;
            entity.DriveLink = dto.DriveLink;
        }

        protected override Expression<Func<Campaign, bool>> ById(int id) => u => u.Id == id;

        protected override int GetKey(Campaign entity) => entity.Id;

        protected override Expression<Func<Campaign, CampaignDto>> MapToDto() => u => new CampaignDto(
            u.Id, u.Name, u.Description, u.DriveLink, u.VttLink, 
            u.CampaignUsers.Select(u => new MinimalAppUserDto( u.User.Id, u.User.Name)).OrderBy(u => u.Id).ToList()
        );


        protected override Campaign MapToEntity(CreateCampaignDto dto) => new()
        {
            Name = dto.Name,
            Description = dto.Description,
            DriveLink = dto.DriveLink,
            VttLink = dto.VttLink
        };
    }
}
