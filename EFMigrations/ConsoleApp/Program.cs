using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TwitterContext();
            CreateDatabase(context);
        }

        private static void CreateDatabase(DbContext context)
        {
            if (context.Database.Exists())
            {
                context.Database.Delete();
            }
           context.Database.Create();
        }
    }
}
