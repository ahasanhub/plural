using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static async void FooAsync()
        {
            return;
        }

        static async Task BarAsync()
        {
            throw new NotImplementedException();
        }

        static async Task<int> QuxAsync()
        {
            return 42;
        }
    }
}
