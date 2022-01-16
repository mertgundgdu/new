using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newproject
{
    class checkwin

    {
        static string[] f = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public bool CheckWin()
        {
            if (f[1] == "O" && f[2] == "O" && f[3] == "O")
            {
                return true;
            }
            else if (f[4] == "O" && f[5] == "O" && f[6] == "O")
            {
                return true;
            }
            else if (f[7] == "O" && f[8] == "O" && f[9] == "O")
            {
                return true;
            }

            else if (f[1] == "O" && f[5] == "O" && f[9] == "O")
            {
                return true;
            }
            else if (f[7] == "O" && f[5] == "O" && f[3] == "O")
            {
                return true;
            }

            else if (f[1] == "O" && f[4] == "O" && f[7] == "O")
            {
                return true;
            }
            else if (f[2] == "O" && f[5] == "O" && f[8] == "O")
            {
                return true;
            }
            else if (f[3] == "O" && f[6] == "O" && f[9] == "O")
            {
                return true;
            }

            if (f[1] == "X" && f[2] == "X" && f[3] == "X")
            {
                return true;
            }
            else if (f[4] == "X" && f[5] == "X" && f[6] == "X")
            {
                return true;
            }
            else if (f[7] == "X" && f[8] == "X" && f[9] == "X")
            {
                return true;
            }

            else if (f[1] == "X" && f[5] == "X" && f[9] == "X")
            {
                return true;
            }
            else if (f[7] == "X" && f[5] == "X" && f[3] == "X")
            {
                return true;
            }

            else if (f[1] == "X" && f[4] == "X" && f[7] == "X")
            {
                return true;
            }
            else if (f[2] == "X" && f[5] == "X" && f[8] == "X")
            {
                return true;
            }
            else if (f[3] == "X" && f[6] == "X" && f[9] == "X")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

