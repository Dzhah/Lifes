namespace Lifes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BStop = new System.Windows.Forms.Button();
            this.BStart = new System.Windows.Forms.Button();
            this.NUpDwnDensity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NUpDwnResolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDwnDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDwnResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.BStop);
            this.splitContainer1.Panel1.Controls.Add(this.BStart);
            this.splitContainer1.Panel1.Controls.Add(this.NUpDwnDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.NUpDwnResolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1925, 1057);
            this.splitContainer1.SplitterDistance = 282;
            this.splitContainer1.TabIndex = 0;
            // 
            // BStop
            // 
            this.BStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStop.Location = new System.Drawing.Point(32, 338);
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(120, 35);
            this.BStop.TabIndex = 5;
            this.BStop.Text = "STOP";
            this.BStop.UseVisualStyleBackColor = true;
            this.BStop.Click += new System.EventHandler(this.BStop_Click);
            // 
            // BStart
            // 
            this.BStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BStart.Location = new System.Drawing.Point(32, 272);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(120, 35);
            this.BStart.TabIndex = 4;
            this.BStart.Text = "START";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // NUpDwnDensity
            // 
            this.NUpDwnDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUpDwnDensity.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NUpDwnDensity.Location = new System.Drawing.Point(32, 177);
            this.NUpDwnDensity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUpDwnDensity.Name = "NUpDwnDensity";
            this.NUpDwnDensity.Size = new System.Drawing.Size(120, 30);
            this.NUpDwnDensity.TabIndex = 3;
            this.NUpDwnDensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUpDwnDensity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(27, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Density";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NUpDwnResolution
            // 
            this.NUpDwnResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NUpDwnResolution.Location = new System.Drawing.Point(32, 80);
            this.NUpDwnResolution.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NUpDwnResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUpDwnResolution.Name = "NUpDwnResolution";
            this.NUpDwnResolution.Size = new System.Drawing.Size(120, 30);
            this.NUpDwnResolution.TabIndex = 1;
            this.NUpDwnResolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUpDwnResolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1639, 1057);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.TTick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1057);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NUpDwnDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDwnResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.NumericUpDown NUpDwnResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown NUpDwnDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BStop;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Timer timer1;
    }
}

