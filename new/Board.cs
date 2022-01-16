using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
   public class Board
    {
        public string[] f = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void DrawBoard()
        {
            Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[1], f[2], f[3]);
            Console.WriteLine("===================");
            Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[4], f[5], f[6]);
            Console.WriteLine("===================");
            Console.WriteLine("   {0}  ||  {1}  ||  {2}   ", f[7], f[8], f[9]);

        }
    }
}
