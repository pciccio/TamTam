using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using TamTam.Models.Geometry.Polygon;

namespace TamTam.Console
{
    /// <summary>
    /// This class is used to prove the service and architechural concept.
    /// </summary>
    class Program
    {



        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// It I'll run the console application.
        /// </summary>
        static void Main()
        {
            var anagram = "poultry outwits ants";
            var md5 = "4624d200580677270a54ccff86b9610e".ToUpper();
            var wordListFilePath = @"D:\GitHubPublicNewAccount\TamTam\TamTam.Console\wordlist";

            var hash = CalculateMD5Hash(anagram);


            StreamReader sr = new StreamReader(wordListFilePath);
            var wordList = sr.ReadToEnd().Split(Convert.ToChar("'"));
            foreach (var word in wordList)
            {
                var hash1 = CalculateMD5Hash(word);
                if (hash1 == md5)
                {

                }
                var subWord = word.Split(null);
                foreach (var subWork in subWord)
                {
                    var hash2 = CalculateMD5Hash(subWork);
                    if (hash2 == md5)
                    {

                    }
                }

            }

            System.Console.ReadLine();
            return;

            int lenA, lenB, lenC;

            System.Console.Write("Discover Triangle Type\r\nPlease inform bellow the three sides length\r\n\r\n");

            lenA = ReadLineParser("A");
            lenB = ReadLineParser("B");
            lenC = ReadLineParser("C");

            System.Console.Write("Getting triangle type...\r\n");

            var triangle = GetTriangle(lenA, lenB, lenC);

            System.Console.Write("\r\nYour triangle is {0}\r\n\r\nPress any key to close", triangle.TriangleType);
            System.Console.ReadLine();
        }

        static void WriteSide(string side)
        {
            System.Console.Write("Side {0}:", side);
        }

        /// <summary>
        /// Read line and parse to int also validate the digits
        /// </summary>
        /// <param name="side">Side name</param>
        /// <returns>Length inputed by user</returns>
        static int ReadLineParser(string side)
        {
            WriteSide(side);

            var value = System.Console.ReadLine();
            var parsedValue = 0;

            while (!int.TryParse(value, out parsedValue))
            {
                System.Console.Write("Only integer numbers are allowed!\r\n\r\n");

                WriteSide(side);
                value = System.Console.ReadLine();
            }

            return parsedValue;
        }

        /// <summary>
        /// Get's a triangle from triangle API endpoint
        /// </summary>
        /// <param name="lengthA">Triangle side a length</param>
        /// <param name="lengthB">Triangle side b length</param>
        /// <param name="lengthC">Triangle side c length</param>
        /// <returns></returns>
        static Triangle GetTriangle(int lengthA, int lengthB, int lengthC)
        {
            var client = new HttpClient();

            var endpoint = string.Format("http://tradetestv2.azurewebsites.net/triangle/{0}/{1}/{2}", lengthA, lengthB, lengthC);

            var getStringTask = client.GetStringAsync(endpoint);

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Triangle>(getStringTask.Result);
        }
    }
}
