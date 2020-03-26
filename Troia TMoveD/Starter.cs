using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Troia_TMoveD
{
    public partial class StartForm : Form
    {
        #region Definitions

        Business BL = new Business();

        #endregion

        #region Values

        int index = 0;

        #endregion

        #region Form Operations

        public StartForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index<5)
            {
                index++;
            }

            else
            {
                timer1.Stop();
                this.Close();
            }
        }

        #endregion
    }
}
