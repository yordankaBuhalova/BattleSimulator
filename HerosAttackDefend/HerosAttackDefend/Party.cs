using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpitOOP
{
    class Party
    {
        public string PartyName { get; set; }

        List<Person> partyList = new List<Person>();

        public Party(string partyName, List<Person> partyList)
        {
            PartyName = partyName;

            this.partyList = partyList;
        }

        // returns the sum of all heroes in the Party
        public int partyAttack()
        {
            int sum = 0;
            foreach (var item in partyList)
            {
                sum += item.Attack(); // for each item in partylist call Attack() and add to sum

            }

            return sum;
        }
        // chouce a random hero from the party that takes incoming damage
          public int Defend(int damagePoints)
          {
             
              int index = StaticRandom.Instance.Next(partyList.Count); // random hero choice
              Console.WriteLine($" We choose { partyList[index].Name } to take incoming damage.");

              return partyList[index].Defend(damagePoints); // run defend method for the hero with this index in partylist
          }
     
        public void Print()
        {
            Console.WriteLine(PartyName);

            foreach (var item in partyList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
