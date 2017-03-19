using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] truths = new bool[10];
            for(int i =0;i<truths.Length;i++){
                if(i%2==0){
                    truths[i] = true;
                }
            }
            int[,] multTable = new int[10,10];
            for(int first = 0;first<10;first++){
                for(int second=0;second<10;second++){
                    multTable[first,second] = first*second;
                }
            }
            Console.WriteLine(multTable);
            foreach(var item in multTable){
                Console.WriteLine(item);
            }
            List<string> iceCream = new List<string>();
            iceCream.Add("Chocolate");
            iceCream.Add("Vanilla");
            iceCream.Add("Cookies and Cream");
            iceCream.Add("Strawberry");
            iceCream.Add("Birthday Cake");

            foreach (string flavor in iceCream){
                Console.WriteLine(flavor);
            }
            Console.WriteLine("count is" + iceCream.Count);
            Console.WriteLine(iceCream[2]);
            iceCream.RemoveAt(2);
            Console.WriteLine(iceCream.Count);

            Dictionary<string,string> userInfo = new Dictionary<string,string>();
            foreach(string userName in names){
                userInfo.Add(userName, null);
            }

            foreach(var entry in userInfo){
                //Console.WriteLine(entry);
                userInfo[entry.Value] = iceCream[rand.Next(0,4)];
            }
        }
    }
}
