using Ttar.Core.Entities;

namespace Ttar.Entities.Concrete
{
    public class Category :IEntity
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
    }
}
