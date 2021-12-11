using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        //Burada  Entity Katmanında oluşturduğumuz classları (Tabloları) Database göndermek için DataAccess Katmanında 
         //prop  özelliğini kullanarak   Dbset ile  oluşutmuş olduğumuz parametreyi  
        //veritanabında Nasıl oluşturulacağını beliryiyoruz  
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

        // code first migration  yapabilmemiz için yapılması gereken adımlar  Visual Studio nun üst kısmında bulunan View sekmesine tıklanır  açılan pencerede other windows tıklanır 
        // karşımıza gelen ekranda Package Manager Console  tıkanır ve Default project kısmında DataAccsessLayer seçilir sonra  consol ekranına  enable-migrations yazılır enter tuşuna basılır
        //işlem sonucunda çıktı verdiği ekranda   utomaticMigrationsEnabled = False; gelir biz bunu utomaticMigrationsEnabled = true; çevirmeliyiz ve conola   update-database yazılır ve enter basılır

    }
}
