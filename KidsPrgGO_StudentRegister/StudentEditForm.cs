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
            // 生徒を検索
            string result = await GetStudentAsync(name); 
            
            // データを項目ごとに振り分け
            if (!string.IsNullOrWhiteSpace(result)) 
            { 
                MessageBox.Show( result, "検索成功", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                studentData = JsonSerializer.Deserialize<StudentData>(result); 
            } else 
            { 
                MessageBox.Show( "データをJSONへ変換できませんでした", "データ取得エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            } 
            
            // データー変換
            if (studentData != null) 
            { 
                studentData.ConvertData(); 
            } else 
            { 
                MessageBox.Show( "データをJSONへ変換できませんでした", "データ取得エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; 
            } 
            
            //=== フォームに反映 ===// 
            // 名前
            LastNameTextBox.Text = studentData.name.Split(' ')[0]; 
            FirstNameTextBox.Text = studentData.name.Split(' ')[1]; 
            
            // フリガナ
            LastRubyTextBox.Text = studentData.ruby.Split(' ')[0]; 
            FirstRubyTextBox.Text = studentData.ruby.Split(' ')[1];
        }

        async Task<string> GetStudentAsync(string name)
        {
            using HttpClient client = new HttpClient(); 
            string url = $"https://script.google.com/macros/s/AKfycbwQ8S1mkxmrkjBOy6RLk34w6eAjjX_ZIxvLV5oNMkgoxKm5Qsj09i36QvAmkVkJk2DOvg/exec?name={name}"; 
            string response = await client.GetStringAsync(url); 
            var json = JsonSerializer.Deserialize<dynamic>(response); 
            MessageBox.Show("生徒情報の取得に成功しました", "検索成功", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            return response;
        }
    }
}
