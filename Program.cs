//Задание 1.1

// for (int i = 10; i != 0; i--) {
//     Console.WriteLine(i);
// }

//Задание 1.2
// for (int i = 2; i <= 50; i += 2) {
//      Console.WriteLine(i);
// }

//Задание 2
// int count = 0;
// int sum = 0;
// for (int i = 1; i != 100; i++)
// {
//      if (i % 3 == 0)
//      {
//           sum += i;
//      }
//      if (i % 7 == 0)
//      {
//           count++;
//      }
// }
// Console.Write("sum: {0}, count, {1}", sum, count);
// // Заданние 3
// int number = Convert.ToInt32(Console.ReadLine());
// int pol = 0;
// int otr = 0;
// while (number != 0)
// {
//      if (number < 0)
//      {
//           pol++;
//      }
//      else if (number > 0)
//      {
//           otr++;   
//      }
//      number = Convert.ToInt32(Console.ReadLine());
// }
// Console.Write($"Положительные: {pol}, Отрицательные: {otr}");
// Задание 4
// string password;
// int a = 0;
// do
// {
//     Console.Write("Введите пароль: ");
//     password = Console.ReadLine();
//     a++;

//     if (password == "qwerty")
//     {
//         Console.WriteLine("Доступ разрешен");
//         break; 
//     }
// }
// while (a < 3);

// if (password != "qwerty"){
//     Console.WriteLine("Доступ заблокирован");
// }
// Задание 5
// int a = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= 10; i++)
// {
//      Console.WriteLine($"{a} * {i} = {a*i}");
// }

// Задание 6
// for (int i = 0; i <= 30; i++)
// {
//      if (i % 3 == 0)
//      {
//           continue;
//      }
//      else if (i % 10 == 0 && i > 20)
//      {
//           break;
//      }
//      else
//      {
//           Console.WriteLine(i);
//      }
// }
// Итоговая задача. «Угадай число»
int secret = 42;
int number = 0;

for (int a = 1; a <= 5; a++)
{
    Console.Write("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number == secret)
    {
        Console.WriteLine("Победа! Попыток: " + a);
        break;
    }
    else if (number < secret)
        Console.WriteLine("Больше");
    else
        Console.WriteLine("Меньше");
}

if (number != secret){
    Console.WriteLine("Вы проиграли, число было 42");
}
// Дополнительное задание
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// while (n > 0)
// {
//      sum += n % 10;
//      n /= 10;
// }
// Console.WriteLine(sum);
