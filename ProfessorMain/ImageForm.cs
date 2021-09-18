using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfessorMain
{
    public partial class ImageForm : Form
    {
        //학생 정보
        private String stdName;
        private String stdNum;

        private String Sstime = DateTime.Now.ToString("g");

        public ImageForm()
        {
            InitializeComponent();
        }

        public ImageForm(string name, String time)
        {
            InitializeComponent();

            //학생 정보 받아옴
            stdName = "고구마";
            stdNum = "20210915";
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            this.Text = "스크린샷";

            lblName.Text += stdName;
            lblNum.Text += stdNum;

            lblTime.Text += Sstime;
            Image img = Properties.Resources.sky3;
            pbScreenshot.Image = img;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //폼 닫기
            this.Close();
        }
    }
}
