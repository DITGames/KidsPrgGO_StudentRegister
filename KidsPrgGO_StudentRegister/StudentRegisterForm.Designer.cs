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
            MembershipFeeCourseComboBox = new ComboBox();
            JoiningInformation = new GroupBox();
            FirstMonthFeeTextBox = new TextBox();
            ClassStartLabel = new Label();
            ClassStartDateTimePicker = new DateTimePicker();
            RegisterTab = new TabControl();
            AddStudentPage = new TabPage();
            EditStudentPage = new TabPage();
            SearchInformation = new GroupBox();
            SearchFirstNameTextBox = new TextBox();
            SearchLastNameTextBox = new TextBox();
            SearchSchoolComboBox = new ComboBox();
            SearchEditButton = new Button();
            GeneralInformation.SuspendLayout();
            PaymentInformation.SuspendLayout();
            JoiningInformation.SuspendLayout();
            RegisterTab.SuspendLayout();
            AddStudentPage.SuspendLayout();
            EditStudentPage.SuspendLayout();
            SearchInformation.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(461, 383);
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
            GeneralInformation.Location = new Point(6, 6);
            GeneralInformation.Name = "GeneralInformation";
            GeneralInformation.Size = new Size(596, 170);
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
            PaymentInformation.Controls.Add(MembershipFeeCourseComboBox);
            PaymentInformation.Location = new Point(6, 182);
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
            // MembershipFeeCourseComboBox
            // 
            MembershipFeeCourseComboBox.FormattingEnabled = true;
            MembershipFeeCourseComboBox.Items.AddRange(new object[] { "会費コースを選択してください", "スタンダード", "キンダー", "Unity", "特殊枠", "スタンダード（月2回）", "スタンダード（週2回）" });
            MembershipFeeCourseComboBox.Location = new Point(6, 22);
            MembershipFeeCourseComboBox.Name = "MembershipFeeCourseComboBox";
            MembershipFeeCourseComboBox.Size = new Size(584, 23);
            MembershipFeeCourseComboBox.TabIndex = 12;
            // 
            // JoiningInformation
            // 
            JoiningInformation.Controls.Add(FirstMonthFeeTextBox);
            JoiningInformation.Controls.Add(ClassStartLabel);
            JoiningInformation.Controls.Add(ClassStartDateTimePicker);
            JoiningInformation.Location = new Point(6, 291);
            JoiningInformation.Name = "JoiningInformation";
            JoiningInformation.Size = new Size(596, 83);
            JoiningInformation.TabIndex = 7;
            JoiningInformation.TabStop = false;
            JoiningInformation.Text = "入会時情報";
            // 
            // FirstMonthFeeTextBox
            // 
            FirstMonthFeeTextBox.Location = new Point(6, 51);
            FirstMonthFeeTextBox.Name = "FirstMonthFeeTextBox";
            FirstMonthFeeTextBox.PlaceholderText = "初月授業料（税込）";
            FirstMonthFeeTextBox.Size = new Size(273, 23);
            FirstMonthFeeTextBox.TabIndex = 2;
            FirstMonthFeeTextBox.TextChanged += FirstMonthFeeTextBox_TextChanged;
            FirstMonthFeeTextBox.KeyPress += FirstMonthFeeTextBox_KeyPress;
            // 
            // ClassStartLabel
            // 
            ClassStartLabel.AutoSize = true;
            ClassStartLabel.Location = new Point(6, 28);
            ClassStartLabel.Name = "ClassStartLabel";
            ClassStartLabel.Size = new Size(67, 15);
            ClassStartLabel.TabIndex = 1;
            ClassStartLabel.Text = "授業開始日";
            // 
            // ClassStartDateTimePicker
            // 
            ClassStartDateTimePicker.Location = new Point(79, 22);
            ClassStartDateTimePicker.Name = "ClassStartDateTimePicker";
            ClassStartDateTimePicker.Size = new Size(200, 23);
            ClassStartDateTimePicker.TabIndex = 0;
            // 
            // RegisterTab
            // 
            RegisterTab.Controls.Add(AddStudentPage);
            RegisterTab.Controls.Add(EditStudentPage);
            RegisterTab.Location = new Point(12, 12);
            RegisterTab.Name = "RegisterTab";
            RegisterTab.SelectedIndex = 0;
            RegisterTab.Size = new Size(617, 450);
            RegisterTab.TabIndex = 8;
            // 
            // AddStudentPage
            // 
            AddStudentPage.Controls.Add(GeneralInformation);
            AddStudentPage.Controls.Add(RegisterButton);
            AddStudentPage.Controls.Add(JoiningInformation);
            AddStudentPage.Controls.Add(PaymentInformation);
            AddStudentPage.Location = new Point(4, 24);
            AddStudentPage.Name = "AddStudentPage";
            AddStudentPage.Padding = new Padding(3);
            AddStudentPage.Size = new Size(609, 422);
            AddStudentPage.TabIndex = 0;
            AddStudentPage.Text = "新規生徒登録";
            AddStudentPage.UseVisualStyleBackColor = true;
            // 
            // EditStudentPage
            // 
            EditStudentPage.Controls.Add(SearchEditButton);
            EditStudentPage.Controls.Add(SearchInformation);
            EditStudentPage.Location = new Point(4, 24);
            EditStudentPage.Name = "EditStudentPage";
            EditStudentPage.Padding = new Padding(3);
            EditStudentPage.Size = new Size(609, 422);
            EditStudentPage.TabIndex = 1;
            EditStudentPage.Text = "生徒情報編集";
            EditStudentPage.UseVisualStyleBackColor = true;
            // 
            // SearchInformation
            // 
            SearchInformation.Controls.Add(SearchSchoolComboBox);
            SearchInformation.Controls.Add(SearchFirstNameTextBox);
            SearchInformation.Controls.Add(SearchLastNameTextBox);
            SearchInformation.Location = new Point(6, 6);
            SearchInformation.Name = "SearchInformation";
            SearchInformation.Size = new Size(597, 81);
            SearchInformation.TabIndex = 8;
            SearchInformation.TabStop = false;
            SearchInformation.Text = "生徒検索";
            // 
            // SearchFirstNameTextBox
            // 
            SearchFirstNameTextBox.Location = new Point(160, 22);
            SearchFirstNameTextBox.Name = "SearchFirstNameTextBox";
            SearchFirstNameTextBox.PlaceholderText = "名（漢字）";
            SearchFirstNameTextBox.Size = new Size(147, 23);
            SearchFirstNameTextBox.TabIndex = 7;
            // 
            // SearchLastNameTextBox
            // 
            SearchLastNameTextBox.Location = new Point(7, 22);
            SearchLastNameTextBox.Name = "SearchLastNameTextBox";
            SearchLastNameTextBox.PlaceholderText = "姓（漢字）";
            SearchLastNameTextBox.Size = new Size(147, 23);
            SearchLastNameTextBox.TabIndex = 6;
            // 
            // SearchSchoolComboBox
            // 
            SearchSchoolComboBox.FormattingEnabled = true;
            SearchSchoolComboBox.Items.AddRange(new object[] { "所属教室を選択してください", "堀江本校", "STEAMCLUB校", "豊中上野西校" });
            SearchSchoolComboBox.Location = new Point(6, 51);
            SearchSchoolComboBox.Name = "SearchSchoolComboBox";
            SearchSchoolComboBox.Size = new Size(300, 23);
            SearchSchoolComboBox.TabIndex = 11;
            // 
            // SearchEditButton
            // 
            SearchEditButton.Location = new Point(462, 93);
            SearchEditButton.Name = "SearchEditButton";
            SearchEditButton.Size = new Size(141, 33);
            SearchEditButton.TabIndex = 9;
            SearchEditButton.Text = "検索して編集";
            SearchEditButton.UseVisualStyleBackColor = true;
            SearchEditButton.Click += SearchButton_Click;
            // 
            // StudentRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 470);
            Controls.Add(RegisterTab);
            Name = "StudentRegisterForm";
            Text = "生徒登録";
            Load += StudentRegisterForm_Load;
            GeneralInformation.ResumeLayout(false);
            GeneralInformation.PerformLayout();
            PaymentInformation.ResumeLayout(false);
            PaymentInformation.PerformLayout();
            JoiningInformation.ResumeLayout(false);
            JoiningInformation.PerformLayout();
            RegisterTab.ResumeLayout(false);
            AddStudentPage.ResumeLayout(false);
            EditStudentPage.ResumeLayout(false);
            SearchInformation.ResumeLayout(false);
            SearchInformation.PerformLayout();
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
        private ComboBox MembershipFeeCourseComboBox;
        private ComboBox PaymentMethodComboBox;
        private CheckBox SubsidyCardCheckBox;
        private CheckBox TicketCheckBox;
        private ComboBox ClassDayComboBox;
        private ComboBox ClassTimeComboBox;
        private GroupBox JoiningInformation;
        private Label ClassStartLabel;
        private DateTimePicker ClassStartDateTimePicker;
        private TextBox FirstMonthFeeTextBox;
        private TabControl RegisterTab;
        private TabPage AddStudentPage;
        private TabPage EditStudentPage;
        private TextBox SearchFirstNameTextBox;
        private TextBox SearchLastNameTextBox;
        private GroupBox SearchInformation;
        private Button SearchEditButton;
        private ComboBox SearchSchoolComboBox;
    }
}
