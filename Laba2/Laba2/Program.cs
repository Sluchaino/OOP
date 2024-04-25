using System.Diagnostics;

Stopwatch time = new();
time.Start();
var client = new HttpClient();
client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

// Запрос вакансий по компании "Альфа Банк"
HttpResponseMessage response = client.GetAsync("https://api.hh.ru/vacancies?employer_id=80").Result;
string json = response.Content.ReadAsStringAsync().Result;
File.WriteAllText("C://Users//Maks//Desktop//OOP//Laba2//json//sync//alfa_bank_sync.json", json);
// Сохраняем ответ в файл

// Запрос вакансий по городу Москва
HttpResponseMessage response1 = client.GetAsync("https://api.hh.ru/vacancies?area=1").Result;
string json1 = response1.Content.ReadAsStringAsync().Result;
File.WriteAllText("C://Users//Maks//Desktop//OOP//Laba2//json//sync//moscow.json", json1);
// Сохраняем ответ в файл

// Запрос вакансий по ключевому слову "c# middle developer"
HttpResponseMessage response2 = client.GetAsync("https://api.hh.ru/vacancies?text=c#+middle+developer").Result;
string json2 = response2.Content.ReadAsStringAsync().Result;
File.WriteAllText("vacancies_c#_junior_developer.json", json2);
// Сохраняем ответ в файл

time.Stop();
Console.WriteLine("Общее время работы: " + time.ElapsedMilliseconds);