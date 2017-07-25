using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mountaineering.Models
{
    public class DbInitializer : DropCreateDatabaseAlways<DbContext>
    {
        protected override void Seed(DbContext db)
        {
            db.Articles.Add(new Article { Data = DateTime.Now, NameArticle = "NameArticle1", Author = "Me", Img = "img.jpg" });
            db.Articles.Add(new Article { Data = DateTime.Now, NameArticle = "NameArticle2", Author = "Me", Img = "img.jpg" });
            db.Articles.Add(new Article { Data = DateTime.Now, NameArticle = "NameArticle3", Author = "Me", Img = "img.jpg" });

            base.Seed(db);
        }
    }
}