using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitOOP
{   // class Knight Implement class Person
    class Knight : Person
    {
        public Knight(string name, int healthPoint, int damagePoint, int armorPoints)
        {
            Name = name;
            Kind = "knight";
            HealthPoints = healthPoint;
            DamagePoints = damagePoint;
            ArmorPoints = armorPoints;
        }

        //decreases health whit incoming attack has a 20% chance to block attack
        public override int Defend(int demagePoints)
        {

            int probability = StaticRandom.Instance.Next(1, 5);
            // has 20% chance random probability number to be equal to 1
            if (probability == 1)
            {
                Console.WriteLine("The attack was blocked");

                return HealthPoints; // healthpoints with 0 damagePoints
            }
            return HealthPoints = HealthPoints - demagePoints; // decreases health
        }
    }
}
