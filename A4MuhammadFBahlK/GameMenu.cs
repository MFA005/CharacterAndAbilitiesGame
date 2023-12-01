
namespace A4MuhammadFBahlK
{
   public class GameMenu 
    {
        public void MenuDisplay()

        {
            CharacterOptions options = new CharacterOptions();

            while (true)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("C# Adventures!");
                Console.WriteLine("1. Add New Character");
                Console.WriteLine("2. Edit Existing Character");
                Console.WriteLine("3. Delete Character");
                Console.WriteLine("4. Display All Characters");
                Console.WriteLine("5. Exit");
                Console.WriteLine("----------------------------------------------------");                        
                Console.WriteLine("Choose an Option.");

                string selection = Console.ReadLine().ToLower();
                if (selection == "1" || selection == "add new character")
                {
                    
                    options.AddNewCharacter();
                }
                else if (selection == "2" || selection == "edit existing character")
                {
                    options.EditCharacter();
                }
                else if (selection == "3" || selection == "delete character")
                {
                    options.DeleteCharacter();
                }
                else if (selection == "4" || selection == "display all characters")
                {
                    options.DisplayCharacters();
                }
                else if (selection == "5" || selection == "exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("That is not an option");
                }
            }
        }
    }
}
