// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() 
// {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
//     System.Console.WriteLine("Дата формирования отчета: 20.10.2026");
// }

// void PrintFooter()
// {
//     Console.WriteLine(">_<");
//     Console.WriteLine("Конец программы");
//     Console.WriteLine("X_X");
// }  // задание 1



// void PrintStudentCard(string name, int age, string fas) 
// {
//     Console.WriteLine($"Студент: {name}, возраст: {age}, номер группы: {fas}");
// }

// PrintStudentCard("Егор", 18, "2");
// PrintStudentCard("Валерия", 17, "4"); //задание 2

// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }
// double averageGrade = 4.7;

// if (IsEligibleForBonus(averageGrade))
// {
//     double result = CalculateScholarship(2000, 15);
//     System.Console.WriteLine(result);
// }
// else
// {
//     System.Console.WriteLine(2000);
// }  // задание 3


// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades)
// {
//     int count = 0;

//     foreach (int grade in grades)
//     {
//         if (grade == 5)
//         {
//             count++;
//         }
//     }
//     return count;
// }


// int[] grades = { 4, 5, 3, 5, 4 };
// double average = CalculateAverageGrade(grades);
// int fives = CountFives(grades);

// System.Console.WriteLine(average);
// System.Console.WriteLine(fives); задание 4



