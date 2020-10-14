using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<InitContext>
    {
        protected override void Seed(InitContext context)
        {
            context.Songs.Add(new Song() { Name = "firs song", Duration = 3.45, Size = 124 });
            context.Sounds.Add(new Sound() { Mode = "ON", Volume = 45.5 });
            context.Settings.Add(new Settings() { Name = "API", Mode = 1 });

            base.Seed(context);
        }
    }
}