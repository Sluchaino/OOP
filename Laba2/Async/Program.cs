using System.Diagnostics;
class Program
{
    static async Task Main()
    {
        Stopwatch time = new();
        time.Start();
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

        // Запрос вакансий по ключевому слову "developer"0
        HttpResponseMessage response = await client.GetAsync("https://api.hh.ru/vacancies?text=developer");
        string json = await response.Content.ReadAsStringAsync();
        File.WriteAllText("C://Users//Maks//Desktop//OOP//Laba2//Async//json//vacancies_developer.json", json);
        // Сохраняем ответ в файл

        // Запрос вакансий по городу Москва
        HttpResponseMessage response1 = await client.GetAsync("https://api.hh.ru/vacancies?area=1");
        string json1 = await response1.Content.ReadAsStringAsync();
        File.WriteAllText("C://Users//Maks//Desktop//OOP//Laba2//Async//json//moscow.json", json1);
        // Сохраняем ответ в файл

        // Запрос вакансий по компании "Альфа Банк"
        HttpResponseMessage response2 = await client.GetAsync("https://api.hh.ru/vacancies?employer_id=80");
        string json2 = await response2.Content.ReadAsStringAsync();
        File.WriteAllText("C://Users//Maks//Desktop//OOP//Laba2//Async//json//alfa_bank_async.json", json2);
        // Сохраняем ответ в файл

        time.Stop();
        Console.WriteLine("Общее время работы: " + time.ElapsedMilliseconds);
    }
}