using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
                var randomNumber = new Random().Next(999999999).ToString() + new Random().Next(99999).ToString();
                Console.WriteLine(randomNumber);
        }
    }
}
