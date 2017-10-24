using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Characters
{
    public class Wizard : Character
    {
        public override void SpecialSkill()
        {
            Console.WriteLine("Fire ball!");
        }
    }
}
