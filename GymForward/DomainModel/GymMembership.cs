using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymForward.DomainModel
{
    public class GymMembership : IGymMembership
    {
        private decimal _price;
        private readonly string _name;

        public GymMembership(decimal price)
        {
            _name = "Gym MemberShip";
            _price=price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
