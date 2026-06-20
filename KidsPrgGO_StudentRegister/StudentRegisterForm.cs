using System.Net.Http;
using System.Text;

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
                using HttpClient client = new HttpClient();

                string json = $@"
                {{
                    ""name"": ""{""}"",
                    ""grade"": ""{""}"",
                    ""tel"": ""{""}""
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
            MembershipFeeCourceComboBox.SelectedIndex = 0;
            PaymentMethodComboBox.SelectedIndex = 0;
        }
    }
}
