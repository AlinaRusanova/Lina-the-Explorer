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
            string list = File.ReadAllText(_fileName);
            listOfClothing = JsonConvert.DeserializeObject<List<ClothingEntry>>(list);
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
