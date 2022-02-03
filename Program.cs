using System;
using System.IO;
using System.Collections.Generic;


namespace mis321pa1_sgarrison1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int menuChoice = 0;
            Menu(menuChoice, count);
        
        }

            static void Menu(int menuChoice, int count)
            {
                while(menuChoice != 4)
                {
                    System.Console.WriteLine("Select One:\n1. Show All Songs\n2. Add a Song\n3. Delete a Song by Title\n4. Exit");
                    menuChoice = int.Parse(Console.ReadLine());
                    
                    if(menuChoice == 1)
                    {
                        ShowAllSongs();
                    }
                    if(menuChoice ==2)
                    {
                        AddSong(count);
                    }
                    if(menuChoice ==3)
                    {
                        DeleteSong();
                    }
                    if(menuChoice != 1 && menuChoice != 2 && menuChoice != 3 && menuChoice != 4)
                    {
                        System.Console.WriteLine("Invalid Option");
                    }
                    
                }
                
            }
            static void ShowAllSongs()
            {
                List<Song> songs = SongFileHandling.GetSongs();
                songs.Sort(Song.CompareByDate);
                SongReport.PrintAllSongs(songs);
            }

            static void AddSong(int count)
            {
                System.Console.WriteLine("Enter the song name?");
                string title = Console.ReadLine();
                System.Console.WriteLine("Enter todays date --> mm/dd/yyy");
                DateTime date = DateTime.Parse(Console.ReadLine());
                List<Song> songs = SongFileHandling.GetSongs();
                Guid guid = Guid.NewGuid();
                songs.Add(new Song() {SongID = guid, Title = title, DateAdded = date, IsDeleted = false });
                SongFileHandling.SaveToFile(songs);
                ShowAllSongs();

            }
            static void DeleteSong()
            {
                ShowAllSongs();
                System.Console.WriteLine("Enter the title of the song you would like to delete");
                string name = Console.ReadLine();
                List<Song> songs = SongFileHandling.GetSongs();
                SongFileHandling.UpdateDeleted(songs, name);
                SongFileHandling.SaveToFile(songs);
                ShowAllSongs();
                

                
            }
    }
}




