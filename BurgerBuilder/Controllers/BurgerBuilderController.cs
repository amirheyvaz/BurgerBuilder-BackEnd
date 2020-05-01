using InfrastructureLayer.JSONObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BurgerBuilder.Core;
using RepositoryLayer.Interfaces;
using BurgerBuilder.Filters;

namespace BurgerBuilder.Controllers
{
    [JwtAuthentication]
    [RoutePrefix("api/BurgerBuilder")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BurgerBuilderController : ApiController
    {
        [Route("Order")]
        [HttpPost]
        public bool GetOrder(OrderJSON order)
        {
            var orderRep = IocConfig.Container.GetInstance<IOrderRepository>();
            return orderRep.SubmitOrder(order);
        }

        [Route("Orders")]
        [HttpPost]
        public List<OrderJSON> GetAllOrders()
        {
            var orderRep = IocConfig.Container.GetInstance<IOrderRepository>();
            return orderRep.GetAllOrders();

        }

        [Route("Hello")]
        [HttpGet]
        public string hello()
        {
            return "Hello";
        }



        //[Route("Validate")]
        //[HttpPost]
        //public bool ValidateToken(string token, string UserName)
        //{
        //    var User = IocConfig.Container.GetInstance<IUserRepository>(); 
        //    if (User.SelectBy(u => u.UserName == UserName).Any()) return false;

        //    string tokenUsername = TokenManager.ValidateToken(token);
        //    if (UserName.Equals(tokenUsername))
        //    {
        //        return true;
        //    }


        //    return false;
        //}



    }
}