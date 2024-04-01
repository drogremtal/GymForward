using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymForward.DomainModel
{
    public class GymMembershipPlusPool : IGymMembership
    {
        private decimal _price;
        private readonly string _name;

        public GymMembershipPlusPool(decimal price)
        {
            _name = "Gym + Pool";
            _price=price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
