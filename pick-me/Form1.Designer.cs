﻿namespace pick_me
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.box = new System.Windows.Forms.TextBox();
			this.button = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// box
			// 
			this.box.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.box.Location = new System.Drawing.Point(47, 37);
			this.box.Name = "box";
			this.box.ReadOnly = true;
			this.box.Size = new System.Drawing.Size(192, 35);
			this.box.TabIndex = 1;
			this.box.TabStop = false;
			this.box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button
			// 
			this.button.Location = new System.Drawing.Point(47, 99);
			this.button.Name = "button";
			this.button.Size = new System.Drawing.Size(114, 37);
			this.button.TabIndex = 1;
			this.button.Text = "手气不错！";
			this.button.UseVisualStyleBackColor = true;
			this.button.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(270, 159);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(11, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "i";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "！";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(47, 134);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(114, 37);
			this.progressBar1.TabIndex = 4;
			this.progressBar1.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 173);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button);
			this.Controls.Add(this.box);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Pick Me!";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox box;
		private System.Windows.Forms.Button button;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ProgressBar progressBar1;
	}
}

