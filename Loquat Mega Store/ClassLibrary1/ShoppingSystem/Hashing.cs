namespace LoquatMegaStore.ShoppingSystem
{
    using System;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;

    public static class Hashing
    {
        public static string GenerateSaltedHash(string plainText, string salt)
        {
            HashAlgorithm algorithm = new SHA384Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            byte[] plainTextByteArray = Encoding.UTF8.GetBytes(plainText);
            byte[] saltByteArray = Encoding.UTF8.GetBytes(salt);

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainTextByteArray[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = saltByteArray[i];
            }

            return Convert.ToBase64String(algorithm.ComputeHash(plainTextWithSaltBytes));
        }

        public static bool CheckHash(string hash1, string hash2)
        {
            if (hash1.Length != hash2.Length)
            {
                return false;
            }

            for (int i = 0; i < hash1.Length; i++)
            {
                if (hash1[i] != hash2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
