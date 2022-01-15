using AventStack.ExtentReports.Gherkin.Model;
using MongoDB.Bson.Serialization.Serializers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food
{
    public partial class Product : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public Product()
        {
            InitializeComponent();
            random = new Random();

        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ColorModel.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ColorModel.ColorList.Count);
            }
            tempIndex = index;
            string color = ColorModel.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Rockwell", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    paneltitle.BackColor = ColorModel.ChangeColorBrightness(color, -0.2);

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel2.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.splDesktop.Panel2.Controls.Add(childForm);
            this.splDesktop.Panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewFolder1.FormPro(), sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewFolder1.FormPayment(), sender);

        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewFolder1.FormReporting(), sender);

        }

        private void btnsetting_Click(object sender, EventArgs e)
        {

            OpenChildForm(new NewFolder1.FormSetting(), sender);
        }

        private void mobilestore_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
        }
        private void btnp_Click(object sender, EventArgs e)
        {

            OpenChildForm(new NewFolder1.FormPayment(), sender);
        }

        private void label24_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewFolder1.FormReporting(), sender);
        }

        private void btnreport_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new NewFolder1.FormReporting(), sender);
        }

        private void label26_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewFolder1.FormReporting(), sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NewFolder1.FormReporting(), sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frmsettingcs f = new Frmsettingcs();
            f.ShowDialog();
        }

        private void btnVip_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


    }
}
