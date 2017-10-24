using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Characters;

namespace AbstractFactory.Factories
{
    public class ElfFactory : ICharacterFactory
    {
        private readonly string _race = "Elf";
        private readonly string _weaponStyle = "Forest";

        public Archer CreateArcher()
        {
            return new Archer()
            {
                Race = _race,
                Weapon = _weaponStyle + " Bow"
            };
        }

        public Warrior CreateWarrior()
        {
            return new Warrior()
            {
                Race = _race,
                Weapon = _weaponStyle + " Sword"
            };
        }

        public Wizard CreateWizard()
        {
            return new Wizard()
            {
                Race = _race,
                Weapon = _weaponStyle + " Wand"
            };
        }
    }
}
