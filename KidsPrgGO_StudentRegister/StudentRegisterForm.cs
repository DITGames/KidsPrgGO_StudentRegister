using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace KidsPrgGO_StudentRegister
{
    public partial class StudentRegisterForm : Form
    {
        public StudentRegisterForm()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 入力チェック
                if (checkValue())
                {
                    return;
                }

                using HttpClient client = new HttpClient();

                string json = $@"
                {{
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
                    ""firstMonthFee"": ""{FirstMonthFeeTextBox.Text}""
                }}";

                HttpContent content =
                    new StringContent(
                        json,
                        Encoding.UTF8,
                        "application/json");

                HttpResponseMessage response = await client.PostAsync(
                        "https://script.google.com/macros/s/AKfycbwORomd53Qxx46hhE1738loZpzDfr4qOOgPQcd6gj_bioY6oRUltbR4nRU13a-L_xLu6g/exec",
                        content
                        );

                string result =
                    await response.Content.ReadAsStringAsync();

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

        private void StudentRegisterForm_Load(object sender, EventArgs e)
        {
            // コンボボックスの初期項目を設定（選択してください）
            SexComboBox.SelectedIndex = 0;
            SchoolComboBox.SelectedIndex = 0;
            CourseComboBox.SelectedIndex = 0;
            ClassDayComboBox.SelectedIndex = 0;
            ClassTimeComboBox.SelectedIndex = 0;
            MembershipFeeCourseComboBox.SelectedIndex = 0;
            PaymentMethodComboBox.SelectedIndex = 0;
        }

        private void FirstMonthFeeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 数字 or バックスペース以外を禁止
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void FirstMonthFeeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(FirstMonthFeeTextBox.Text, out _))
            {
                FirstMonthFeeTextBox.Text = "";
            }
        }

        private bool checkValue()
        {
            // 名前欄のチェック
            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text) || string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show(
                    "名前を入力してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }

            // 名前フリガナのチェック
            if (string.IsNullOrWhiteSpace(LastRubyTextBox.Text) || string.IsNullOrWhiteSpace(FirstRubyTextBox.Text))
            {
                MessageBox.Show(
                    "フリガナを入力してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return true;
            }

            // 性別
            if (SexComboBox.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "性別を選択してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            //  教室
            if (SchoolComboBox.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "所属教室を選択してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            // コース
            if (CourseComboBox.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "コースを選択してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            // 受講曜日
            if (ClassDayComboBox.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "受講曜日を選択してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            // 受講コマ
            if (ClassTimeComboBox.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "受講コマを選択してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            // 会費コース
            if (MembershipFeeCourseComboBox.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "会費コースを選択してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            // 決済方法
            if (PaymentMethodComboBox.SelectedIndex == 0)
            {
                MessageBox.Show(
                    "決済方法を選択してください",
                    "入力エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return true;
            }

            return false;
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            //await GetStudentAsync(SearchLastNameTextBox.Text + " " + SearchFirstNameTextBox.Text);
        }
    }
}
