using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;


namespace LinaTheExplorer
{
    public class ClothingEntry
    {
        private static string _fileName = @"clothing.json";        
        private static string _schemaJson = @"schema.json";
        private static List<ClothingEntry> listOfClothing;

        public int Temp { get; set; }
        public string Suit { get; set; }


        public ClothingEntry(string suitName, int prefTemp)
        {
            Suit = suitName;
            Temp = prefTemp;
        }

     //   public ClothingEntry() { }

        public static List<ClothingEntry> CreateListOfClothing ()
        {
            string list = File.ReadAllText(_fileName);
            var schema = JSchema.Parse(File.ReadAllText(_schemaJson));
            var listTemp = JArray.Parse(list);
            bool valid = listTemp.IsValid(schema);

            if (!valid)
            { throw new JsonException(); }

            listOfClothing = JsonConvert.DeserializeObject<List<ClothingEntry>>(list);

                       
            return listOfClothing;
        }

        public static void ListAppear(List<ClothingEntry> listOfClothing)
        {
            foreach (var clothes in listOfClothing)
            {
                Console.WriteLine($"Clothes:{clothes.Suit}, pref temp = {clothes.Temp}");
            }
        }
    }
}
