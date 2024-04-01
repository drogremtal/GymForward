using GymForward.DomainModel;
using GymForward.Factories;

namespace GymForward
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>> Программа на основ паттерна Фабрика <<< \n");
            Console.WriteLine("> Введите тип абаонента");
            Console.WriteLine("> G - спортзал");
            Console.WriteLine("> P - спортзал + басейн");
            Console.WriteLine("> T - персональная");

            string memberShiptype = Console.ReadLine();

            MembershipFactories membershipFactories = GetFactories(memberShiptype);
            IGymMembership gymMembership = membershipFactories.GetGymMembership();

            Console.WriteLine("Вы выбрали абонемент");

            Console.WriteLine(
                $"Тип:{gymMembership.Name} \n"
                + $"Описание:{gymMembership.Description} \n"
                + $"Цена: {gymMembership.GetPrice()} \n"
                );

            Console.ReadKey();

        }

        private static MembershipFactories GetFactories(string memberhsipType)
        {
            MembershipFactories? IGymMemberShip;
            IGymMemberShip = memberhsipType.ToLower() switch
            {
                "g" => new GymMembershipFactory(100, "Базовый абонемент"),
                "p" => new GymPoolMemsbershipFactory(250, "Базовый абонемент + Басей"),
                "t" => new PersonalTrainingMembershipFactory(432, "Персональные тренировки"),
                _=>null
            };

            return IGymMemberShip;

        }
    }
}
