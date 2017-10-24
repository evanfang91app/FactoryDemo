using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory.Characters;

namespace SimpleFactory
{
    public enum CharacterType
    {
        Warrior,
        Archer
    }

    /// <summary>
    /// Newborn hero training camp
    /// </summary>
    public class CharacterFactory
    {
        public static Character CreateCharacter(CharacterType type)
        {
            if (type == CharacterType.Warrior)
            {
                return new Warrior()
                {
                    Hp = 120,
                    Mp = 10,
                    Weapon = "Wood Sword"
                };
            }
            else if (type == CharacterType.Archer)
            {
                return new Archer()
                {
                    Hp = 90,
                    Mp = 20,
                    Weapon = "Short Bow"
                };
            }
            else
            {
                throw new ArgumentException("No such type of character!");
            }
        }
    }
}
