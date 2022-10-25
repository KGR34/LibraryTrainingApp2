namespace LibraryTrainingApp2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.btnStartIdent = new System.Windows.Forms.Button();
            this.btnSubmitIdent = new System.Windows.Forms.Button();
            this.lsbCol1 = new System.Windows.Forms.ListBox();
            this.lsbCol2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStartIdent
            // 
            this.btnStartIdent.Location = new System.Drawing.Point(48, 357);
            this.btnStartIdent.Name = "btnStartIdent";
            this.btnStartIdent.Size = new System.Drawing.Size(99, 55);
            this.btnStartIdent.TabIndex = 0;
            this.btnStartIdent.Text = "START";
            this.btnStartIdent.UseVisualStyleBackColor = true;
            this.btnStartIdent.Click += new System.EventHandler(this.btnStartIdent_Click);
            // 
            // btnSubmitIdent
            // 
            this.btnSubmitIdent.Location = new System.Drawing.Point(175, 357);
            this.btnSubmitIdent.Name = "btnSubmitIdent";
            this.btnSubmitIdent.Size = new System.Drawing.Size(99, 55);
            this.btnSubmitIdent.TabIndex = 1;
            this.btnSubmitIdent.Text = "SUBMIT";
            this.btnSubmitIdent.UseVisualStyleBackColor = true;
            this.btnSubmitIdent.Click += new System.EventHandler(this.btnSubmitIdent_Click);
            // 
            // lsbCol1
            // 
            this.lsbCol1.FormattingEnabled = true;
            this.lsbCol1.ItemHeight = 15;
            this.lsbCol1.Location = new System.Drawing.Point(319, 48);
            this.lsbCol1.Name = "lsbCol1";
            this.lsbCol1.Size = new System.Drawing.Size(191, 364);
            this.lsbCol1.TabIndex = 2;
            // 
            // lsbCol2
            // 
            this.lsbCol2.FormattingEnabled = true;
            this.lsbCol2.ItemHeight = 15;
            this.lsbCol2.Location = new System.Drawing.Point(528, 48);
            this.lsbCol2.Name = "lsbCol2";
            this.lsbCol2.Size = new System.Drawing.Size(239, 364);
            this.lsbCol2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(272, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 16);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(300, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 14);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(260, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 12);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(225, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 17);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "COLUMN A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "COLUMN B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 150);
            this.label3.TabIndex = 10;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lsbCol2);
            this.Controls.Add(this.lsbCol1);
            this.Controls.Add(this.btnSubmitIdent);
            this.Controls.Add(this.btnStartIdent);
            this.Name = "Form3";
            this.Text = "Identifying Areas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStartIdent;
        private Button btnSubmitIdent;
        private ListBox lsbCol1;
        private ListBox lsbCol2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}