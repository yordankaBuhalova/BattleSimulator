using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitOOP
{
    abstract class Person
    {

        public string Name { get; set; }
        public string Kind { get; protected set; }
        public int HealthPoints { get; set; }
        public int DamagePoints { get; set; }
        public int ArmorPoints { get; set; }

        public Person() { }

        // returns the damage points
        public virtual int Attack()
        {
            return DamagePoints;
        }
        //decreases health whit incoming attack
        public virtual int Defend(int demagePoints)
        {
            return HealthPoints = HealthPoints - demagePoints;
        }
        // convert to string
        public override String ToString()
        {
            return $"{ Name}: { Kind}, HealtPoints { HealthPoints}, DamagePoints { DamagePoints},  ArmorPoints {ArmorPoints}";

        }


    }
}
