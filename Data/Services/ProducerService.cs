using ShopMVC.Data.Base;
using ShopMVC.Models;

namespace ShopMVC.Data.Services
{
    public class ProducerService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducerService(AppDbContext context) : base(context) { }
    }
}
