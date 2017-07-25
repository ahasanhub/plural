using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Lib
{
    public class Class1
    {
        public int ClassId { get; set; }

        void Call()
        {
            Func<int, int> del = x => x + 5;
            Console.WriteLine(del(5));
        }
    }
}
