using System.Data.Entity;
using WorkWithModel.Models;

namespace WorkWithModel.DataAccess
{
    public class UserInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        protected override void Seed(UserContext context)
        {
            context.Users.Add(new User
            {
                UserName = "admin",
                Password = "123",
                Email = "example@gmail.com",
                IsAdmin = true
            });
            context.SaveChanges();
        }
    }
}