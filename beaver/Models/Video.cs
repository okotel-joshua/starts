using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace beaver.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Genre Genre { get; set; }


    }
    public enum Genre
    {
        Comedy = 1,
        horror = 2,
        Scifi = 3,
        Romance = 4,
        documentary = 5,
        kids = 6,
    }
}