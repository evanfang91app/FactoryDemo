using FactoryMethod.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Factories
{
    public class ArcherFactory : ICharacterFactory
    {
        public Character Create()
        {
            return new Archer()
            {
                Hp = 90,
                Mp = 20,
                Weapon = "Wood Bow"
            };
        }
    }
}
