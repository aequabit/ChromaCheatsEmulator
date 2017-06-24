using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ChromaFramework.Encryption
{
    public static class Rijndael
    {
        public static string Decrypt(string text, string key, string iv)
        {
            string str = key;
            string str1 = iv;
            RijndaelManaged rijndaelManaged = new RijndaelManaged()
            {
                BlockSize = 256,
                KeySize = 256,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros
            };

            byte[] bytes;
            if (ChromaCheatsEmulator.Properties.Settings.Default.key_base64)
                bytes = Convert.FromBase64String(str);
            else
                bytes = Encoding.UTF8.GetBytes(str);

            byte[] numArray;
            if (ChromaCheatsEmulator.Properties.Settings.Default.key_base64)
                numArray = Convert.FromBase64String(str1);
            else
                numArray = Encoding.UTF8.GetBytes(str1);

            ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor(bytes, numArray);
            byte[] numArray1 = Convert.FromBase64String(text);
            byte[] numArray2 = new byte[(int)numArray1.Length];
            MemoryStream memoryStream = new MemoryStream(numArray1);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Read);
            cryptoStream.Read(numArray2, 0, (int)numArray2.Length);
            cryptoStream.Dispose();
            memoryStream.Dispose();
            //rijndaelManaged.Dispose();
            return Encoding.UTF8.GetString(numArray2).Replace("\\0", "").Replace("\0", "");
        }

        public static string Encrypt(string text, string key, string iv)
        {
            string str = key;
            string str1 = iv;
            RijndaelManaged rijndaelManaged = new RijndaelManaged()
            {
                BlockSize = 256,
                KeySize = 256,
                Mode = CipherMode.CBC,
                Padding = PaddingMode.Zeros
            };

            byte[] bytes;
            if (ChromaCheatsEmulator.Properties.Settings.Default.key_base64)
                bytes = Convert.FromBase64String(str);
            else
                bytes = Encoding.UTF8.GetBytes(str);

            byte[] numArray;
            if (ChromaCheatsEmulator.Properties.Settings.Default.key_base64)
                numArray = Convert.FromBase64String(str1);
            else
                numArray = Encoding.UTF8.GetBytes(str1);

            ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor(bytes, numArray);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, cryptoTransform, CryptoStreamMode.Write);
            byte[] bytes1 = Encoding.UTF8.GetBytes(text);
            cryptoStream.Write(bytes1, 0, (int)bytes1.Length);
            cryptoStream.FlushFinalBlock();
            byte[] array = memoryStream.ToArray();
            cryptoStream.Dispose();
            memoryStream.Dispose();
            //rijndaelManaged.Dispose();
            return Convert.ToBase64String(array);
        }
    }
}