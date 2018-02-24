using Fitness.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Model
{
    public class DatabaseInitializer:DropCreateDatabaseIfModelChanges<AppModelEntities>
    {
        protected override void Seed(AppModelEntities context)
        {
            context.Invitation.AddOrUpdate(c => c.Content, new Invitation { Id=Guid.NewGuid().ToString(), Content = "first one", PicUrl = "uri", PublishTime = DateTime.Now, IsDeleted = false, UserKey = "123" }, new Invitation { Id = Guid.NewGuid().ToString(), Content = "second one", PicUrl = "uri", PublishTime = DateTime.Now, IsDeleted = false, UserKey = "321" }, new Invitation { Id = Guid.NewGuid().ToString(), Content = "third one", PicUrl = "uri", PublishTime = DateTime.Now, IsDeleted = false, UserKey = "456" }, new Invitation { Id = Guid.NewGuid().ToString(), Content = "fourth one", PicUrl = "uri", PublishTime = DateTime.Now, IsDeleted = false, UserKey = "654" }, new Invitation { Id = Guid.NewGuid().ToString(), Content = "fiveth one", PicUrl = "uri", PublishTime = DateTime.Now, IsDeleted = false, UserKey = "789" }, new Invitation { Id = Guid.NewGuid().ToString(), Content = "sixth one", PicUrl = "uri", PublishTime = DateTime.Now, IsDeleted = false, UserKey = "987" });
            context.Article.AddOrUpdate(c => c.Title, new Article { Id = Guid.NewGuid().ToString(), Content = "this is the classic Editor of ckeditor", Title="CKEditor", ForeignKey="123", WriteTime=DateTime.Now });
            base.Seed(context);
        }
    }
    public class IdentityDatabaseInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
        }
    }
}
