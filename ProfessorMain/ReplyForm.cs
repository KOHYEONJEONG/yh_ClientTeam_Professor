using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Reply
{
    public partial class ReplyForm : Form
    {
        public ReplyForm()
        {
            InitializeComponent();
        }

        private void ReplyForm_Load(object sender, EventArgs e)
        {
            label1.Text += "고구마";
            label2.Text += "20210903";

            textBox1.Text = "The US Federal Aviation Administration has grounded Virgin Galactic flights as it investigates how Sir Richard Branson's recent space flight drifted off course during its climb skyward.The US Federal Aviation Administration has grounded Virgin Galactic flights as it investigates how Sir Richard Branson's recent space flight drifted off course during its climb skyward.The US Federal Aviation Administration has grounded Virgin Galactic flights as it investigates how Sir Richard Branson's recent space flight drifted off course during its climb";

            //radioButton1.Checked = true;

        }
    }
}
