using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            Console.WriteLine(p.Prefix("test and test"));
        }

        public string Prefix(string input)
        {
            //Special case: input is null, return null.
            if(input == null) 
			{
                return null;
			}
            //Setup
            int len = input.Length;
            int numWords = 0;
            bool sawSpace = false;
            //Body
            for(int i=0;i<len;i++){
                if(input[i] == ' ') { sawSpace = true; }
                if(input[i] != ' ' && sawSpace == true)
                {
                    sawSpace = false;
                    numWords++;
                }
				if(numWords == 0 && input[i] != ' ') { numWords = 1; } //So the first word, isn't missed
            }
            //Output
            string output = $"{len},{numWords}:{input}";
            return output;
        }
    }
}