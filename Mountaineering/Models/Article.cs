using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mountaineering.Models
{
    public class Article
    {
        public int Id {get;set;}
        public DateTime Data { get; set; }
        public string NameArticle { get; set; }
        public string Author { get; set; }
        public string Img { get; set; }


    }
}