using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Characters;

namespace AbstractFactory.Factories
{
    public class OrcFactory : ICharacterFactory
    {
        private readonly string _race = "Orc";
        private readonly string _weaponStyle = "Stone";

        public Archer CreateArcher()
        {
            return new Archer()
            {
                Race = _race,
                Weapon = "Stone Bow"
            };
        }

        public Warrior CreateWarrior()
        {
            return new Warrior()
            {
                Race = _race,
                Weapon = "Stone Sword"
            };
        }

        public Wizard CreateWizard()
        {
            return new Wizard()
            {
                Race = _race,
                Weapon = "Stone Wand"
            };
        }
    }
}
