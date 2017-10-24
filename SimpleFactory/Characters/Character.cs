using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Characters
{
    public abstract class Character
    {
        // Properties
        public int Hp { get; set; }
        public int Mp { get; set; }
        public string Weapon { get; set; }

        // Methods
        public void Attack()
        {
            Console.WriteLine($"Attack target with { Weapon } !");
        }

        public abstract void SpecialSkill();
    }
}
