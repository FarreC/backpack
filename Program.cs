using System;

namespace Backpack
{
    class Program
    {

        

        static void Main(string[] args)
        {
            // Skapar en array för väskans innehåll (max 5) samt en counter för att hålla koll på vilken element är ledig på arrayen och ifall väskan är full
            string[] inventory = new string[5];
            int counter = 0;
            

            while(true)
            {
                Console.Clear();
                // Välkommnar dig till din ryggsäck och visar upp en meny med olika alternativ
                Console.WriteLine("Välkommen till din ryggsäck!\n [1] Lägg till ett föremål\n [2] Skriv ut innehållet\n [3] Rensa innehållet\n [4] Avsluta\nVälj:");
                string option = Console.ReadLine(); // Här matar användaren in meny valet från 1-4
                
                
                switch(option)
                {
                    case "1":
                    
                    try
                    {
                       // Lägger till något i väskan
                       Console.Clear();
                        inventory[counter] = AddInventory(inventory[counter]);
                        Console.WriteLine($"Du har nu lagt till {inventory[counter]}\n");
                        counter++; // Byter till nästa element i arrayen för att kunna fortsätta lägga in något mer (detta görs inte ifall counter överstiger 5 då arrayen har inte mer än 5 element, får error och går över till catch)
                        Console.ReadKey();
                    }
                    catch(Exception e)
                    {
                        // Då ryggsäcken har en kapacitet på 5 så kan counter överstiga 5 och krasha. Istället så säger den till användaren att väskan är full
                        Console.Clear();
                        Console.WriteLine($"Ryggsäcken är full, du behöver rensa ryggsäcken!\nFelmeddelande: {e.Message} ");
                        Console.ReadKey();

                    }
                    
                    break;

                    case "2":
                       // Skriver ut väskans innehåll
                        Console.Clear();
                        CheckInventory(inventory);
                        Console.ReadKey();
                   
                     break;

                     case "3":
                        // Rensar väskans innehåll
                        Console.Clear();
                        ClearInventory(inventory);
                        counter = 0; // Ställer om counter till 0 för att börja om på arrayen.
                        Console.ReadKey();
                     break;

                     case "4":
                     return; // Stänger ner programmet
                     

                     default:
                     Console.Clear();
                     Console.WriteLine("Ogiltig inmatad siffra, försök igen!\n"); // Ifall användaren matar in något annat än 1-4 så varnas användaren.
                     Console.ReadKey();
                     break;
                }
            }
        }

        static string AddInventory(string add)
        {
            // Användaren skriver in vad som ska läggas till i väskan som sedan retunerar detta till listan.
             Console.WriteLine("Skriv in vad du vill lägga till");
            add = Console.ReadLine();
            return add;

        }

        static void CheckInventory(string[] inventory)
        {
             Console.WriteLine("Innehållet i ryggsäcken:");
                    // For loop som loopar tills längden på listan är klar och visar innehållet.
                    for(int i = 0; i < inventory.Length; i++)
                    {
                        
                        Console.WriteLine(inventory[i]); // Skriver ut alla elements i arrayen.

                    }          
        }

        static string[] ClearInventory(string[] inventory)
        {   
            // For loop som loopar tills längden på listan är klar och rensar innehållet och retunerar detta till listan.
            for(int i = 0; i < inventory.Length; i++)
                     {
                         inventory[i] = ""; // Gör alla elements i arrayen tom.
                     }
                     Console.WriteLine("Du har nu rensat din ryggsäck!\n");
                     return inventory;
        }
    }
    
}
