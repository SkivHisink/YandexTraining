using System;

namespace FirtsTask
{
    class Program
    {
        public Program()
        {

        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static void FindPolyndrom(string str, out string resultStr)
        {
            resultStr = "";
            bool isFound = false;
            for (int i = 2; i < str.Length+1; i++)
            {
                for (int j = 0; j < str.Length-i+1; ++j)
                {
                    var tempStr = str.Substring(j, i);
                    if (tempStr == Reverse(tempStr))
                    {
                        isFound = true;
                        if (resultStr.Length < 2)
                        {
                            resultStr = tempStr;
                        }
                        else
                        {
                            if (resultStr.Length < tempStr.Length)
                            {
                                break;
                            }

                            for (int k = 0; k < tempStr.Length; k++)
                            {
                                if (resultStr[k] > tempStr[k])
                                {
                                    resultStr = tempStr;
                                    break;
                                }
                            }
                        }
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
        }

        public static void Main()
        {
            string input = Console.ReadLine();
            FindPolyndrom(input, out string result);
            Console.Write((result.Length > 1) ? result : -1);
        }

        public static void FindPolyndromLegacy(string str, out string resultStr)
        {
            resultStr = "";
            int minPolySize = Int32.MaxValue;
            int beginIndex = str.Length;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = str.Length; j > i; j--)
                {
                    int m = i;
                    int n = j;
                    for (m = i; m < n; ++m)
                    {
                        for (n = j; n > m; --n)
                        {
                            if (n - m > 1)
                            {
                                var temp = str.Substring(m, n - m);
                                if (temp == Reverse(temp) && temp.Length > 1 && temp.Length < minPolySize)
                                {
                                    if (minPolySize > temp.Length && m < beginIndex)
                                    {
                                        resultStr = temp;
                                        minPolySize = temp.Length;
                                        m = beginIndex;
                                    }
                                    if (resultStr.Length == 2)
                                    {
                                        //return;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

            }
        }

    }
}