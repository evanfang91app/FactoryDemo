using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory.Characters
{
    public class Warrior : Character
    {
        public override void SpecialSkill()
        {
            Console.WriteLine("Warrior Super Attack!");
        }
    }
}
