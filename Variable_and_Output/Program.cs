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
