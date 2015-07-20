using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PWConvertorDLL;

namespace PasswordCrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            Password pw = new Password();
            string test = "tess";

            Console.WriteLine(test.GetHashCode());
        }
    }
}
