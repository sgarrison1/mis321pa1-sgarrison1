using System.IO;
using System.Collections.Generic;
using System;
namespace mis321pa1_sgarrison1
{
    public class SongReport
    {
        public static void PrintAllSongs(List<Song> songs)
        {
            foreach(Song x in songs)
            {
                if(x.IsDeleted == false)
                {
                System.Console.WriteLine(x.ReportSongs());
                //test
                }
            }
        }
    }

    
}