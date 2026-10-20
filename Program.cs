// System.Console.WriteLine("Сколько студентов в группе?");
// int studentsCount = int.Parse(Console.ReadLine());
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++)
// {
//     System.Console.WriteLine($"Оценка студента {i + 1}:");
//     grades[i] = int.Parse(Console.ReadLine());
// }

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }
// int sred = 0;
// foreach (int grade in grades)
// {
//     sred += grade;
// }
// double average = (double)sred / grades.Length;
// System.Console.WriteLine($"Средний балл:{average}");


// int[] points = { 4, 7, 2, 9, 5 };
// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] <= 10)
//     {
//         points[i] = points[i] + 1;
//     }
// }

// foreach (int point in points)
// {
//     System.Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;
//         }
//     }
// }
// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }
// int[] generateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];
//     for (int i = 0; i < lessonsCount; i++)
//     {
//         slots[i] = i + 1;

//     }
//     return slots;

// }
// int[] slots = generateScheduleSlots(6);
// int[] GenerateEvenSlots(int lessonsCount)
// {
//     for (int j = 0; j < lessonsCount; j++)
//     {
//         if (slots[j] % 2 != 0)
//     }
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     System.Console.WriteLine(grade);
// }

