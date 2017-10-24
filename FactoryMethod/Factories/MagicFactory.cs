using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Characters;

namespace FactoryMethod.Factories
{
    public class WizardFactory : ICharacterFactory
    {
        public string Teacher { get; set; }

        public int WandInventory
        {
            get
            {
                return _WandInventory;
            }
        }

        private int _WandInventory;
        
        public WizardFactory(string teacher = "Merlin")
        {
            Teacher = teacher;

            _WandInventory = 5;
        }

        public Character Create()
        {
            if (Teacher == null)
            {
                //// Teacher is reqired for training a wizard
                throw new NoTeacherException();
            }
            
            if (_WandInventory <= 0)
            {
                //// Magic wand is not enough
                throw new EquipmentNotEnoughExeption();
            }

            //// Training...
            Console.WriteLine($"{ Teacher } is training a new wizard...");

            //// Equiped!
            _WandInventory -= 1;

            return new Wizard()
            {
                Hp = 85,
                Mp = 100,
                Weapon = "Magic Wand"
            };
        }
    }
}
