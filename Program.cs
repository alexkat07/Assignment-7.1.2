namespace Assignment_7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "ab";
            string word2 = "pqrs";
            int i = 0;
        

            int wordLength = Math.Min(word1.Length, word2.Length);

            while (i < wordLength) 
            {
                Console.Write(word1[i]);
                Console.Write(word2[i]);
                i++;
            }
            if (word1.Length > wordLength) 
            {
                Console.WriteLine(word1[i..]);
            }
            else if (word2.Length > wordLength) 
            {
                Console.WriteLine(word2[i..]);
            }

            
            

        }
    }
}
