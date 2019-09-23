using System;

namespace Backpack
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] inventory = new string[5];
            int counter = 0;

            while(true)
            {
                
                Console.WriteLine("Välkommen till din ryggsäck!\n [1] Lägg till ett föremål\n [2] Skriv ut innehållet\n [3] Rensa innehållet\n [4] Avsluta\nVälj:");
                string option = Console.ReadLine();
                
                
                switch(option)
                {
                    case "1":
                    
                    try
                    {
                        Console.WriteLine("Skriv in vad du vill lägga till");
                        inventory[counter] = Console.ReadLine();
                        Console.WriteLine($"Du har nu lagt till {inventory[counter]}\n");
                        counter++;
                    }
                    catch(Exception)
                    {
                        Console.WriteLine("Ryggsäcken är full, du behöver rensa ryggsäcken!\n");

                    }
                    
                    break;

                    case "2":
                    Console.WriteLine("Innehållt i ryggsäcken:");

                    for(int i = 0; i < 5; i++)
                    {
                        Console.WriteLine(inventory[i]);

                    }
                     break;

                     case "3":

                     for(int i = 0; i < 5; i++)
                     {
                         inventory[i] = "";
                     }
                     Console.WriteLine("Du har nu rensat din ryggsäck!\n");
                     break;

                     case "4":
                     return;
                     

                     default:
                     Console.WriteLine("Ogiltig inmatad siffra, försök igen!\n");
                     break;
                }
            }
        }
    }
}
