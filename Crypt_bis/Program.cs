using System;
using System.Diagnostics;

namespace Crypt_bis
{
    internal class Program
    {
        public static void Main()
        {
            Stopwatch clockCaesar = new Stopwatch();
            Stopwatch clockGamma = new Stopwatch();
        
            Console.WriteLine("Type a string to encrypt:");  
            string UserString = Console.ReadLine();  
  
            Console.WriteLine("\nEnter your Key:");  
            int key = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("\nGenerating your Key for Gamma Cipher:");
            string key2 = Gamma.GetKey();

           
            clockCaesar.Start();
            string cipherText = Caesar.Encipher(UserString, key);
            string decryptedText = Caesar.Decipher(cipherText, key); 
            clockCaesar.Stop();
            
            Console.WriteLine("\nEncrypted Data for Caesar\n"); 
            Console.WriteLine(cipherText);  
            
            Console.WriteLine("\nDecrypted Data:\n");
            Console.WriteLine(decryptedText); 
            
            Console.WriteLine("Time spent for caesar cypher: " + clockCaesar.Elapsed);
            
            clockGamma.Start();
            string cipherText2 = Gamma.GammaCipher(UserString, key2);
            string decryptedText2 = Gamma.GammaCipher(cipherText2, key2);  
            clockGamma.Stop();
            
            Console.WriteLine("\nEncrypted Data for Gamma\n"); 
            Console.WriteLine(cipherText2);
            Console.WriteLine("\nDecrypted Data:\n");
            Console.WriteLine(decryptedText2); 
            
            Console.WriteLine("Time spent for gamma cypher: " + clockGamma.Elapsed);
            
            Console.ReadKey();  
            Console.ReadKey(); 
        }
    }
}