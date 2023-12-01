using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4MuhammadFBahlK
{
    public class Character 
    {
        public string? CharacterName { get; set; }
        public int? CharacterLevel { get; set; }
        public List<Ability> characterAbilities { get; set; } = new List<Ability>();

        public string GetCharacterInformation()
        {
            string characterDisplay = $"Name: {CharacterName}, Level: {CharacterLevel}\n";
            characterDisplay += $"Abilities:\n";
            foreach (Ability a in characterAbilities)
            {
               characterDisplay += $"{a.GetAbilityInformation()}\n";

            }
            return characterDisplay;
        }

    }
    public class Ability
    {
        public string? CharacterAbilityName { get; set; }
        public int? CharacterAbilityLvl { get; set; }

        public string GetAbilityInformation()
        {
            string abilityDisplay = $"Ability: {CharacterAbilityName}, Ability Level: {CharacterAbilityLvl}";
            return abilityDisplay;
        }
        
    }
}
