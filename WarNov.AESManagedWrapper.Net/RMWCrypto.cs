using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WarNov.AESManagedWrapper.Net
{
    public static class RMWCrypto
    {
        const string PLAIN_TEXT = "plainText";
        const string SHARED_SECRET = "sharedSecret";
        const string CIPHER_TEXT = "cipherText";


        private static readonly byte[] _salt = Encoding.UTF8.GetBytes(@"tQ?)&%d(&>96432___???()/&)(&)(&w\7^(4[?7u&*^%&^%&%555769rsrsrhhhhhhh######");

        public static string EncryptStringAES(string plainText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException(PLAIN_TEXT);
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException(SHARED_SECRET);
            string outStr = null;
            // Encrypted string to return
            AesManaged aesAlg = null;
            // AesManaged object used to encrypt the data
            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new(sharedSecret, _salt);
                // Create a AesManaged object
                // with the specified key and IV.
                aesAlg = new AesManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);
                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for encryption.
                using MemoryStream msEncrypt = new();
                using (CryptoStream csEncrypt =
                    new(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using StreamWriter swEncrypt = new(csEncrypt);
                    //Write all data to the stream.
                    swEncrypt.Write(plainText);
                }
                outStr = Convert.ToBase64String(msEncrypt.ToArray());
            }
            finally
            {
                // Clear the AesManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }
            // Return the encrypted bytes from the memory stream.
            return outStr;
        }

        public static string DecryptStringAES(string cipherText, string sharedSecret)
        {
            if (string.IsNullOrEmpty(cipherText))
                throw new ArgumentNullException(CIPHER_TEXT);
            if (string.IsNullOrEmpty(sharedSecret))
                throw new ArgumentNullException(SHARED_SECRET);
            // Declare the AesManaged object
            // used to decrypt the data.
            AesManaged aesAlg = null;
            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;
            try
            {
                // generate the key from the shared secret and the salt
                Rfc2898DeriveBytes key = new(sharedSecret, _salt);
                // Create a AesManaged object
                // with the specified key and IV.
                aesAlg = new AesManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = key.GetBytes(aesAlg.BlockSize / 8);
                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                // Create the streams used for decryption.
                byte[] bytes = Convert.FromBase64String(cipherText);
                using MemoryStream msDecrypt = new(bytes);
                using CryptoStream csDecrypt =
                    new(msDecrypt, decryptor, CryptoStreamMode.Read);
                using StreamReader srDecrypt = new(csDecrypt);
                // Read the decrypted bytes from the decrypting stream
                // and place them in a string.
                plaintext = srDecrypt.ReadToEnd();
            }
            finally
            {
                // Clear the AesManaged object.
                if (aesAlg != null)
                    aesAlg.Clear();
            }
            return plaintext;
        }
    }
}
