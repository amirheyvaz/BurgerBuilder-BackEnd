using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.JSONObjects
{
    public class OrderJSON
    {
        public int ID { get; set; }
        public int SaladAmount { get; set; }
        public int CheeseAmount { get; set; }
        public int MeatAmount { get; set; }
        public int BaconAmount { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
