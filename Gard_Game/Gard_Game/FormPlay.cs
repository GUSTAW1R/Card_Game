using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gard_Game
{
    public partial class FormPlay : Form
    {
        public static string PB_W;
        public static int PB_H;
        public static string CoorX;
        public static string CoorY;
        public FormPlay()
        {
            InitializeComponent();
        }
        private void OutPut_AI()
        {
            
        }
        private void button_Attak(object sender, EventArgs e)
        {
            PB_W = Convert.ToString(textBoxFirst.Text);
            PB_H = Convert.ToInt32(textBoxSecond.Text);
            switch (PB_W)
            {
                case "A":
                    switch (PB_H)
                    {
                        case 1:
                            A1.BackColor = Color.Black;
                            break;
                        case 2:
                            A2.BackColor = Color.Black;
                            break;
                        case 3:
                            A3.BackColor = Color.Black;
                            break;
                        case 4:
                            A4.BackColor = Color.Black;
                            break;
                        case 5:
                            A5.BackColor = Color.Black;
                            break;
                        case 6:
                            A6.BackColor = Color.Black;
                            break;
                        case 7:
                            A7.BackColor = Color.Black;
                            break;
                        case 8:
                            A8.BackColor = Color.Black;
                            break;
                        case 9:
                            A9.BackColor = Color.Black;
                            break;
                        case 10:
                            A10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "B":
                    switch (PB_H)
                    {
                        case 1:
                            B1.BackColor = Color.Black;
                            break;
                        case 2:
                            B2.BackColor = Color.Black;
                            break;
                        case 3:
                            B3.BackColor = Color.Black;
                            break;
                        case 4:
                            B4.BackColor = Color.Black;
                            break;
                        case 5:
                            B5.BackColor = Color.Black;
                            break;
                        case 6:
                            B6.BackColor = Color.Black;
                            break;
                        case 7:
                            B7.BackColor = Color.Black;
                            break;
                        case 8:
                            B8.BackColor = Color.Black;
                            break;
                        case 9:
                            B9.BackColor = Color.Black;
                            break;
                        case 10:
                            B10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "C":
                    switch (PB_H)
                    {
                        case 1:
                            C1.BackColor = Color.Black;
                            break;
                        case 2:
                            C2.BackColor = Color.Black;
                            break;
                        case 3:
                            C3.BackColor = Color.Black;
                            break;
                        case 4:
                            C4.BackColor = Color.Black;
                            break;
                        case 5:
                            C5.BackColor = Color.Black;
                            break;
                        case 6:
                            C6.BackColor = Color.Black;
                            break;
                        case 7:
                            C7.BackColor = Color.Black;
                            break;
                        case 8:
                            C8.BackColor = Color.Black;
                            break;
                        case 9:
                            C9.BackColor = Color.Black;
                            break;
                        case 10:
                            C10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "D":
                    switch (PB_H)
                    {
                        case 1:
                            D1.BackColor = Color.Black;
                            break;
                        case 2:
                            D2.BackColor = Color.Black;
                            break;
                        case 3:
                            D3.BackColor = Color.Black;
                            break;
                        case 4:
                            D4.BackColor = Color.Black;
                            break;
                        case 5:
                            D5.BackColor = Color.Black;
                            break;
                        case 6:
                            D6.BackColor = Color.Black;
                            break;
                        case 7:
                            D7.BackColor = Color.Black;
                            break;
                        case 8:
                            D8.BackColor = Color.Black;
                            break;
                        case 9:
                            D9.BackColor = Color.Black;
                            break;
                        case 10:
                            D10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "E":
                    switch (PB_H)
                    {
                        case 1:
                            E1.BackColor = Color.Black;
                            break;
                        case 2:
                            E2.BackColor = Color.Black;
                            break;
                        case 3:
                            E3.BackColor = Color.Black;
                            break;
                        case 4:
                            E4.BackColor = Color.Black;
                            break;
                        case 5:
                            E5.BackColor = Color.Black;
                            break;
                        case 6:
                            E6.BackColor = Color.Black;
                            break;
                        case 7:
                            E7.BackColor = Color.Black;
                            break;
                        case 8:
                            E8.BackColor = Color.Black;
                            break;
                        case 9:
                            E9.BackColor = Color.Black;
                            break;
                        case 10:
                            E10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "F":
                    switch (PB_H)
                    {
                        case 1:
                            F1.BackColor = Color.Black;
                            break;
                        case 2:
                            F2.BackColor = Color.Black;
                            break;
                        case 3:
                            F3.BackColor = Color.Black;
                            break;
                        case 4:
                            F4.BackColor = Color.Black;
                            break;
                        case 5:
                            F5.BackColor = Color.Black;
                            break;
                        case 6:
                            F6.BackColor = Color.Black;
                            break;
                        case 7:
                            F7.BackColor = Color.Black;
                            break;
                        case 8:
                            F8.BackColor = Color.Black;
                            break;
                        case 9:
                            F9.BackColor = Color.Black;
                            break;
                        case 10:
                            F10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "G":
                    switch (PB_H)
                    {
                        case 1:
                            G1.BackColor = Color.Black;
                            break;
                        case 2:
                            G2.BackColor = Color.Black;
                            break;
                        case 3:
                            G3.BackColor = Color.Black;
                            break;
                        case 4:
                            G4.BackColor = Color.Black;
                            break;
                        case 5:
                            G5.BackColor = Color.Black;
                            break;
                        case 6:
                            G6.BackColor = Color.Black;
                            break;
                        case 7:
                            G7.BackColor = Color.Black;
                            break;
                        case 8:
                            G8.BackColor = Color.Black;
                            break;
                        case 9:
                            G9.BackColor = Color.Black;
                            break;
                        case 10:
                            G10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "H":
                    switch (PB_H)
                    {
                        case 1:
                            H1.BackColor = Color.Black;
                            break;
                        case 2:
                            H2.BackColor = Color.Black;
                            break;
                        case 3:
                            H3.BackColor = Color.Black;
                            break;
                        case 4:
                            H4.BackColor = Color.Black;
                            break;
                        case 5:
                            H5.BackColor = Color.Black;
                            break;
                        case 6:
                            H6.BackColor = Color.Black;
                            break;
                        case 7:
                            H7.BackColor = Color.Black;
                            break;
                        case 8:
                            H8.BackColor = Color.Black;
                            break;
                        case 9:
                            H9.BackColor = Color.Black;
                            break;
                        case 10:
                            H10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "I":
                    switch (PB_H)
                    {
                        case 1:
                            I1.BackColor = Color.Black;
                            break;
                        case 2:
                            I2.BackColor = Color.Black;
                            break;
                        case 3:
                            I3.BackColor = Color.Black;
                            break;
                        case 4:
                            I4.BackColor = Color.Black;
                            break;
                        case 5:
                            I5.BackColor = Color.Black;
                            break;
                        case 6:
                            I6.BackColor = Color.Black;
                            break;
                        case 7:
                            I7.BackColor = Color.Black;
                            break;
                        case 8:
                            I8.BackColor = Color.Black;
                            break;
                        case 9:
                            I9.BackColor = Color.Black;
                            break;
                        case 10:
                            I10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                case "J":
                    switch (PB_H)
                    {
                        case 1:
                            J1.BackColor = Color.Black;
                            break;
                        case 2:
                            J2.BackColor = Color.Black;
                            break;
                        case 3:
                            J3.BackColor = Color.Black;
                            break;
                        case 4:
                            J4.BackColor = Color.Black;
                            break;
                        case 5:
                            J5.BackColor = Color.Black;
                            break;
                        case 6:
                            J6.BackColor = Color.Black;
                            break;
                        case 7:
                            J7.BackColor = Color.Black;
                            break;
                        case 8:
                            J8.BackColor = Color.Black;
                            break;
                        case 9:
                            J9.BackColor = Color.Black;
                            break;
                        case 10:
                            J10.BackColor = Color.Black;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

        }

        private void buttonExit_Game(object sender, EventArgs e)
        {
            Close();
        }
    }
}
