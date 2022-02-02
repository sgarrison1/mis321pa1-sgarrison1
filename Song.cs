using System.IO;
using System;
using System.Collections.Generic;

namespace mis321pa1_sgarrison1
{
    public class Song
    {
        public Guid SongID {get; set;}
        public string Title {get;set;}
        public DateTime DateAdded{get; set;}
        public bool IsDeleted{get;set;}
        public Song( )
        {

        }
        public Song(Guid SongID,string Title,DateTime DateAdded, bool IsDeleted)
        {
            this.SongID = SongID;
            this.Title = Title;
            this.DateAdded =DateAdded;
            this.IsDeleted = IsDeleted;
            
        }

        public override string ToString()
        {
            return SongID + "#" + Title + "#" + DateAdded + "#" + IsDeleted;
        }
        public String ReportSongs()
        {
            return "ID:     " + SongID + "  Title:   " + Title + "  Date Added:     " + DateAdded;
        }
         public static int CompareByDate(Song x, Song y)
         {
             return y.DateAdded.CompareTo(x.DateAdded);
         }

    }
}