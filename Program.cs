using System;
using System.Text;

namespace Home7
{
    class Program
    {
             static bool First( string line1, string line2)
            {
                if (line1 == line2)
                {
                    return true;
                }
                else return false;
            }

            static void Second(string str)
            {
                StringBuilder alpha =
                         new StringBuilder();
                StringBuilder num =
                         new StringBuilder();
                StringBuilder special =
                         new StringBuilder();

                for (int i = 0; i < str.Length; i++)
                {
                    if (Char.IsDigit(str[i]))
                    {
                         num.Append(str[i]);
                    }
                    else if ((str[i] >= 'A' &&
                             str[i] <= 'Z') ||
                             (str[i] >= 'a' &&
                              str[i] <= 'z'))
                        alpha.Append(str[i]);
                    else
                        special.Append(str[i]);
                }

                Console.WriteLine(alpha.Length);
                Console.WriteLine(num.Length);
                Console.WriteLine(special.Length);
            }

             static void Third(String str)
             {
                   char[] arr = str.ToCharArray();
                   Array.Sort(arr);
                   Console.WriteLine(String.Join("", arr));
             }

        static void Fourth(String Dstring)
        {
            char[] arr = Dstring.ToCharArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int  j = 0;              
                for ( j = i; j < arr.Length-1; j++)
                {
                    if (arr[i]==arr[j+1])
                    {
                        Console.WriteLine(arr[i]);
                    }
                    continue;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(First("Money", "Money"));

            string str = "gho454t98nsffvbdiw!!!AAAAAHHHter0rbl1de%";
            Second(str);

            string line = "letssortthis";
            Third(line);

            string Dstring = "Ilovemyfamily";
            Fourth(Dstring);
        }
    }
}
