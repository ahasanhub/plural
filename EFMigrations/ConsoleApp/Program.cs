using System;
using System.Collections.Generic;
using System.Configuration;
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
            var context = new TwitterContext(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            CreateDatabase(context);
        }

        private static void CreateDatabase(DbContext context)
        {
            var co = context.Database.Connection;
            //if (context.Database.Exists())
            //{
            //    context.Database.Delete();
            //}
           context.Database.Initialize(true);
        }
    }
}
