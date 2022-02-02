using System.IO;
using System.Collections.Generic;
using System;
namespace mis321pa1_sgarrison1
{
    public class SongFileHandling
    {
        public static List<Song> GetSongs()
        {
            List<Song> songs = new List<Song>();
            StreamReader inFile = null;
            try
            {
                inFile = new StreamReader("songs.txt");
            }
            catch(FileNotFoundException e)
            {
                System.Console.WriteLine("Something went wrong... returning blank song lsit" + e);
                return songs;
            }
            string line = inFile.ReadLine();
            while(line != null)
            {
                string[] temp = line.Split("#");
                Guid id = Guid.Parse(temp[0]);
                DateTime date = DateTime.Parse(temp[2]);
                bool isDeleted = bool.Parse(temp[3]);
                songs.Add(new Song(){SongID = id, Title = temp[1], DateAdded = date, IsDeleted = isDeleted });
                line = inFile.ReadLine();
            }
            inFile.Close();
            return songs;

        }
        public static void SaveToFile(List<Song> songs)
        {
            StreamWriter outFile = new StreamWriter("songs.txt");
            foreach(Song x in songs)
            {
                outFile.WriteLine(x.ToString());
            }
            outFile.Close();
        }

        public static void UpdateDeleted(List<Song> songs, string title)
        {
            
            foreach( Song x in songs )
            {
                try
                {
                   if(x.Title == title)
                   {
                    x.IsDeleted = true;
                   }
                }
                catch
                {
                    System.Console.WriteLine("Invalid Title");
                }
            }
        }
        
        
    }
}