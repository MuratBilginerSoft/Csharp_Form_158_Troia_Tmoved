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
    public partial class AdminPanel : Form
    {
        #region Definitions

        Business BL = new Business(); // Business sınıfından bir nesne türettik.

        #endregion

        #region Values

        public static int Status = 0; // Menüde hangi seçeneği seçtiğini global olarak tanımladığım Status değişkeni ile tutuyorum.

        Point Locationx; // Formu taşımak için formun konum değerlerini almak için kullandığımız değişken.

        bool Status2 = false;    // Formu taşımak için üzerine tıklandığında farenin durumunu Status2 de tuttuk.

        #endregion

        #region Methods

        // Herhangi bir method yazma gereği duymadık.

        #endregion

        #region Form Ana İşlemler 

        public AdminPanel()
        {
            InitializeComponent();
        }

        #endregion

        #region Top Banner Button

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Form Kapama Kodu
        }

        private void PicMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Formu minimize etme kodu.
        }

        #endregion

        #region Menü Button

        private void PicGFN_Click(object sender, EventArgs e)
        {
            Status = 1;
            BusinessForm BF = new BusinessForm();
            BL.FormOpen(this, BF);
        }

        private void PicGN_Click(object sender, EventArgs e)
        {
            Status = 2;
            BusinessForm BF = new BusinessForm();
            BL.FormOpen(this, BF);
        }

        private void PicCIE_Click(object sender, EventArgs e)
        {
            Status = 3;
            BusinessForm BF = new BusinessForm();
            BL.FormOpen(this, BF);
        }

        private void PicLIE_Click(object sender, EventArgs e)
        {
            Status = 4;
            BusinessForm BF = new BusinessForm();
            BL.FormOpen(this, BF);
        }

        private void PicCompare_Click(object sender, EventArgs e)
        {
            Status = 5;
            BusinessForm BF = new BusinessForm();
            BL.FormOpen(this, BF);
        }

        private void PicGFLN_Click(object sender, EventArgs e)
        {
            Status = 6;
            BusinessForm BF = new BusinessForm();
            BL.FormOpen(this, BF);
        }

        private void PicGLN_Click(object sender, EventArgs e)
        {
            Status = 7;
            BusinessForm BF = new BusinessForm();
            BL.FormOpen(this, BF);
        }

        #endregion

        #region Form Taşıma

        private void AdminPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Status2 = true;
            this.Cursor = Cursors.SizeAll;
            Locationx = e.Location;
        }

        private void AdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Status2)
            {
                this.Left = e.X + this.Left - (Locationx.X);
                this.Top = e.Y + this.Top - (Locationx.Y);
            }
        }

        private void AdminPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Status2 = false;
            this.Cursor = Cursors.Default;
        }

        #endregion

        #region Change Button Color

        private void PicMinus_MouseHover(object sender, EventArgs e)
        {
            BL.ButtonColor1((PictureBox)sender);
        }

        private void PicMinus_MouseLeave(object sender, EventArgs e)
        {
            BL.ButtonColor2((PictureBox)sender);
        }

        #endregion

        #region Side Operation

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://industryolog.com");
        }

        #endregion
    }
}
