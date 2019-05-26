using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STPAR
{
    class Program
    {
        static Queue<int> queIn = new Queue<int>();
        static Queue<int> queOut = new Queue<int>();
        static Stack<int> helpStack = new Stack<int>();

        static Queue<int> ReadData()
        {
            int t = Int32.Parse(Console.ReadLine());
            if(t == 0) return null;

            int[] tab = Array.ConvertAll(
                Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries), int.Parse
            );

            return new Queue<int>(tab);
        }


        static void Main(string[] args)
        {
            while((queIn = ReadData()) != null)
            {

            }
        }
    }
}
