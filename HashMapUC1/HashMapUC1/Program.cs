using System;

namespace HashMapUC1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use Case 1
            Console.WriteLine("Use Case 1");
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "Be");
            hash.Add("2", "Or");
            hash.Add("3", "Not");
            hash.Add("4", "To");
            hash.Add("5", "Be");

            string hash5 = hash.Get("5");
            Console.WriteLine("\n5th Index Value: " +hash5);

            string hash2 = hash.Get("2");
            Console.WriteLine("\n2nd Index Value: " +hash2);

            //Use Case 2
            Console.WriteLine("Use Case 2");
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Console.WriteLine(paragraph);


            //Use Case 3
            Console.WriteLine("Use Case 3");
            int k = 1;
            string paragraph1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paragraphSplit = paragraph1.Split(" ");
            MyMapNode<int, string> myMapNode = new MyMapNode<int, string>(paragraphSplit.Length);
            foreach (string word in paragraphSplit)
            {
                myMapNode.Add(k, word);
                k++;
            }

            myMapNode.Remove(18);
            for(k = 1; k < paragraphSplit.Length; k++)
            {
                string value = myMapNode.Get(k);
                Console.WriteLine(k+" "+value);
            }
        }
    }
}
