using Microsoft.EntityFrameworkCore;
using ShopMVC.Data.Base;
using ShopMVC.Models;

namespace ShopMVC.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context) : base(context) { }
        
    }
}
