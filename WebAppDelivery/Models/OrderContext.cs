using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDelivery.Models
{
    public class OrderContext : DbContext
    {
        public DbSet<PackageModel> PackageModels { get; set; }
        public DbSet<Order> Orders { get; set; }
        //OrderContext определен вызов Database.EnsureCreated(),
        //который при отсутствии базы данных автоматически создает ее. Если база данных уже есть, то ничего не происходит.
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            Database.EnsureCreated();
        }


    }
}
