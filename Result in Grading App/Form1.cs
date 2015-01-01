using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_in_Grading_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            Result aResult = new Result();
            aResult.physics = Convert.ToDouble(physicstextBox.Text);
            aResult.chemistry = Convert.ToDouble(chemistrytextBox.Text);
            aResult.math = Convert.ToDouble(mathtextBox.Text);

            avgtextBox.Text = aResult.Avarage().ToString();

            gradetextBox.Text = aResult.GetGrade();

        }

    }
}
