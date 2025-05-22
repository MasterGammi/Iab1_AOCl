using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage; 
        OpenFileDialog openFileDialog = new OpenFileDialog();


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string fileName = openFileDialog.FileName;
                sourceImage = new Image<Bgr, byte>(fileName);
                imageBox1.Image = sourceImage.Resize(640, 480, Inter.Linear);

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> grayImage = sourceImage.Convert<Gray, byte>();
            for (int x = 0; x < sourceImage.Width; x++) 
            {
                for (int y = 0; y < sourceImage.Height; y++) // обход по пискелям
                    grayImage.Data[y, x, 0] = Convert.ToByte(0.299 * sourceImage.Data[y, x, 2] + 0.587 *
                    sourceImage.Data[y, x, 1] + 0.114 * sourceImage.Data[y, x, 0]);

            }

            imageBox2.Image = grayImage.Resize(640, 480, Inter.Linear);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double cannyThreshold = trackBar1.Value;
            double cannyThresholdLinking = 40.0;
            Image<Gray, byte> cannyEdges = sourceImage.Canny(cannyThreshold, cannyThresholdLinking);
            imageBox2.Image = cannyEdges.Resize(640, 480, Inter.Linear);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var channel = sourceImage.Split()[0];
          
            Image<Bgr, byte> destImage = sourceImage.CopyBlank();

            VectorOfMat vm = new VectorOfMat();
            vm.Push(channel); 
            vm.Push(channel.CopyBlank());
            vm.Push(channel.CopyBlank());
            CvInvoke.Merge(vm, destImage);
            imageBox2.Image = destImage.Resize(640, 480, Inter.Linear);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var channel = sourceImage.Split()[2];

            Image<Bgr, byte> destImage = sourceImage.CopyBlank();

            VectorOfMat vm = new VectorOfMat();
           
            vm.Push(channel.CopyBlank());
            vm.Push(channel.CopyBlank());
            vm.Push(channel);
            CvInvoke.Merge(vm, destImage);
            imageBox2.Image = destImage.Resize(640, 480, Inter.Linear);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var channel = sourceImage.Split()[1];

            Image<Bgr, byte> destImage = sourceImage.CopyBlank();

            VectorOfMat vm = new VectorOfMat();

            vm.Push(channel.CopyBlank());
            vm.Push(channel);
            vm.Push(channel.CopyBlank());
            CvInvoke.Merge(vm, destImage);
            imageBox2.Image = destImage.Resize(640, 480, Inter.Linear);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Image<Bgr, byte> destImage = sourceImage.Copy();
           

            for (int y = 0; y < destImage.Height; y++)
                for (int x = 0; x < destImage.Width; x++)
                {
                    destImage.Data[y, x, 0] = (Byte)(destImage.Data[y, x, 2] * 0.1 + destImage.Data[y, x, 1] * 0.534 + destImage.Data[y, x, 0] * 0.131) ;
                    destImage.Data[y, x, 1] = (Byte)(destImage.Data[y, x, 2] * 0.1 + destImage.Data[y, x, 1] * 0.686 + destImage.Data[y, x, 0] * 0.168);
                    destImage.Data[y, x, 2] = (Byte)(destImage.Data[y, x, 2] * 0.1 + destImage.Data[y, x, 1] * 0.769 + destImage.Data[y, x, 0] * 0.189);
                }

            imageBox2.Image = destImage.Resize(640, 480, Inter.Linear);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var contrastImage = sourceImage.Copy();
            double c = 1;

            for(int y= 0; y<contrastImage.Height; y++)
                for(int x= 0; x<contrastImage.Width; x++)
                {
                    contrastImage.Data[y, x, 0] = (Byte)(contrastImage.Data[y, x, 0] * c);
                    contrastImage.Data[y, x, 1] = (Byte)(contrastImage.Data[y, x, 1] * c);
                    contrastImage.Data[y, x, 2] = (Byte)(contrastImage.Data[y, x, 2] * c);
                }
            imageBox2.Image = contrastImage.Resize(640, 480, Inter.Linear);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            var contrastImage = sourceImage.Copy();
            double c = trackBar2.Value;

            for (int y = 0; y < contrastImage.Height; y++)
                for (int x = 0; x < contrastImage.Width; x++)
                {
                    contrastImage.Data[y, x, 0] = (Byte)(contrastImage.Data[y, x, 0] * c);
                    contrastImage.Data[y, x, 1] = (Byte)(contrastImage.Data[y, x, 1] * c);
                    contrastImage.Data[y, x, 2] = (Byte)(contrastImage.Data[y, x, 2] * c);
                }
            imageBox2.Image = contrastImage.Resize(640, 480, Inter.Linear);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var contrastImage = sourceImage.Copy();
            int c = 0;

            for (int y = 0; y < contrastImage.Height; y++)
                for (int x = 0; x < contrastImage.Width; x++)
                {
                    contrastImage.Data[y, x, 0] = (Byte)(contrastImage.Data[y, x, 0] + c);
                    contrastImage.Data[y, x, 1] = (Byte)(contrastImage.Data[y, x, 1] + c);
                    contrastImage.Data[y, x, 2] = (Byte)(contrastImage.Data[y, x, 2] + c);
                }
            imageBox2.Image = contrastImage.Resize(640, 480, Inter.Linear);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            var contrastImage = sourceImage.Copy();
            int c = trackBar3.Value;

            for (int y = 0; y < contrastImage.Height; y++)
                for (int x = 0; x < contrastImage.Width; x++)
                {
                    contrastImage.Data[y, x, 0] = (Byte)(contrastImage.Data[y, x, 0] + c);
                    contrastImage.Data[y, x, 1] = (Byte)(contrastImage.Data[y, x, 1] + c);
                    contrastImage.Data[y, x, 2] = (Byte)(contrastImage.Data[y, x, 2] + c);
                }
            imageBox2.Image = contrastImage.Resize(640, 480, Inter.Linear);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var addImage = sourceImage.Copy();
            

            for (int y = 0; y < addImage.Height; y++)
                for (int x = 0; x < addImage.Width; x++)
                {
                    addImage.Data[y, x, 0] = (Byte)(addImage.Data[y, x, 0] + addImage.Data[y, x, 0]);
                    addImage.Data[y, x, 1] = (Byte)(addImage.Data[y, x, 1] + addImage.Data[y, x, 0]);
                    addImage.Data[y, x, 2] = (Byte)(addImage.Data[y, x, 2] + addImage.Data[y, x, 0]);
                }
            imageBox2.Image = addImage.Resize(640, 480, Inter.Linear);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var addImage = sourceImage.Copy();


            for (int y = 0; y < addImage.Height; y++)
                for (int x = 0; x < addImage.Width; x++)
                {
                    addImage.Data[y, x, 0] = (Byte)(addImage.Data[y, x, 0] + addImage.Data[y, x, 1]);
                    addImage.Data[y, x, 1] = (Byte)(addImage.Data[y, x, 1] + addImage.Data[y, x, 1]);
                    addImage.Data[y, x, 2] = (Byte)(addImage.Data[y, x, 2] + addImage.Data[y, x, 1]);
                }
            imageBox2.Image = addImage.Resize(640, 480, Inter.Linear);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var addImage = sourceImage.Copy();


            for (int y = 0; y < addImage.Height; y++)
                for (int x = 0; x < addImage.Width; x++)
                {
                    addImage.Data[y, x, 0] = (Byte)(addImage.Data[y, x, 0] + addImage.Data[y, x, 2]);
                    addImage.Data[y, x, 1] = (Byte)(addImage.Data[y, x, 1] + addImage.Data[y, x, 2]);
                    addImage.Data[y, x, 2] = (Byte)(addImage.Data[y, x, 2] + addImage.Data[y, x, 2]);
                }
            imageBox2.Image = addImage.Resize(640, 480, Inter.Linear);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var addImage = sourceImage.Copy();

            for (int y = 0; y < addImage.Height; y++)
                for (int x = 0; x < addImage.Width; x++)
                {
                    addImage.Data[y, x, 0] = (Byte)(addImage.Data[y, x, 0] - addImage.Data[y, x, 0]);
                    addImage.Data[y, x, 1] = (Byte)(addImage.Data[y, x, 1] - addImage.Data[y, x, 0]);
                    addImage.Data[y, x, 2] = (Byte)(addImage.Data[y, x, 2] - addImage.Data[y, x, 0]);
                }
            imageBox2.Image = addImage.Resize(640, 480, Inter.Linear);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            
            var addImage = sourceImage.Copy();

            for (int y = 0; y < addImage.Height; y++)
                for (int x = 0; x < addImage.Width; x++)
                {
                    addImage.Data[y, x, 0] = (Byte)(addImage.Data[y, x, 0] - addImage.Data[y, x, 1]);
                    addImage.Data[y, x, 1] = (Byte)(addImage.Data[y, x, 1] - addImage.Data[y, x, 1]);
                    addImage.Data[y, x, 2] = (Byte)(addImage.Data[y, x, 2] - addImage.Data[y, x, 1]);
                }
            imageBox2.Image = addImage.Resize(640, 480, Inter.Linear);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var addImage = sourceImage.Copy();


            for (int y = 0; y < addImage.Height; y++)
                for (int x = 0; x < addImage.Width; x++)
                {
                    addImage.Data[y, x, 0] = (Byte)(addImage.Data[y, x, 0] - addImage.Data[y, x, 2]);
                    addImage.Data[y, x, 1] = (Byte)(addImage.Data[y, x, 1] - addImage.Data[y, x, 2]);
                    addImage.Data[y, x, 2] = (Byte)(addImage.Data[y, x, 2] - addImage.Data[y, x, 2]);
                }
            imageBox2.Image = addImage.Resize(640, 480, Inter.Linear);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var hsvImage = sourceImage.Convert<Hsv, byte>();
            imageBox2.Image = hsvImage.Resize(640, 480, Inter.Linear);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var image = sourceImage;
            var result = sourceImage.CopyBlank();

            List<byte> list1 = new List<byte>();
            List<byte> list2 = new List<byte>();
            List<byte> list3 = new List<byte>();
            int sh = 4;
            int N = 3;
            for (int y = sh; y < image.Height-sh; y++)
                for(int x = sh; x < image.Width-sh; x++)
                {
                    list1.Clear();
                    list2.Clear();
                    list3.Clear();

                    for (int  i = -1; i < 2; i++)
                        for (int j = -1; j < 2; j++)
                        {
                            list1.Add(image.Data[i+y, j+x, 0]);
                            list2.Add(image.Data[i + y, j + x, 1]);
                            list3.Add(image.Data[i + y, j + x, 2]);
                        }
                    list1.Sort();
                    list2.Sort();
                    list3.Sort();

                    result.Data[y, x, 0] = list1[N / 2];
                    result.Data[y, x, 1] = list2[N / 2];
                    result.Data[y, x, 2] = list3[N / 2];
                }
            imageBox2.Image = result.Resize(640, 480, Inter.Linear);
        }

        

        
    }
}
