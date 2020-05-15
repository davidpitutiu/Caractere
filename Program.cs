using System;
using System.IO;

namespace Caractere
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;
            int c = 0;
            string y = File.ReadAllText(@"C:\Users\dpitu\source\repos\Caractere\TextFile3.txt");
            Console.WriteLine("Numarul total de caractere este: "+y.Length);
            for (int i = 0; i < y.Length; i++)
            {
                if(y[i]==65 || y[i]==69 || y[i]==73 || y[i]==79 || y[i]==85 || y[i] ==97 || y[i] ==101 || y[i] ==105 || y[i] ==111 || y[i] ==117)
                {
                    v++;
                }else if((y[i]<=122 && 97<y[i]) || (y[i]<=90 && 65<y[i]))
                {
                    c++;
                }
                
            }
            Console.WriteLine("Numarul de vocale este: "+v);
            Console.WriteLine("Numarul de consoane este :"+c);
            string[] lines = File.ReadAllLines(@"C:\Users\dpitu\source\repos\Caractere\TextFile3.txt");
            int l = 0;
            for(int i=0;i<lines.Length;i++)
            {
                if(lines[i]!= null)
                {
                    l++;
                }
            }
            Console.WriteLine("Numarul de linii este : " + l);

        }
    }
}
