//
// Практическая работа:     Создание переменных и вывод
//

// объявление переменных

string FullName = "Сидоров Петр Иванович";  // Ф.И.О
byte Age = 35;                              // Возраст
string Email = "mail@gmail.com";            // Email
double ScoresCoding = 97;                   // Баллы по программированию
double ScoresMath = 95.7;                   // Баллы по математике
double ScoresPhysics = 93.5;                // Баллы по физике

// вывод данных

Console.WriteLine($"{"Фамилия Имя Отчество: ",30} {FullName,30} \n{"Возраст: ",30} {Age,30} \n{"Email: ",30} {Email,30} \n{"Баллы по программированию: ",30} {ScoresCoding,30} \n{"Баллы по математике: ",30} {ScoresMath,30} \n{"Баллы по физике: ",30} {ScoresPhysics,30}");
Console.ReadKey();


//
// Практическая работа: Реализация подсчёта количества баллов по всем предметам
//

double sum = ScoresCoding + ScoresMath + ScoresPhysics;
double average = sum / 3;

string sumFormated = sum.ToString("### ###.##");
string averageFormated = average.ToString("### ###.##");

Console.WriteLine($"\n{"Сумма баллов: ",30} {sumFormated,30} \n{"Средний балл: ",30} {averageFormated,30}");
Console.ReadKey();