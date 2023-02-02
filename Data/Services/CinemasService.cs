using ShopMVC.Data.Base;
using ShopMVC.Models;

namespace ShopMVC.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context)
        {
        }
    }
}
