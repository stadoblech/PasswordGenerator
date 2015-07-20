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
            string test = "tesa";


            Console.WriteLine(pw.getHash("www.facebook.com"));
            Console.WriteLine(pw.getHash("google"));
            Console.WriteLine(pw.getHash("www.google.com"));
            Console.WriteLine(pw.getHash("www.nasralfrantsdfsdfsdfsdfsdfsdfasdfasdfsadfsdfsdfsdfsdfasdfsdfsadfasdfasfadfgdfgdfgxcvcv dfgaerterg    sdasanatrabanta.com"));
            Console.WriteLine(pw.getHash("aa"));
            Console.WriteLine(pw.getHash("google"));
            Console.WriteLine(pw.getHash("gfogle"));
            Console.WriteLine(pw.getHash(" dasdasdasdrf2    3r452vvvwe89           gsdfgsdfgert  dfsg3286rweq55adf wefc2398we8r46qcfr45qwerasdfwerwesdvscvxcvasdfasdfwerwerasdfxcvzxawsfasdfasd456cfwqercf"));



            
            foreach(char c in test)
            {
                decimal d = c;
                d /= 7;
                //Math.Round(d,new int(2));
                //Console.WriteLine(Math.Round(d, 3));
            }
            //Console.WriteLine(test.GetHashCode());
        }
    }
}
