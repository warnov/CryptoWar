using System;

namespace WarNov.CryptAndHash.ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Plain pwd: ");
            var plainPwd = Console.ReadLine();
            Console.Write($"Workforce Level: ");
            int workForceLevel = int.Parse(Console.ReadLine());
            Console.Write($"Black Pepper: ");
            string blackPepper = Console.ReadLine();

            var securedPwdInfo = WarBCrypt.SecurePwd(plainPwd, blackPepper, workForceLevel);

            Console.WriteLine($"Hashed pwd: {securedPwdInfo.SecuredPwd}");
            Console.WriteLine($"Salt: {securedPwdInfo.Salt}");
            Console.WriteLine($"Red Pepper: {securedPwdInfo.RedPepper}");



            Console.WriteLine($"Password Verification:");
            Console.Write($"Plain pwd:");
            plainPwd = Console.ReadLine();
            Console.Write($"Hashed pwd:");
            var hashedPwd = Console.ReadLine();
            Console.Write($"Salt:");
            var salt = Console.ReadLine();
            Console.Write($"Red Pepper:");
            var redPepper = Console.ReadLine();
            Console.Write($"Black Pepper:");
            blackPepper = Console.ReadLine();
            securedPwdInfo = new SecuredPwdInfo
            {
                RedPepper = redPepper,
                Salt = salt,
                SecuredPwd = hashedPwd
            };

            var verificationResult = WarBCrypt.Verify(plainPwd, securedPwdInfo, blackPepper);
            Console.WriteLine($"Password Verification result {verificationResult}");


        }
    }
}
