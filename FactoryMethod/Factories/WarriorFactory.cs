using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Characters;

namespace FactoryMethod.Factories
{
    public class WarriorFactory : ICharacterFactory
    {
        public Character Create()
        {
            return new Warrior()
            {
                Hp = 120,
                Mp = 10,
                Weapon = "Wood Sword"
            };
        }
    }
}
