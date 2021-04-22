//using System;
using Microsoft.EntityFrameworkCore;
namespace ServiceApi.Models
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options): base(options)
        {
        }
        public DbSet<ServiceItem> ServiceItems { get; set; }
    }
}
