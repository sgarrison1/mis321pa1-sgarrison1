using System;
using System.IO;

namespace mis321pa1_sgarrison1
{
    class Program
    {
        static void Main(string[] args)
        {
          int menuChoice = 0;
          Menu(menuChoice);
        
        }

            static void Menu(int menuChoice)
            {
                while(menuChoice != 4)
                {
                    System.Console.WriteLine("Select One:\n1. Show All Songs\n2. Add a Song\n3. Delete a Song by ID\n4. Exit");
                    menuChoice = int.Parse(Console.ReadLine());
                    
                    if(menuChoice == 1)
                    {
                        ShowAllSongs();
                    }
                    if(menuChoice ==2)
                    {

                    }
                    if(menuChoice ==3)
                    {

                    }
                    if(menuChoice != 1 && menuChoice != 2 && menuChoice != 3 && menuChoice != 4)
                    {
                        System.Console.WriteLine("Invalid Option");
                    }
                    
                }
                
            }
            static void ShowAllSongs()
            {

            }
    }
}
