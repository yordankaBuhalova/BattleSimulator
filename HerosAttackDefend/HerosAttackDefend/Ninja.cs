using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitOOP
{   // class Ninja Implement class Person
    class Ninja : Person
    {
        public Ninja(string name, int healthPoint, int damagePoint, int armorPoints)
        {
            Name = name;
            Kind ="ninja";
            HealthPoints = healthPoint;
            DamagePoints = damagePoint;
            ArmorPoints = armorPoints;
        }
        // returns the damage points has 20% chance to cause 3*damagePoints
        public override int Attack()
        {

            int probability = StaticRandom.Instance.Next(1, 5);

            if (probability == 1) // has 20% chance random probability number to be equal to 1
            {
                Console.WriteLine(" Lucky you! The ninja's damage points are now triple!");
                return DamagePoints * 3; // triple damagePoints
            }

            return DamagePoints; // normal damagePoints
        }


    }
}
