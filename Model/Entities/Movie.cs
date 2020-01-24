using System;
using System.ComponentModel.DataAnnotations;

namespace Model.Entities
{
    public class Movie
    {   [Key] 
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        private int Duration { get; set; }
        private DateTime ReleaseDate  { get; set; }

        public Movie()
        {
        }

        public Movie(string title, string description, int duration, DateTime releaseDate)
        {
            Title = title;
            Description = description;
            Duration = duration;
            ReleaseDate = releaseDate;
        }
    }
}