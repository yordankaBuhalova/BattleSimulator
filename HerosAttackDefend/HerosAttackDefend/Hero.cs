using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitOOP
{  // class Hero Implement class Person
    class Hero : Person
    {
        public Hero(string name, int healthPoint, int damagePoint, int armorPoints)
        {
            Name = name;
            Kind = "hero";
            HealthPoints = healthPoint;
            DamagePoints = damagePoint;
            ArmorPoints = armorPoints;
        }

    }
}
