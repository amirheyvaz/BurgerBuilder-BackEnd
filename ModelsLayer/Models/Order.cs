using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using InfrastructureLayer.AbstractModels;

namespace ModelsLayer.Models
{
    [Table("Orders" , Schema = "BB")]
    public class Order : TEntity<int>
    {
        public int SaladAmount { get; set; }
        public int CheeseAmount { get; set; }
        public int MeatAmount { get; set; }
        public int BaconAmount { get; set; }
        

    }
}
