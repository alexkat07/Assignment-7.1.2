namespace Assignment_7._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word1 = "ab";
            string word2 = "pqrs";
            string mergedString = "";
            int i = 0;
        

            

            while (i < word1.Length || i < word2.Length) 
            {
                if (i < word1.Length) 
                {
                    mergedString += word1[i];
                }
                if (i < word2.Length) 
                {
                    mergedString += word2[i];
                }
                i++;
            
            }
            Console.WriteLine(mergedString);
            
            
            

            
            

        }
    }
}
