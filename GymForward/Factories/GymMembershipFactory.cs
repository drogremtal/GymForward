using GymForward.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymForward.Factories
{
    internal class GymMembershipFactory : MembershipFactories
    {

        private readonly decimal _price;
        private readonly string _description;
        public GymMembershipFactory(decimal price, string description)
        {
            _description = description;
            _price = price; 
        }

        public override IGymMembership GetGymMembership()
        {
            return new GymMembership(_price)
            {
                Description = _description
            };
        }
    }
}
