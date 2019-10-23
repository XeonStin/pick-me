using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace pick_me
{
	public partial class Form1 : Form
	{
		const int MaxN = 1000;
		string[] name = new string[MaxN];
		int tot, buttonMode = 0, buttonWidth, buttonHeight;
		string[] defaultButtonText = new string[2];

		public Form1()
		{
			defaultButtonText[0] = "手气不错！";
			defaultButtonText[1] = "手劲不错！\n\n（请爱惜设备";
			InitializeComponent();
			buttonWidth = button.Width;
			buttonHeight = button.Height;
        }

		void Read()
		{
			StreamReader sr = new StreamReader("list.txt", Encoding.Default);
			int i;
			for (i = 1; (name[i] = sr.ReadLine()) != null; ++i) ;
			tot = i - 1;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Read();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			button.Enabled = label2.Enabled = false;
			Application.DoEvents();
			const double randTime = 5000;
			Random ran = new Random();
			int tgt = ran.Next(1, tot+1), step = ran.Next(4, 5) * tot + tgt - 1, cur = 1;
			double k = Math.Sqrt(2 * randTime) / step;

			progressBar1.Location = button.Location;
			progressBar1.Size = button.Size;
			progressBar1.Visible = true;
			progressBar1.Minimum = 0;
			progressBar1.Maximum = step;
			for (int i = 1; i <= step; ++i)
			{
				progressBar1.Value = i;
				cur = (cur % tot) + 1;
				box.Text = name[cur];
				Application.DoEvents();
				Thread.Sleep((int)(k*i));
			}
			progressBar1.Visible = false;
			button.Text = defaultButtonText[buttonMode];
			button.Enabled = label2.Enabled = true;
		}

		private void label2_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
			{
				return;
			}

			Random ran = new Random();
			int[] cnt = new int[MaxN];
			for (int i = 1; i <= 10000000; ++i)
			{
				int tmp = ran.Next(1, tot + 1);
				++cnt[tmp];
			}
			FileStream fs = new FileStream("test.txt", FileMode.Create);
			StreamWriter sw = new StreamWriter(fs);
			for (int i = 1; i <= tot; ++i)
			{
				sw.WriteLine(cnt[i]);
			}
			sw.Close();
			fs.Close();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			DialogResult dr;
			dr = MessageBox.Show("Made by Xeon Stin", "Bonjour!", MessageBoxButtons.OK);
		}
		
		private void label2_Click(object sender, EventArgs e)
		{
			if (buttonMode == 0)
			{
				buttonMode = 1;
				button.Width = box.Width;
				button.Height = 100;
				Height = 212 + 70;
				label1.Location = new Point(label1.Location.X, label1.Location.Y + 70);
				label2.Location = new Point(label2.Location.X, label2.Location.Y + 70);
			}
			else
			{
				buttonMode = 0;
				button.Width = buttonWidth;
				button.Height = buttonHeight;
				Height = 212;
				label1.Location = new Point(label1.Location.X, label1.Location.Y - 70);
				label2.Location = new Point(label2.Location.X, label2.Location.Y - 70);
			}
			button.Text = defaultButtonText[buttonMode];
		}
	}
}
