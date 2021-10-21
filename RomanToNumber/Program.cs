using System;
using System.Collections.Generic;

namespace RomanToNumber
{
    class Program
    {
        static void Main(string[] args) {
            
             var romanToNum = new Dictionary<char, int>()
             {
                { 'X',10 },
                { 'I',1 },
                { 'V',5 },
                { 'L',50 },
                { 'D',500 },
                { 'M',1000 },
                { 'C',100 }
             };

           
            int sum = 0;
            Console.WriteLine("Write the ROMAN NUMBER");
            string input = Console.ReadLine(); 
            for (int i = 0; i < input.Length; i++)
            {
                int variable1= romanToNum[input[i]];
                if (i < input.Length - 1)
                {
                    int variable2 = romanToNum[input[i + 1]];
                    if (variable1 >= variable2)
                    {
                        sum += variable1;
                    }
                    else
                    {
                        int l = variable2 - variable1;
                        if (l ==40  ||l ==4 || l == 400 || l == 9 || l == 90 || l == 900)
                        {
                            sum += l;
                        }
                        else
                        {
                            Console.WriteLine("not right");
                            break;
                        } 
                    }
                }
            }
            Console.WriteLine("The converted number:");
            Console.WriteLine(sum);
        }
    }
}
    

