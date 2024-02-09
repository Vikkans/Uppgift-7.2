using System;
using System.Diagnostics.Metrics;

namespace COnsole
{
   class Program
    {
        static void Main(string[] args)
        {
            List<int> maxtal = new List<int>();
            maxtal.Add(5);
            maxtal.Add(6);
            maxtal.Add(33);
            Max(maxtal);
           
            
        }

        static void Max(List<int> maxtal)
        {
           
            
            int störstatal = 0;

            for (int i = 0; i < maxtal.Count; i++)
            {
                if (maxtal[i] > störstatal) 
                {
                   störstatal = maxtal[i];
                }
            }

            Console.WriteLine(störstatal);
        
        }
     
           
            
         
       
    }
}
