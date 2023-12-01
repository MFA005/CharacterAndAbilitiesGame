namespace A4MuhammadFBahlK
{
    

    public class CharacterOptions
    {
        string characterName;
        string characterAbilityName;
        int characterAbilityLvl;
        int characterLevel;
        List<Character> characters = new List<Character>();
        bool validity = true;


        public void AddNewCharacter()
        {
            Console.WriteLine("Add Your Character.");
            validity = true;
            while (validity == true)
            {
                bool charSameName = true;
                while (charSameName == true)
                {
                    charSameName = false;
                    Console.WriteLine("Enter your character name:");
                    characterName = Console.ReadLine().ToLower();
                    foreach (Character a in characters)
                    {
                        if (a.CharacterName == characterName)
                        {
                            Console.WriteLine("Character names can not be similar.");
                            charSameName = true;
                        }                       
                    }
                    
                }
                 if (string.IsNullOrWhiteSpace(characterName))
                {
                    Console.WriteLine("Name can not be blank");
                }
                else
                {
                    validity = false;
                }
            }
            validity = true;
            while (validity == true)
            {
                try {
                    Console.WriteLine("Enter your character's level (1-7)");
                    characterLevel = int.Parse(Console.ReadLine());
                    if (characterLevel > 7 || characterLevel < 1 || string.IsNullOrWhiteSpace(characterLevel.ToString()))
                    {
                        Console.WriteLine("That is not a valid level");
                    }
                    else
                    {
                        validity = false;
                    }
                }
                catch(Exception e) 
                { 
                    Console.WriteLine("Enter a valid value please."); 
                }
            }
            Character characterAdded = new Character
            {
                CharacterName = characterName,
                CharacterLevel = characterLevel,

            };
            string addAbility = "y";

            //Loop for adding abilities, runs till user enters n
            while (addAbility == "y")
            {
                validity = true;
                while (validity == true)
                {
                    Console.WriteLine("Enter your character ability name");
                    characterAbilityName = Console.ReadLine().ToLower();

                    if (string.IsNullOrWhiteSpace(characterAbilityName))
                    {
                        Console.WriteLine("Ability name cant be blank");
                    }
                    else
                    {
                        validity = false;
                    }
                }
                validity = true;
                while (validity == true)
                {
                    Console.WriteLine("Enter ability level(0-5)");
                    try
                    {
                        characterAbilityLvl = int.Parse(Console.ReadLine());
                        if (characterAbilityLvl > 5 || characterAbilityLvl < 0)
                        {
                            Console.WriteLine("That is not a valid level.");
                        }
                        else
                        {
                            validity = false;
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Enter valid a value please.");
                    }
                    
                
                }
                characterAdded.characterAbilities.Add(new Ability
                {
                    CharacterAbilityName = characterAbilityName,
                    CharacterAbilityLvl = characterAbilityLvl,
                });
                Console.WriteLine("Would you like to add another ability? (y/n)");
                bool invalidAnswer = true;
                while (invalidAnswer)
                {
                    addAbility = Console.ReadLine().ToLower();
                    if (addAbility == "n")
                    {
                        invalidAnswer = false;
                        
                    }
                    else if (addAbility == "y")
                    {
                        invalidAnswer = false; 
                    }
                    else
                    {
                        Console.WriteLine("Please enter y or n");
                    }
                }
            }
           
            characters.Add(characterAdded);
                     
            Console.WriteLine("Your Character Has Been Saved.");
        }
        string edit;

            public void EditCharacter()
        {
            if (characters.Count == 0)
            {
                Console.WriteLine("You don't have any characters saved");
            }
            else
            {
                Console.WriteLine("Enter the name of the character you want to edit.");
            string characterName = Console.ReadLine();

                bool characterFoundSuccessfully = false;
                foreach (Character a in characters)
                {
                    if (a.CharacterName == characterName)
                    {
                        characterFoundSuccessfully = true;

                        Console.WriteLine("Your Character.");
                    
                        Console.WriteLine(a.GetCharacterInformation());

                        Console.WriteLine("1. Edit character name \n" +
                                          "2. Edit character level \n" +
                                          "3. Edit character abilities and their levels \n" +
                                          "4. Exit");
                        Console.WriteLine("Choose an option");
                        string editOption = Console.ReadLine().ToLower();
                        if (editOption == "1" || editOption == "edit character name")
                        {
                            validity = true;
                            while (validity == true)
                            {
                                bool charSameName = true;
                                while (charSameName == true)
                                {
                                    charSameName = false;
                                    Console.WriteLine("Enter the character's new name:");
                                    edit = Console.ReadLine().ToLower();
                                    foreach (Character b in characters)
                                    {
                                        if (b.CharacterName == edit)
                                        {
                                            Console.WriteLine("Character names can not be similar.");
                                            charSameName = true;
                                        }
                                    }

                                }
                                
                                if (string.IsNullOrWhiteSpace(edit))
                                {
                                    Console.WriteLine("Name can not be blank.");
                                }
                                else
                                {
                                    a.CharacterName = edit;
                                    validity = false;
                                }
                            }
                        }
                        else if (editOption == "2" || editOption == "edit character level")
                        {
                            validity = true;
                            while (validity == true)
                            {
                                try 
                                {
                                    Console.WriteLine("Enter character's new level: ");
                                    edit = Console.ReadLine().ToLower();
                                    if (int.Parse(edit) < 0 || int.Parse(edit) > 7)
                                    {
                                        Console.WriteLine("That is not a valid level.");
                                    }
                                    else
                                    {
                                        a.CharacterLevel = int.Parse(edit);
                                        validity = false;
                                    }
                                } catch (Exception e ) 
                                {
                                    Console.WriteLine("Enter a valid value.");
                                } 
                            }
                        }
                        else if (editOption == "3" || editOption == "edit character abilities and their levels")
                        {
                            string editAbility = "";
                            validity = true;
                            while (validity == true)
                            {
                                Console.WriteLine("Enter the name of the ability you want to edit.");
                                editAbility = Console.ReadLine().ToLower();
                                if (string.IsNullOrEmpty(editAbility))
                                {
                                    Console.WriteLine("Ability name can not be blank");
                                }
                                else
                                {
                                    validity = false;
                                }
                            }bool abilityFound = false;
                            foreach (Ability item in a.characterAbilities)
                            {

                                if (editAbility == item.CharacterAbilityName)
                                {   
                                    abilityFound = true;
                                    validity = true;
                                    while (validity == true)
                                    {
                                        Console.WriteLine("Enter new ability name: ");
                                        edit = Console.ReadLine().ToLower();
                                        if (string.IsNullOrWhiteSpace(edit))
                                        {
                                            Console.WriteLine("Please enter a name.");
                                        }
                                        else
                                        {
                                            validity = false;
                                        }
                                    }
                                    item.CharacterAbilityName = edit;
                                    validity = true;
                                    while (validity == true)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Enter new ability level (0-5): ");
                                            int editAbilityLvl = int.Parse(Console.ReadLine().ToLower());
                                            if (editAbilityLvl < 0 || editAbilityLvl > 5)
                                            {
                                                Console.WriteLine("That is not a valid level.");
                                            }
                                            else
                                            {
                                                validity = false;
                                            }
                                            item.CharacterAbilityLvl = editAbilityLvl;
                                        }catch(Exception e)
                                        {
                                            Console.WriteLine("Enter a valid value.");
                                        }
                                    }
                                } 
                            }if (abilityFound == false)
                            {
                                Console.WriteLine( "Ability not Found.");
                            }


                        }

                    }
                    if (characterFoundSuccessfully == false)
                    {
                        Console.WriteLine("Character not found");
                    }
                }
            }

        } 
            
            public void DeleteCharacter()
        {
            if (characters.Count == 0)
            {
                Console.WriteLine("You don't have any characters saved");
            }
            else
            {
                Console.WriteLine("Select a character you want to delete.");

                string characterDelete = Console.ReadLine().ToLower();
                bool characterFoundSuccessfully = false;
                foreach (Character a in characters)
                {
                    if (a.CharacterName == characterDelete)
                    {
                        Console.WriteLine("Character Found. Confirm Delete? (y/n)");
                        characterFoundSuccessfully = true;
                        string confirmDelete = Console.ReadLine().ToLower();
                        if (confirmDelete == "y")
                        {
                            Console.WriteLine($"Character: {a.CharacterName}, Level: {a.CharacterLevel} has been successfully removed.");
                            characters.Remove(a);
                           
                        }
                        else if (confirmDelete == "n")
                        {
                            //goes back to menu 
                                                }
                        else
                        {
                            Console.WriteLine("Please enter y/n");
                        }

                    }
                   
                }
                if (characterFoundSuccessfully == false)
                {
                    Console.WriteLine("Character not found");
                }
            }
        }
           public void DisplayCharacters()
        {
            if (characters.Count == 0)
            {
                Console.WriteLine("You don't have any characters saved");
            }
            else
            {
                foreach (Character a in characters)
                {

                    Console.WriteLine(a.GetCharacterInformation());
                }
            }
                
            }
        }
    }

