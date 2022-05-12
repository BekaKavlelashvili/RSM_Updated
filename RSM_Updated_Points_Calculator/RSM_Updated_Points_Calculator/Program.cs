using System;
using System.Collections.Generic;
using System.Linq;

namespace RSM_Updated_Points_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> ops = new List<string> { "5", "-2", "4", "C", "D", "9", "+", "+" };
            Console.WriteLine(Calculate(ops));
        }

        public static int Calculate(List<string> ops)
        {
            Stack<string> vs = new Stack<string>();
            List<int> intList = new List<int>();
            for (int i = ops.Count - 1; i >= 0; i--)
            {
                vs.Push(ops[i]);
            }
            for (int i = 0; i < ops.Count; i++)
            {
                if (ops.Count > 1000 || ops.Count < 1)
                {
                    Console.WriteLine("The number of elements in an array is more than 1000 or less than 1");
                }
                else
                {
                    if (!vs.Peek().Equals("C") && !vs.Peek().Equals("D") && !vs.Peek().Equals("+"))
                    {
                        int x = int.Parse(vs.Peek());
                        intList.Add(x);
                        vs.Pop();
                    }
                    else
                    {
                        if (vs.Peek().Equals("+"))
                        {
                            int l = (i - intList.Count) + 1;
                            int x = (intList[i - l] + intList[i - l-1]);
                            intList.Add(x);
                            vs.Pop();
                        }
                        else
                        {
                            if (vs.Peek().Equals("C"))
                            {
                                int l = (i - intList.Count)+1;
                                intList.RemoveAt(i - l);
                                vs.Pop();
                            }
                            else
                            {
                                if (vs.Peek().Equals("D"))
                                {
                                    int l = (i - intList.Count) + 1;
                                    int x = intList[i - l] * 2;
                                    intList.Add(x);
                                    vs.Pop();
                                }
                            }
                        }
                    }
                }
            }
            return intList.Sum();
        }
    }
}
