using System;

namespace CryptoWar
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = Console.ReadLine();
            string key = Console.ReadLine();
            string enc = Crypto.EncryptStringAES(msg, key);
            Console.WriteLine(enc);
            Console.WriteLine(Crypto.DecryptStringAES(enc, key));
            Console.ReadLine();
        }
    }
}