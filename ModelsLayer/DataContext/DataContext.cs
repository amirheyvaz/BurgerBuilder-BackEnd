using InfrastructureLayer.Interfaces;
using ModelsLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.DataContext
{
    public class DataContext : DbContext, IUnitOfWork
    {

        public DbSet<Order> Orders { set; get;}
        public DbSet<User> Users { set; get; }




        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing); //فقط تعريف شده تا يك برك پوينت در اينجا قرار داده شود براي آزمايش فراخواني آن
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public new void Dispose()
        {
            Dispose(true);
        }

        

        public DataContext()
            : base("BurgerBuilderConnectionString")
        {
            Configuration.LazyLoadingEnabled = true;
        }
    }
}
