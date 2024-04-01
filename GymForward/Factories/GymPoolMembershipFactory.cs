using GymForward.DomainModel;

namespace GymForward.Factories
{
    internal class GymPoolMemsbershipFactory : MembershipFactories
    {

        private readonly decimal _price;
        private readonly string _description;
        public GymPoolMemsbershipFactory(decimal price, string description)
        {
            _description = description;
            _price = price;
        }

        public override IGymMembership GetGymMembership()
        {
            return new GymMembershipPlusPool(_price)
            {
                Description = _description
            };
        }
    }
}
