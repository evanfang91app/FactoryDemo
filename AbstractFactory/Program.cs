using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using AbstractFactory.Characters;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacterFactory factory;
            Character archer, warrior, wizard;

            //// Create Human Archer, Warrior, Wizard
            factory = new HumanFactory();
            archer = factory.CreateArcher();
            warrior = factory.CreateWarrior();
            wizard = factory.CreateWizard();

            //// Create Elf Archer, Warrior, Wizard
            factory = new ElfFactory();
            archer = factory.CreateArcher();
            warrior = factory.CreateWarrior();
            wizard = factory.CreateWizard();

            //// Create Orc Archer, Warrior, Wizard
            factory = new OrcFactory();
            archer = factory.CreateArcher();
            warrior = factory.CreateWarrior();
            wizard = factory.CreateWizard();
        }
    }
}
