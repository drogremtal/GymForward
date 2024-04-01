using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymForward.DomainModel
{
    public class PersonalTrainingGymMembership : IGymMembership
    {
        private decimal _price;
        private readonly string _name;

        public PersonalTrainingGymMembership(decimal price)
        {
            _name = "Personal Training Membership";
            _price=price;
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
