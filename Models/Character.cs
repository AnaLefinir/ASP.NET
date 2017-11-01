using System;
using System.Collections.Generic;

namespace TryMVC.Models
{
    public class Character
    {
        public string Name;

        public static void Create (string characterName)
        {
            var character = new Character();
            character.Name = characterName;
            GlobalVariables.Characters.Add(character);
        }

        public static List<Character> GellAll()
        {
            return GlobalVariables.Characters;
        }
    }
}