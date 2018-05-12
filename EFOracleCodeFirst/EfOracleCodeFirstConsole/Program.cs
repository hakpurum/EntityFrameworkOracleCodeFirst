using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfOracleCodeFirstConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OracleDbContext>());//modelde değişiklik var ise drop/create
            //Database.SetInitializer(new DropCreateDatabaseAlways<OracleDbContext>());//her zaman drop/create

            using (var context = new OracleDbContext())
            {
                var usergroup = context.UserGroupEntities.Add(new UserGroup
                {
                    Name = "test Grup"
                });

                context.SaveChanges();

                var user = context.UserEntities.Add(new User
                {
                    Name = "test user",
                    UserGroupId = usergroup.Id
                });

                context.SaveChanges();

                for (int i = 0; i < 10; i++)
                {
                    var page = new Page
                    {
                        Title = "Başlık" + i,
                        Description = "Açıklama",
                        UserId = user.Id,
                        Deneme = "deneme test"
                    };

                    context.PageEntities.Add(page);
                }

                context.SaveChanges();
            }
        }
    }
}
