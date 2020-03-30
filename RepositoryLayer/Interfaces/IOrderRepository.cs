﻿using InfrastructureLayer.JSONObjects;
using ModelsLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IOrderRepository : IGenericRepository<Order , int>
    {
        bool SubmitOrder(OrderJSON order);
    }
}
