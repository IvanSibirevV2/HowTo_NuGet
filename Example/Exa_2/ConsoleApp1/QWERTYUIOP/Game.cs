using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWERTYUIOP
{
    public static class Game
    {
        public static System.Boolean p_StoKan_1 = false;
        public static System.Boolean p_StoKan_2 = false;
        public static System.Boolean p_StoKan_3 = false;
        public static System.Random p_Ran = new Random();
        public static void Ygadai()
        {
            System.Console.WriteLine(".p_StoKan_1=?");
            System.Console.WriteLine(".p_StoKan_2=?");
            System.Console.WriteLine(".p_StoKan_3=?");
            System.Console.WriteLine("Gde sharik?");
            switch (p_Ran.Next(1, 3))
            {
                case 1: p_StoKan_1 = true; break;
                case 2: p_StoKan_2 = true; break;
                case 3: p_StoKan_3 = true; break;
                default: break;
            }
            int qwe = -1;
            System.Boolean _flag = false;
            do
            {
                while (!System.Int32.TryParse(System.Console.ReadLine(), out qwe)) ;
            }
            while ((qwe < 0) || (qwe > 3));
            System.Console.WriteLine(".p_StoKan_1=" + p_StoKan_1);
            System.Console.WriteLine(".p_StoKan_2=" + p_StoKan_2);
            System.Console.WriteLine(".p_StoKan_3=" + p_StoKan_3);
        }
    }
}
