using System;

namespace EncryptionAndDecryptionUsingASymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            Console.WriteLine("Please enter a string to encrypttion");
            var str = Console.ReadLine();
            Console.WriteLine(str);
            var encryptedString = AesOperation.EncryptString(key, str);
            Console.WriteLine($"Encrypted string: {encryptedString}");
            Console.WriteLine(encryptedString);

            var decryptedString = AesOperation.DecryptString(key, encryptedString);
            Console.WriteLine($"Decrypted string: {decryptedString}");
            Console.WriteLine(decryptedString);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
