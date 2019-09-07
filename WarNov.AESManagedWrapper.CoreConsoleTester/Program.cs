using System;
using WarNov.AESManagedWrapper.NetStandard;


namespace WarNov.AESManagedWrapper.CoreConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var ss = "alejandi";
            var encTxt = RMWCrypto.EncryptStringAES("13958291###soijfsdndn^^&&2342##", ss);
            Console.WriteLine(encTxt);
            var decTxt = RMWCrypto.DecryptStringAES(encTxt, ss);
            Console.WriteLine(decTxt);
        }
    }
}
