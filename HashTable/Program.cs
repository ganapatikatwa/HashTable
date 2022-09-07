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

            ///UC_2:Find the frequency of word in paragraph
            Console.WriteLine("Paranoids are not"+
                                "paranoid because they are paranoid but" +
                                "because they keep putting themselves" +
                                "deliberately into paranoid avoidable" +
                                    "situations");
            string Paragraph = "“Paranoids are not paranoid because they are " +
               "paranoid paranoid paranoid but because they keep putting themselves deliberately into" +
               " paranoid avoidable situations";
            string[] letters = Paragraph.ToLower().Split(" ");

            foreach (string word in letters)
            {
                int value = linkedHashMap.Get(word);
                if (value == default)
                {
                    value = 1;
                }
                else value += 1;
                linkedHashMap.Add(word, value);
            }
            int frequency1 = linkedHashMap.Get("paranoid");
            Console.WriteLine(frequency1);

            //UC_3:Remove particular word from the paragraph

            linkedHashMap.Remove("avoidable");
            int frequency2 = linkedHashMap.Get("avoidable");

            Console.WriteLine(frequency2);

        }
    }
}