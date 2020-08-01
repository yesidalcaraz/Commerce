namespace CommerceBackend.Models
{
    using Commerce.Domain.Models;

    public class LocalDataContext:DataContext
    {
        public System.Data.Entity.DbSet<Commerce.Common.Models.Product> Products { get; set; }
    }
}