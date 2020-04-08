using ModelsLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfrastructureLayer.Interfaces;
using InfrastructureLayer.JSONObjects;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace RepositoryLayer.Repositories
{
    public class OrderRepository : GenericRepository<Order, int>, Interfaces.IOrderRepository
    {
        public OrderRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<OrderJSON> GetAllOrders()
        {
            return GetAll().AsEnumerable().Select(p => new OrderJSON
            {
                SaladAmount = p.SaladAmount,
                BaconAmount = p.BaconAmount,
                MeatAmount = p.MeatAmount,
                CheeseAmount = p.CheeseAmount,
                ID = p.ID
            }).ToList();
        }

        public bool SubmitOrder(OrderJSON order)
        {
            using (var dbContextTransaction = Context.Database.BeginTransaction())
            {
                try
                {

                    var new_item = new Order()
                                {
                                    SaladAmount = order.SaladAmount,
                                    CheeseAmount = order.CheeseAmount,
                                    BaconAmount = order.BaconAmount,
                                    MeatAmount = order.MeatAmount
                                };
                                Add(new_item, true);

                
                    Commit();
                    dbContextTransaction.Commit();
                    dbContextTransaction.Dispose();


                    return true;
                }
                catch (DbEntityValidationException e)
                {
                    dbContextTransaction.Rollback();
                    dbContextTransaction.Dispose();
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    return false;
                }
                catch (Exception e)
                {
                    dbContextTransaction.Rollback();
                    dbContextTransaction.Dispose();
                    throw e;
                }
            }
        }

    }
}
