namespace LibraryTrainingApp2
{
    partial class Form4
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
            this.lsbDewey = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSub3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lsbDewey
            // 
            this.lsbDewey.FormattingEnabled = true;
            this.lsbDewey.ItemHeight = 15;
            this.lsbDewey.Location = new System.Drawing.Point(211, 34);
            this.lsbDewey.Name = "lsbDewey";
            this.lsbDewey.Size = new System.Drawing.Size(345, 349);
            this.lsbDewey.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(40, 320);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 58);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSub1
            // 
            this.btnSub1.Location = new System.Drawing.Point(40, 206);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(112, 23);
            this.btnSub1.TabIndex = 2;
            this.btnSub1.Text = "Submit Level 1";
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Location = new System.Drawing.Point(40, 235);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(112, 23);
            this.btnSub2.TabIndex = 3;
            this.btnSub2.Text = "Submit Level 2";
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnSub3
            // 
            this.btnSub3.Location = new System.Drawing.Point(40, 264);
            this.btnSub3.Name = "btnSub3";
            this.btnSub3.Size = new System.Drawing.Size(112, 23);
            this.btnSub3.TabIndex = 4;
            this.btnSub3.Text = "Submit Level 3";
            this.btnSub3.UseVisualStyleBackColor = true;
            this.btnSub3.Click += new System.EventHandler(this.btnSub3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 30);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(22, 235);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 24);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(22, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 28);
            this.panel3.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 413);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSub3);
            this.Controls.Add(this.btnSub2);
            this.Controls.Add(this.btnSub1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lsbDewey);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lsbDewey;
        private Button btnStart;
        private Button btnSub1;
        private Button btnSub2;
        private Button btnSub3;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}