using GymForward.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymForward.Factories
{
    internal abstract class MembershipFactories
    {
        public abstract IGymMembership GetGymMembership ();
    }
}
