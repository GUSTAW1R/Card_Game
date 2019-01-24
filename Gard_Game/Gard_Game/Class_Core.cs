using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gard_Game
{
    public class Class_Core : ICentral_Interface
    {
        public static int[,] array_ai = new int[10, 10];
        public static int Attak_1 = 0;
        public static int Attak_2 = 0;
        public static void test_method1()
        {
            array_ai[0, 0] = 3;
            array_ai[1, 1] = 2;
            array_ai[2, 2] = 1;
        }
        public void Output_AI_Field()
        {
            test_method1();

        }
        public void Output_GG_Field()
        {
            
        }
       
    }
}
