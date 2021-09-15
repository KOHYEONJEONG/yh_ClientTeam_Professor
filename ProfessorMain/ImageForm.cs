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
        //private String img_name; //선택된 이미지 이름
        //private String img_time; //시간
        private String Sstime = DateTime.Now.ToString("g");

        public ImageForm()
        {
            InitializeComponent();
        }

        public ImageForm(string name, String time)
        {
            InitializeComponent();
            //img_name = name; //선택된 이미지 이름 받아옴
            //img_time = time; // 시간
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            /*
            if (img_name != "" && img_name != null)
            {
                // 학생이름(학번)
                this.Text = img_name + "의 스크린샷";
                label2.Text = img_time;
                Image img = Properties.Resources.sky3;
                pictureBox1.Image = img;
            }
            */
            // 학생이름(학번)
            this.Text = "스크린샷";
            label2.Text = Sstime;
            Image img = Properties.Resources.sky3;
            pictureBox1.Image = img;
        }
    }
}
