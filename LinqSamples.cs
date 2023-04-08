using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 3, 6, 4, 8, 9, 1 };
            int target = 17;
            findpair(numbers, target);
        }

        // Find the pair in a array using LINQ
        public static void findpair(int[] num, int target)
        {
            var indexedInput = num.Select((n,i) => new { Number = n, Index = i });
            var result = from x in indexedInput
                         from y in indexedInput
                         where x.Index != y.Index && x.Number + y.Number == target
                         select new { a=x.Number,b=y.Number,c=x.Index,d=y.Index} ;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            
        }
		public static void EvenCount()
		{
		// Find the even number count
            var evenNum = num.Aggregate(0, (count, next) => next % 2 == 0 ? count + 1 : count);
            Console.WriteLine($"No of Event number: {evenNum.ToString()}");
		}
		public static void ReverseString()
		{
            // Reverse the sentence
            string sentence = "Verify the reverse sentence";
            string[] splitSentence = sentence.Split(' ');
            var reverseRes = splitSentence.Aggregate((currentSentence, next) => next + ' ' + currentSentence);
            Console.WriteLine($"Reverse result: {reverseRes}");
        }
		public static void ReverseWord()
		{
            // Reverse the word
            string word = "Churchill saraswathi";
            // method 1
            string reverRes = new string(word.ToCharArray().Reverse().ToArray());
            Console.WriteLine(reverRes);
            // method 2
            Console.WriteLine(String.Concat(word.ToCharArray().Reverse()));
            // method 3
            reverRes = string.Concat(word.Select((cur, next) => word[word.Length - (next + 1)]));
            Console.WriteLine(reverRes);
		}

        
    }
}
