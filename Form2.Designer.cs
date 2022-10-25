namespace LibraryTrainingApp2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lsbBookReplace = new System.Windows.Forms.ListBox();
            this.lsbUserOrder = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnStartBookReplace = new System.Windows.Forms.Button();
            this.btnSubmitBookReplace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbBookReplace
            // 
            this.lsbBookReplace.FormattingEnabled = true;
            this.lsbBookReplace.ItemHeight = 15;
            this.lsbBookReplace.Location = new System.Drawing.Point(60, 122);
            this.lsbBookReplace.Name = "lsbBookReplace";
            this.lsbBookReplace.Size = new System.Drawing.Size(245, 319);
            this.lsbBookReplace.TabIndex = 0;
            // 
            // lsbUserOrder
            // 
            this.lsbUserOrder.FormattingEnabled = true;
            this.lsbUserOrder.ItemHeight = 15;
            this.lsbUserOrder.Location = new System.Drawing.Point(504, 124);
            this.lsbUserOrder.Name = "lsbUserOrder";
            this.lsbUserOrder.Size = new System.Drawing.Size(252, 319);
            this.lsbUserOrder.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnStartBookReplace
            // 
            this.btnStartBookReplace.Location = new System.Drawing.Point(139, 472);
            this.btnStartBookReplace.Name = "btnStartBookReplace";
            this.btnStartBookReplace.Size = new System.Drawing.Size(75, 23);
            this.btnStartBookReplace.TabIndex = 3;
            this.btnStartBookReplace.Text = "START";
            this.btnStartBookReplace.UseVisualStyleBackColor = true;
            this.btnStartBookReplace.Click += new System.EventHandler(this.btnStartBookReplace_Click);
            // 
            // btnSubmitBookReplace
            // 
            this.btnSubmitBookReplace.Location = new System.Drawing.Point(595, 472);
            this.btnSubmitBookReplace.Name = "btnSubmitBookReplace";
            this.btnSubmitBookReplace.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitBookReplace.TabIndex = 4;
            this.btnSubmitBookReplace.Text = "SUBMIT";
            this.btnSubmitBookReplace.UseVisualStyleBackColor = true;
            this.btnSubmitBookReplace.Click += new System.EventHandler(this.btnSubmitBookReplace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 75);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Call Numbers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Your Ascending Order";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmitBookReplace);
            this.Controls.Add(this.btnStartBookReplace);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lsbUserOrder);
            this.Controls.Add(this.lsbBookReplace);
            this.Name = "Form2";
            this.Text = "Replacing Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lsbBookReplace;
        private ListBox lsbUserOrder;
        private Button btnAdd;
        private Button btnStartBookReplace;
        private Button btnSubmitBookReplace;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}