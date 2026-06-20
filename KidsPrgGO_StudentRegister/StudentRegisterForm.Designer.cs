namespace KidsPrgGO_StudentRegister
{
    partial class StudentRegisterForm
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
            RegisterButton = new Button();
            LastNameTextBox = new TextBox();
            GeneralInformation = new GroupBox();
            ClassTimeComboBox = new ComboBox();
            ClassDayComboBox = new ComboBox();
            CourseComboBox = new ComboBox();
            SchoolComboBox = new ComboBox();
            BrotherCheckBox = new CheckBox();
            SexComboBox = new ComboBox();
            FirstRubyTextBox = new TextBox();
            LastRubyTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            PaymentInformation = new GroupBox();
            PaymentMethodComboBox = new ComboBox();
            SubsidyCardCheckBox = new CheckBox();
            TicketCheckBox = new CheckBox();
            MembershipFeeCourceComboBox = new ComboBox();
            GeneralInformation.SuspendLayout();
            PaymentInformation.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(467, 305);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(141, 33);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "登録";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += btnSave_Click;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(6, 22);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.PlaceholderText = "姓（漢字）";
            LastNameTextBox.Size = new Size(147, 23);
            LastNameTextBox.TabIndex = 4;
            // 
            // GeneralInformation
            // 
            GeneralInformation.Controls.Add(ClassTimeComboBox);
            GeneralInformation.Controls.Add(ClassDayComboBox);
            GeneralInformation.Controls.Add(CourseComboBox);
            GeneralInformation.Controls.Add(SchoolComboBox);
            GeneralInformation.Controls.Add(BrotherCheckBox);
            GeneralInformation.Controls.Add(SexComboBox);
            GeneralInformation.Controls.Add(FirstRubyTextBox);
            GeneralInformation.Controls.Add(LastRubyTextBox);
            GeneralInformation.Controls.Add(FirstNameTextBox);
            GeneralInformation.Controls.Add(LastNameTextBox);
            GeneralInformation.Location = new Point(12, 12);
            GeneralInformation.Name = "GeneralInformation";
            GeneralInformation.Size = new Size(596, 178);
            GeneralInformation.TabIndex = 5;
            GeneralInformation.TabStop = false;
            GeneralInformation.Text = "基本情報";
            // 
            // ClassTimeComboBox
            // 
            ClassTimeComboBox.FormattingEnabled = true;
            ClassTimeComboBox.Items.AddRange(new object[] { "受講コマを選択してください", "10:40~", "12:20~", "14:50~", "16:20~", "17:00~", "18:10~", "18:30~" });
            ClassTimeComboBox.Location = new Point(249, 138);
            ClassTimeComboBox.Name = "ClassTimeComboBox";
            ClassTimeComboBox.Size = new Size(237, 23);
            ClassTimeComboBox.TabIndex = 13;
            // 
            // ClassDayComboBox
            // 
            ClassDayComboBox.FormattingEnabled = true;
            ClassDayComboBox.Items.AddRange(new object[] { "受講曜日を選択してください", "月", "火", "水（休校日）", "木", "金", "土", "日（休校日）" });
            ClassDayComboBox.Location = new Point(6, 138);
            ClassDayComboBox.Name = "ClassDayComboBox";
            ClassDayComboBox.Size = new Size(237, 23);
            ClassDayComboBox.TabIndex = 12;
            // 
            // CourseComboBox
            // 
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Items.AddRange(new object[] { "コースを選択してください", "スタンダード", "Unity", "キンダー" });
            CourseComboBox.Location = new Point(6, 109);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(300, 23);
            CourseComboBox.TabIndex = 11;
            // 
            // SchoolComboBox
            // 
            SchoolComboBox.FormattingEnabled = true;
            SchoolComboBox.Items.AddRange(new object[] { "所属教室を選択してください", "堀江本校", "STEAMCLUB校", "豊中上野西校" });
            SchoolComboBox.Location = new Point(6, 80);
            SchoolComboBox.Name = "SchoolComboBox";
            SchoolComboBox.Size = new Size(300, 23);
            SchoolComboBox.TabIndex = 10;
            // 
            // BrotherCheckBox
            // 
            BrotherCheckBox.AutoSize = true;
            BrotherCheckBox.Location = new Point(312, 26);
            BrotherCheckBox.Name = "BrotherCheckBox";
            BrotherCheckBox.Size = new Size(211, 19);
            BrotherCheckBox.TabIndex = 9;
            BrotherCheckBox.Text = "兄弟在籍（同時入会の場合も含む）";
            BrotherCheckBox.UseVisualStyleBackColor = true;
            // 
            // SexComboBox
            // 
            SexComboBox.FormattingEnabled = true;
            SexComboBox.Items.AddRange(new object[] { "性別を選択してください", "男", "女", "その他" });
            SexComboBox.Location = new Point(312, 51);
            SexComboBox.Name = "SexComboBox";
            SexComboBox.Size = new Size(211, 23);
            SexComboBox.TabIndex = 8;
            // 
            // FirstRubyTextBox
            // 
            FirstRubyTextBox.Location = new Point(159, 51);
            FirstRubyTextBox.Name = "FirstRubyTextBox";
            FirstRubyTextBox.PlaceholderText = "名（フリガナ）";
            FirstRubyTextBox.Size = new Size(147, 23);
            FirstRubyTextBox.TabIndex = 7;
            // 
            // LastRubyTextBox
            // 
            LastRubyTextBox.Location = new Point(6, 51);
            LastRubyTextBox.Name = "LastRubyTextBox";
            LastRubyTextBox.PlaceholderText = "姓（フリガナ）";
            LastRubyTextBox.Size = new Size(147, 23);
            LastRubyTextBox.TabIndex = 6;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(159, 22);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.PlaceholderText = "名（漢字）";
            FirstNameTextBox.Size = new Size(147, 23);
            FirstNameTextBox.TabIndex = 5;
            // 
            // PaymentInformation
            // 
            PaymentInformation.Controls.Add(PaymentMethodComboBox);
            PaymentInformation.Controls.Add(SubsidyCardCheckBox);
            PaymentInformation.Controls.Add(TicketCheckBox);
            PaymentInformation.Controls.Add(MembershipFeeCourceComboBox);
            PaymentInformation.Location = new Point(12, 196);
            PaymentInformation.Name = "PaymentInformation";
            PaymentInformation.Size = new Size(596, 103);
            PaymentInformation.TabIndex = 6;
            PaymentInformation.TabStop = false;
            PaymentInformation.Text = "決済";
            // 
            // PaymentMethodComboBox
            // 
            PaymentMethodComboBox.FormattingEnabled = true;
            PaymentMethodComboBox.Items.AddRange(new object[] { "決済方法を選択してください", "クレジットカード", "現金", "口座振替" });
            PaymentMethodComboBox.Location = new Point(6, 51);
            PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            PaymentMethodComboBox.Size = new Size(237, 23);
            PaymentMethodComboBox.TabIndex = 15;
            // 
            // SubsidyCardCheckBox
            // 
            SubsidyCardCheckBox.AutoSize = true;
            SubsidyCardCheckBox.Location = new Point(84, 80);
            SubsidyCardCheckBox.Name = "SubsidyCardCheckBox";
            SubsidyCardCheckBox.Size = new Size(159, 19);
            SubsidyCardCheckBox.TabIndex = 14;
            SubsidyCardCheckBox.Text = "大阪市塾代助成カード使用";
            SubsidyCardCheckBox.UseVisualStyleBackColor = true;
            // 
            // TicketCheckBox
            // 
            TicketCheckBox.AutoSize = true;
            TicketCheckBox.Location = new Point(6, 80);
            TicketCheckBox.Name = "TicketCheckBox";
            TicketCheckBox.Size = new Size(72, 19);
            TicketCheckBox.TabIndex = 13;
            TicketCheckBox.Text = "チケット制";
            TicketCheckBox.UseVisualStyleBackColor = true;
            // 
            // MembershipFeeCourceComboBox
            // 
            MembershipFeeCourceComboBox.FormattingEnabled = true;
            MembershipFeeCourceComboBox.Items.AddRange(new object[] { "会費コースを選択してください", "スタンダード", "キンダー", "Unity", "特殊枠", "スタンダード（月2回）", "スタンダード（週2回）" });
            MembershipFeeCourceComboBox.Location = new Point(6, 22);
            MembershipFeeCourceComboBox.Name = "MembershipFeeCourceComboBox";
            MembershipFeeCourceComboBox.Size = new Size(584, 23);
            MembershipFeeCourceComboBox.TabIndex = 12;
            // 
            // StudentRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 345);
            Controls.Add(PaymentInformation);
            Controls.Add(GeneralInformation);
            Controls.Add(RegisterButton);
            Name = "StudentRegisterForm";
            Text = "新規生徒登録";
            Load += StudentRegisterForm_Load;
            GeneralInformation.ResumeLayout(false);
            GeneralInformation.PerformLayout();
            PaymentInformation.ResumeLayout(false);
            PaymentInformation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button RegisterButton;
        private TextBox LastNameTextBox;
        private GroupBox GeneralInformation;
        private TextBox FirstNameTextBox;
        private TextBox FirstRubyTextBox;
        private TextBox LastRubyTextBox;
        private ComboBox SexComboBox;
        private CheckBox BrotherCheckBox;
        private ComboBox SchoolComboBox;
        private ComboBox CourseComboBox;
        private GroupBox PaymentInformation;
        private ComboBox MembershipFeeCourceComboBox;
        private ComboBox PaymentMethodComboBox;
        private CheckBox SubsidyCardCheckBox;
        private CheckBox TicketCheckBox;
        private ComboBox ClassDayComboBox;
        private ComboBox ClassTimeComboBox;
    }
}
