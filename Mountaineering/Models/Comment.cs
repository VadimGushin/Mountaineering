using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mountaineering.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string NameAuthor { get; set; }
        public string Img { get; set; }
        public string CommentText { get; set; }
    }
}