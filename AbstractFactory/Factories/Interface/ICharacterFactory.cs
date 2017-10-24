using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Characters;

namespace AbstractFactory.Factories
{
    public interface ICharacterFactory
    {
        Warrior CreateWarrior();

        Archer CreateArcher();

        Wizard CreateWizard();
    }
}
