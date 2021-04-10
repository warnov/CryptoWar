using System.Security.Cryptography;
using System.Text;
using BCryptNet = BCrypt.Net.BCrypt;



namespace WarNov.CryptAndHash
{
    public static class WarBCrypt
    {
        public static SecuredPwdInfo SecurePwd(string plainPwd, string blackPepper, int workForceLevel = 11)
        {

            var salt = BCryptNet.GenerateSalt();
            var redPepper = BCryptNet.GenerateSalt();
            var hashedPwd = Hasher(plainPwd, salt, redPepper, blackPepper, workForceLevel);

            return new SecuredPwdInfo
            {
                RedPepper = redPepper,
                Salt = salt,
                SecuredPwd = hashedPwd
            };
        }


        public static bool Verify(string plainPwd, SecuredPwdInfo securedPwdInfo, string blackPepper)
        {
            var calculatedHash = WarBCryptSHA512(plainPwd, securedPwdInfo.Salt, securedPwdInfo.RedPepper, blackPepper);
            var verification = BCryptNet.Verify(calculatedHash, securedPwdInfo.SecuredPwd);
            return verification;
        }


        static string Hasher(string plainPwd, string salt, string redPepper, string blackPepper, int workForceLevel = 11)
        {
            var hashedPwd = WarBCryptSHA512(plainPwd, salt, redPepper, blackPepper);
            var finalPwd = BCryptNet.HashPassword(hashedPwd, workFactor: workForceLevel);
            return finalPwd;
        }

        static string WarBCryptSHA512(string plainPwd, string salt1, string salt2, string pepper)
        {
            var enrichedPwd = $"{salt1}{plainPwd}{salt2}";
            var plainBytes = Encoding.UTF8.GetBytes(enrichedPwd);
            SHA512 shar = new SHA512Managed();
            var hashedPwdBytes = shar.ComputeHash(plainBytes);
            var hashedPwd = ByteArrayToString(hashedPwdBytes);
            plainBytes = Encoding.UTF8.GetBytes($"{pepper}{hashedPwd}");
            hashedPwdBytes = shar.ComputeHash(plainBytes);
            hashedPwd = ByteArrayToString(hashedPwdBytes);
            return hashedPwd;
        }


        public static string ByteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new("");

            for (int i = 0; i < inputArray.Length; i++)
                output.Append(inputArray[i].ToString("X2"));

            return output.ToString();
        }
    }


}
