using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Threading;


namespace LinaTheExplorer
{
    public class ClothingEntry
    {
        private static string _fileName = @"clothing.json";
        private static List<ClothingEntry> listOfClothing;

        public int _temp { get; set; }
        public string _suit { get; set; }
        
        public ClothingEntry(string suitName, int prefTemp)
        {
            _suit = suitName;
            _temp = prefTemp;
        }
        
        public static List<ClothingEntry> CreateListOfClothing ()
        {
            try
            {
                string list = File.ReadAllText(_fileName);
                listOfClothing = JsonConvert.DeserializeObject<List<ClothingEntry>>(list);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ERROR! No file clothing.json was found in current directory");
                Thread.Sleep(2000);
                Environment.Exit(404);  
                // throw; 
            }
            catch ( JsonException ex )
            {
                Console.WriteLine("ERROR! File doesn't fit json schema");
                Thread.Sleep(2000);
                Environment.Exit(404);
            }

            finally 
            {
                foreach (var clothes in listOfClothing)
                {
                    if (clothes._temp == 0 & clothes._suit == null)
                    {
                        Exception ex = new Exception();
                        Console.WriteLine("File doesn't consiste information that we need");
                        Environment.Exit(404);
                    }
                }
            }
            return listOfClothing;
        }

        public static void ListAppear(List<ClothingEntry> listOfClothing)
        {
            foreach (var clothes in listOfClothing)
            {
                Console.WriteLine($"Clothes:{clothes._suit}, pref temp = {clothes._temp}");
            }
        }
    }
}
