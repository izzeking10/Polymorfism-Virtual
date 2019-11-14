using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorfism_Virtual
{
    class Player
    {
       public virtual void Attack()
        {
            Console.WriteLine("A Player attacks!");
        }
    }
    class Mage : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Mage attacks attacks with a fireball!");
        }
    }
    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("A Warrior attacks attacks with a sword!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player());
            players.Add(new Mage());
            players.Add(new Warrior());

            foreach (Player p in players)
            {
                p.Attack();
            }

        }
    }
}
