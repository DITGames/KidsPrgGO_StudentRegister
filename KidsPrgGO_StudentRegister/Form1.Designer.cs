namespace KidsPrgGO_StudentRegister
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
            txtName = new TextBox();
            cmbGrade = new TextBox();
            txtTel = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(56, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 0;
            // 
            // cmbGrade
            // 
            cmbGrade.Location = new Point(56, 111);
            cmbGrade.Name = "cmbGrade";
            cmbGrade.Size = new Size(166, 23);
            cmbGrade.TabIndex = 1;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(56, 140);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(166, 23);
            txtTel.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(94, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 33);
            btnSave.TabIndex = 3;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 577);
            Controls.Add(btnSave);
            Controls.Add(txtTel);
            Controls.Add(cmbGrade);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox cmbGrade;
        private TextBox txtTel;
        private Button btnSave;
    }
}
