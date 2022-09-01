using System;
namespace HashTable
{
    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("To be or not To be");
            LinkedHashMap<string, int> linkedHashMap = new LinkedHashMap<string, int>(5);
            string sentence = "to be or not to be to be to be be";
            string[] words = sentence.ToLower().Split(" ");
            foreach(string word in words)
            {
                int value = linkedHashMap.Get(word);                                       
                if (value == default)                                                      
                {
                    value = 1;
                }
                else value += 1;                                                          
                linkedHashMap.Add(word, value);                                            
            }
            int frequency = linkedHashMap.Get("be");
            Console.WriteLine(frequency);

        }
    }
}