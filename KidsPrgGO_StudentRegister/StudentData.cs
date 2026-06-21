using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace KidsPrgGO_StudentRegister
{
    public class StudentData
    {
        public int row { get; set; }
        public JsonElement[] data { get; set; }

        // 項目ごとの変数
        public int id;
        public string name;
        public string ruby;
        public string sex;
        public bool brother;
        public string joiningGrade;
        public string school;
        public string course;
        public int admissionFee;
        public int teachingMaterialCost;
        public int firstMonthFee;
        public string classStartDay;
        public bool adjourn;
        public string lastWithdrawalOrPauseDate;
        public string membershipFeeCourse;
        public bool ticket;
        public bool subsidyCard;
        public int taxIncludedTuitionFee;
        public int taxExcludedTuitionFee;
        public string classDay;
        public string classTime;
        public string paymentMethod;

        /// <summary>
        /// dataを各変数に変換
        /// </summary>
        public void ConvertData()
        {
            id = SafeInt(data[0]);
            name = data[1].ToString();
            ruby = data[2].ToString();
            sex = data[3].ToString();
            brother = data[4].GetBoolean();
            joiningGrade = data[5].ToString();
            school = data[6].ToString();
            course = data[7].ToString();
            admissionFee = SafeInt(data[8]);
            teachingMaterialCost = SafeInt(data[9]);
            firstMonthFee = SafeInt(data[10]);
            classStartDay = data[11].ToString();
            adjourn = data[12].GetBoolean();
            lastWithdrawalOrPauseDate = data[13].ToString();
            membershipFeeCourse = data[14].ToString();
            ticket = data[15].GetBoolean();
            subsidyCard = data[16].GetBoolean();
            taxIncludedTuitionFee = SafeInt(data[17]);
            taxExcludedTuitionFee = SafeInt(data[18]);
            classDay = data[19].ToString();
            classTime = data[20].ToString();
            paymentMethod = data[21].ToString();
        }

        int SafeInt(JsonElement e)
        {
            switch (e.ValueKind)
            {
                case JsonValueKind.Number:
                    {
                        // float / double / int すべて対応
                        double d = e.GetDouble();
                        return (int)Math.Round(d, MidpointRounding.AwayFromZero);
                    }

                case JsonValueKind.String:
                    {
                        if (double.TryParse(e.GetString(), out var d))
                            return (int)Math.Round(d, MidpointRounding.AwayFromZero);

                        return 0;
                    }

                default:
                    return 0;
            }
        }
    }
}
