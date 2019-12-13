using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitOOP
{
    class Program
    {
        static void Main(string[] args)
        {//Heroes
            Hero hero1 = new Hero("Captain Hefty", 100, 50, 10);
            Knight knight = new Knight("Doctor Powerful", 100, 17, 10);
            Ninja ninja1 = new Ninja("Professor Strong", 100, 5, 8);
            Hero Attaker = new Hero("Attaker", 100, 60, 10);
            //Party
            List<Person> partyList = new List<Person>();
            partyList.Add(hero1);
            partyList.Add(knight);
            partyList.Add(ninja1);

            Console.WriteLine(Attaker.ToString() + Environment.NewLine);
            Party party = new Party("MY PARTY", partyList);
            party.Print();
            Console.WriteLine();
            //attack sum
            int sumAttack = party.partyAttack();
            Console.WriteLine(" Sum of all Attacks: " + sumAttack + Environment.NewLine);

            // Attaker attack 
            int pointsHealt = party.Defend(Attaker.Attack());
            if (pointsHealt > 0)
            {
                Console.WriteLine(" His HealthPoints are now:" + pointsHealt + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(" He is dead!");
            }
            //ninja attack 
            pointsHealt = party.Defend(ninja1.Attack());

            if (pointsHealt > 0)
            {
                Console.WriteLine(" His HealthPoints are now:" + pointsHealt + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(" He is dead!");
            }
            //party attack
            Console.WriteLine(" Group Attack");
            pointsHealt = party.Defend(sumAttack);

            if (pointsHealt > 0)
            {
                Console.WriteLine(" His HealthPoints are now:" + pointsHealt + Environment.NewLine);
            }
            else
            {
                Console.WriteLine(" He is dead!");
            }
        }
    }
}
