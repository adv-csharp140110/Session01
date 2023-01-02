namespace App01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.listBoxCity = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCalcDiv = new System.Windows.Forms.Button();
            this.buttonCalcMul = new System.Windows.Forms.Button();
            this.buttonCalcSub = new System.Windows.Forms.Button();
            this.buttonCalcAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(194, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(56, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // listBoxCity
            // 
            this.listBoxCity.FormattingEnabled = true;
            this.listBoxCity.ItemHeight = 15;
            this.listBoxCity.Location = new System.Drawing.Point(56, 46);
            this.listBoxCity.Name = "listBoxCity";
            this.listBoxCity.Size = new System.Drawing.Size(213, 289);
            this.listBoxCity.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBoxResult);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.buttonCalcDiv);
            this.panel1.Controls.Add(this.buttonCalcMul);
            this.panel1.Controls.Add(this.buttonCalcSub);
            this.panel1.Controls.Add(this.buttonCalcAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(466, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 373);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(67, 114);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(186, 23);
            this.textBoxResult.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result";
            // 
            // buttonCalcDiv
            // 
            this.buttonCalcDiv.Location = new System.Drawing.Point(211, 80);
            this.buttonCalcDiv.Name = "buttonCalcDiv";
            this.buttonCalcDiv.Size = new System.Drawing.Size(42, 28);
            this.buttonCalcDiv.TabIndex = 8;
            this.buttonCalcDiv.Text = "/";
            this.buttonCalcDiv.UseVisualStyleBackColor = true;
            this.buttonCalcDiv.Click += new System.EventHandler(this.buttonCalcDiv_Click);
            // 
            // buttonCalcMul
            // 
            this.buttonCalcMul.Location = new System.Drawing.Point(163, 80);
            this.buttonCalcMul.Name = "buttonCalcMul";
            this.buttonCalcMul.Size = new System.Drawing.Size(42, 28);
            this.buttonCalcMul.TabIndex = 7;
            this.buttonCalcMul.Text = "*";
            this.buttonCalcMul.UseVisualStyleBackColor = true;
            this.buttonCalcMul.Click += new System.EventHandler(this.buttonCalcMul_Click);
            // 
            // buttonCalcSub
            // 
            this.buttonCalcSub.Location = new System.Drawing.Point(115, 80);
            this.buttonCalcSub.Name = "buttonCalcSub";
            this.buttonCalcSub.Size = new System.Drawing.Size(42, 28);
            this.buttonCalcSub.TabIndex = 6;
            this.buttonCalcSub.Text = "-";
            this.buttonCalcSub.UseVisualStyleBackColor = true;
            this.buttonCalcSub.Click += new System.EventHandler(this.buttonCalcSub_Click);
            // 
            // buttonCalcAdd
            // 
            this.buttonCalcAdd.Location = new System.Drawing.Point(67, 80);
            this.buttonCalcAdd.Name = "buttonCalcAdd";
            this.buttonCalcAdd.Size = new System.Drawing.Size(42, 28);
            this.buttonCalcAdd.TabIndex = 5;
            this.buttonCalcAdd.Text = "+";
            this.buttonCalcAdd.UseVisualStyleBackColor = true;
            this.buttonCalcAdd.Click += new System.EventHandler(this.buttonCalcAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(22, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = " ";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(67, 51);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(186, 23);
            this.textBoxB.TabIndex = 3;
            this.textBoxB.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = " ";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(67, 22);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(186, 23);
            this.textBoxA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(22, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxCity);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private Label label1;
        private TextBox textBoxName;
        private ListBox listBoxCity;
        private Panel panel1;
        private TextBox textBoxB;
        private Label label3;
        private TextBox textBoxA;
        private Label label2;
        private TextBox textBoxResult;
        private Label label5;
        private Button buttonCalcDiv;
        private Button buttonCalcMul;
        private Button buttonCalcSub;
        private Button buttonCalcAdd;
        private Label label4;
        private Button button1;
    }
}