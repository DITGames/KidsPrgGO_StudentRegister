using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace KidsPrgGO_StudentRegister
{
    public partial class StudentEditForm : Form
    {

        StudentData studentData;

        public StudentEditForm()
        {
            InitializeComponent();
        }

        public async void SearchStudent(string name)
        {
            GasApiClient api = new GasApiClient();

            // 生徒を検索
            string result = await api.GetStudentAsync(name);

            // データを項目ごとに振り分け
            if (result.Contains("\"error\""))
            {
                MessageBox.Show("データを取得できませんでした", "データ取得エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("生徒が見つかりました　編集を開始します", "検索成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                studentData = JsonSerializer.Deserialize<StudentData>(result);
            }

            // データー変換
            if (studentData.data != null)
            {
                studentData.ConvertData();
            }
            else
            {
                MessageBox.Show("データをJSONへ変換できませんでした", "データ取得エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            //=== フォームに反映 ===// 
            // 名前
            LastNameTextBox.Text = studentData.name.Split(' ')[0];
            FirstNameTextBox.Text = studentData.name.Split(' ')[1];
            LastRubyTextBox.Text = studentData.ruby.Split(' ')[0];
            FirstRubyTextBox.Text = studentData.ruby.Split(' ')[1];

            // 基本情報
            BrotherCheckBox.Checked = studentData.brother;
            SexComboBox.Text = studentData.sex;
            SchoolComboBox.Text = studentData.school;
            CourseComboBox.Text = studentData.course;
            ClassDayComboBox.Text = studentData.classDay;
            ClassTimeComboBox.Text = studentData.classTime;

            // 決済
            MembershipFeeCourseComboBox.Text = studentData.membershipFeeCourse;
            PaymentMethodComboBox.Text = studentData.paymentMethod;
            TicketCheckBox.Checked = studentData.ticket;
            SubsidyCardCheckBox.Checked = studentData.subsidyCard;

            // 入会時情報
            if (DateTime.TryParse(studentData.classStartDay, out var dt))
            {
                ClassStartDateTimePicker.Value = dt.ToLocalTime();
            }
            AdjournCheckBox.Checked = studentData.adjourn;
            FirstMonthFeeTextBox.Text = studentData.firstMonthFee.ToString();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {

                string json = $@"
                {{
                    ""editRow"": ""{studentData.row}"",

                    ""name"": ""{LastNameTextBox.Text + " " + FirstNameTextBox.Text}"",
                    ""ruby"": ""{LastRubyTextBox.Text + " " + FirstRubyTextBox.Text}"",
                    ""sex"": ""{SexComboBox.Text}"",
                    ""brother"": ""{BrotherCheckBox.Checked.ToString().ToUpper()}"",
                    ""school"": ""{SchoolComboBox.Text}"",
                    ""course"": ""{CourseComboBox.Text}"",
                    ""classDay"": ""{ClassDayComboBox.Text}"",
                    ""classTime"": ""{ClassTimeComboBox.Text}"",

                    ""membershipFeeCourse"": ""{MembershipFeeCourseComboBox.Text}"",
                    ""ticket"": ""{TicketCheckBox.Checked.ToString().ToUpper()}"",
                    ""subsidyCard"": ""{SubsidyCardCheckBox.Checked.ToString().ToUpper()}"",
                    ""paymentMethod"": ""{PaymentMethodComboBox.Text}"",

                    ""classStartDay"": ""{ClassStartDateTimePicker.Value.ToString("yyyy/MM/dd")}"",
                    ""adjourn"": ""{AdjournCheckBox.Checked.ToString().ToUpper()}"",
                    ""firstMonthFee"": ""{FirstMonthFeeTextBox.Text}""
                }}";

                // GASへ情報を送信
                GasApiClient api = new GasApiClient();
                string result = await api.EditPostStudentAsync(json);

                MessageBox.Show(
                    "登録完了\n" + result,
                    "成功",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
