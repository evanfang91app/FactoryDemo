using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Characters;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character;

            //// Create Archer
            character = CharacterFactory.CreateCharacter(CharacterType.Archer);

            //// Create Warrior
            character = CharacterFactory.CreateCharacter(CharacterType.Warrior);
        }
    }
}
