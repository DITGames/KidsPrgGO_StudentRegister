using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace KidsPrgGO_StudentRegister
{
    internal class GasApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        private const string EditStudentUrl =
            "https://script.google.com/macros/s/AKfycbwQ8S1mkxmrkjBOy6RLk34w6eAjjX_ZIxvLV5oNMkgoxKm5Qsj09i36QvAmkVkJk2DOvg/exec";

        private const string AddStudentUrl =
            "https://script.google.com/macros/s/AKfycbwORomd53Qxx46hhE1738loZpzDfr4qOOgPQcd6gj_bioY6oRUltbR4nRU13a-L_xLu6g/exec";

        public async Task<string> GetStudentAsync(string name)
        {
            string url =
                $"{EditStudentUrl}?name={Uri.EscapeDataString(name)}";

            return await client.GetStringAsync(url);
        }

        public async Task<string> AddPostStudentAsync(string jsonData)
        {
            HttpContent content =
                new StringContent(
                jsonData,
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = await client.PostAsync(
                    AddStudentUrl,
                    content
                    );

            string result = await response.Content.ReadAsStringAsync();
        
            return result;
        }

        public async Task<string> EditPostStudentAsync(string jsonData)
        {
            HttpContent content =
                new StringContent(
                jsonData,
                Encoding.UTF8,
                "application/json");

            HttpResponseMessage response = await client.PostAsync(
                    EditStudentUrl,
                    content
                    );

            string result = await response.Content.ReadAsStringAsync();

            return result;
        }
    }
}
