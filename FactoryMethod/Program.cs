using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod;
using FactoryMethod.Characters;
using FactoryMethod.Factories;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICharacterFactory factory;

            Character character;

            //// Create archer
            factory = new ArcherFactory();
            character = factory.Create();

            //// Create warrior
            factory = new WarriorFactory();
            character = factory.Create();

            //// Create wizard
            factory = new WizardFactory();
            character = factory.Create();
        }
    }
}
