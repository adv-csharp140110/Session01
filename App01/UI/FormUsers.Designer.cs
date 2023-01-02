namespace App01.UI
{
    partial class FormUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(322, 56);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(209, 23);
            this.textBoxId.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(322, 85);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(209, 23);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(322, 114);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(209, 23);
            this.textBoxLastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(322, 143);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(209, 23);
            this.textBoxEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(322, 172);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(209, 23);
            this.textBoxPhone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(322, 218);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(65, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(393, 218);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(65, 23);
            this.buttonDel.TabIndex = 11;
            this.buttonDel.Text = "Del";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(464, 218);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(65, 23);
            this.buttonNew.TabIndex = 12;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(535, 218);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(65, 23);
            this.buttonNext.TabIndex = 13;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(606, 218);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(65, 23);
            this.buttonLast.TabIndex = 14;
            this.buttonLast.Text = ">>";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(252, 218);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(65, 23);
            this.buttonPrev.TabIndex = 15;
            this.buttonPrev.Text = "<";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(181, 218);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(65, 23);
            this.buttonFirst.TabIndex = 16;
            this.buttonFirst.Text = "<<";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 533);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Name = "FormUsers";
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxId;
        private TextBox textBoxFirstName;
        private Label label2;
        private TextBox textBoxLastName;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label4;
        private TextBox textBoxPhone;
        private Label label5;
        private Button buttonSave;
        private Button buttonDel;
        private Button buttonNew;
        private Button buttonNext;
        private Button buttonLast;
        private Button buttonPrev;
        private Button buttonFirst;
    }
}