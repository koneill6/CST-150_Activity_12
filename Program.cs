using System;
using System.Collections;

namespace CST_150_Activity_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //initializing the counter for number of words that end in E or T
            int numberOfWords = 0;
            //reads all words in the text doc and makes them lowercase
            string text = System.IO.File.ReadAllText(@"C:\Users\Kody\Desktop\Test.txt").ToLower();
            //splits the string into individual words
            String[] words = text.Split(' ');

            foreach(String word in words)
            {
                //converts String to char array to check last value
                char[] tempWord = word.ToCharArray();
                if(tempWord[tempWord.Length-1] == 'e' || tempWord[tempWord.Length - 1] == 't')
                {
                    //if last value is e or t then it incriments the counter
                    numberOfWords++;
                }
            }

            Console.WriteLine("Number of words that end in e or t: " + numberOfWords);
        }
    }
}
