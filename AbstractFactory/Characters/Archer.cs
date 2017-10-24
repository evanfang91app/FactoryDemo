﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Characters
{
    public class Archer : Character
    {
        public override void SpecialSkill()
        {
            Console.WriteLine("Archer Quick Attack!");
        }
    }
}
