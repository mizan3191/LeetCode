using System;

namespace _387_First_Unique_Character_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "aabb";
           
            Console.WriteLine(FirstUniqChar(s));
        }
        public static int FirstUniqChar(string s)
        {
            var x = -1;
            var c = s.ToCharArray();
            for(var i=0; i<c.Length; i++)
            {
                var m = 0;
                for(var j=0; j<c.Length; j++)
                {
                    if (c[i] == c[j])
                    {
                        m++;
                    }
                    if(m >= 2)
                    {
                        break;
                    }
                }

                if(m == 1)
                {
                    return i;
                }
            }

            return x;
        }
    }
}
