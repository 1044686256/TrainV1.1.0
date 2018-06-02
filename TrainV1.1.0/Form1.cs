using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.Resources;

namespace TrainV1._1._0
{
    public partial class MainFrm : Form
    {
        static int _iPictureShowCount = 0; //显示图片标志
        public MainFrm()
        {
            InitializeComponent();
            labShowIpAddress.Text = "192.168.10.123\n123.232.114.60\n123.232.114.240\n192.168.10.250\n";
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            initFrm();
        }

        private void initFrm()
        {
            //加载背景图片
            //Image backImage = Image.FromFile(@"D:\Work\SoftWare\C#\TrainV1.1.0\TrainV1.1.0\Images\BlockBackImage.png");
            //ChangeImage _backImage = new ChangeImage();
            //this.BackgroundImage = _backImage.ChangeAlpha(backImage, 100);
            //MotionSoftware.BackgroundImage= _backImage.ChangeAlpha(backImage, 100);

            //添加窗体信息

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 动态更新图片信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerShowPicbox_Tick(object sender, EventArgs e)
        {
            //switch (_iPictureShowCount)
            //{
            //    case 0:
            //        labShowPictures.Image = Pictures._1;
            //        break;
            //    case 1:
            //        labShowPictures.Image = Pictures._2;
            //        break;
            //    case 2:
            //        labShowPictures.Image = Pictures._3;
            //        break;
            //    case 3:
            //        labShowPictures.Image = Pictures._4;
            //        break;
            //    case 4:
            //        labShowPictures.Image = Pictures._5;
            //        break;
            //    case 5:
            //        labShowPictures.Image = Pictures._6;
            //        break;
            //    case 6:
            //        labShowPictures.Image = Pictures._7;
            //        break;
            //    case 7:
            //        labShowPictures.Image = Pictures._1;
            //        break;

            //    default:
            //        break;

            //}
            //_iPictureShowCount++;
            //if (_iPictureShowCount == 6)
            //{
            //    _iPictureShowCount = 0;
            //}
        }

        private void timerUpdateTime_Tick(object sender, EventArgs e)
        {
            labShowTdata.Text= DateTime.Now.ToShortDateString();
            labShowTime.Text = DateTime.Now.ToShortTimeString() +":"+ DateTime.Now.Second.ToString("D2");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Print printFrm = new Print();
            //this.Hide();
            printFrm.Show();
        }
    }
}
