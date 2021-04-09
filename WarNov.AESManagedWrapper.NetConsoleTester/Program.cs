using System;
using WarNov.AESManagedWrapper.Net;


namespace WarNov.AESManagedWrapper.NetConsoleTester
{
    class Program
    {
        static void Main()
        {
            var ss = "alejandi";
            var encTxt = RMWCrypto.EncryptStringAES("13958291###soijfsdndn^^&&2342##", ss);
            Console.WriteLine(encTxt);
            var decTxt = RMWCrypto.DecryptStringAES(encTxt, ss);
            Console.WriteLine(decTxt);
        }
    }
}
