using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using InfrastructureLayer.AbstractModels;

namespace ModelsLayer.Models
{
    [Table("Users", Schema = "BB")]
    public class User : TEntity<int>
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
