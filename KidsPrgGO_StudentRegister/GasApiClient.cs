using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace KidsPrgGO_StudentRegister
{
    internal class GasApiClient
    {
        private static readonly HttpClient client = new HttpClient();

        private const string BaseUrl =
            "https://script.google.com/macros/s/AKfycbwQ8S1mkxmrkjBOy6RLk34w6eAjjX_ZIxvLV5oNMkgoxKm5Qsj09i36QvAmkVkJk2DOvg/exec";

        public async Task<string> GetStudentAsync(string name)
        {
            string url =
                $"{BaseUrl}?name={Uri.EscapeDataString(name)}";

            return await client.GetStringAsync(url);
        }

    }
}
