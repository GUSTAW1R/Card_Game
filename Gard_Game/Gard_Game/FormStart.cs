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
    public partial class FormStart : Form
    {
        FormPlay form1;
        FormStart formS;
        public FormStart()
        {
            InitializeComponent();
        }
        private void buttonStart_Game(object sender, EventArgs e)
        {
            form1 = new FormPlay();
            formS = new FormStart();
            form1.Show();
        }
        private void buttonExit_Game(object sender, EventArgs e)
        {
            Close();
        }
    }
}
