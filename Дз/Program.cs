using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз
{
    internal class Program
    {
        enum Dninedeli
        {
            Понедельник,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Форточка");
            Console.WriteLine("Введите длину форточки");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину форточки");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите диаметр Васиной головы");
            double c = double.Parse(Console.ReadLine());
            if (a >= c + 2 && b >= c + 2)
            {
                Console.WriteLine("Вася сможет просунуть голову");
            }
            else
            {
                Console.WriteLine("Вася не сможет просунуть голову");
            }
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Задание 2. Таблица умножения");
            Console.WriteLine("Введите число 1 <= n <= 9");
            int n = int.Parse(Console.ReadLine());
            if (n >= 1 && n <= 9)
            {
                Console.WriteLine($"1*{n} = {n * 1}");
                Console.WriteLine($"2*{n} = {n * 2}");
                Console.WriteLine($"3*{n} = {n * 3}");
                Console.WriteLine($"4*{n} = {n * 4}");
                Console.WriteLine($"5*{n} = {n * 5}");
                Console.WriteLine($"6*{n} = {n * 6}");
                Console.WriteLine($"7*{n} = {n * 7}");
                Console.WriteLine($"8*{n} = {n * 8}");
                Console.WriteLine($"9*{n} = {n * 9}");
            }
            else
            {
                Console.WriteLine("Введите число, удовлетворяющее условию!");
            }
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Задание 3. Делимость на 3 и 5");
            Console.WriteLine("Введите число");
            int chislo = int.Parse(Console.ReadLine());
            if (chislo % 3 == 0 && chislo % 5 == 0)
            {
                Console.WriteLine("БэнгБум");
            }
            else if (chislo % 3 == 0)
            {
                Console.WriteLine("Бэнг");
            }
            else if (chislo % 5 == 0)
            {
                Console.WriteLine("Бум");
            }
            else
            {
                Console.WriteLine("Мимо");
            }
            Console.ReadKey();
            Console.Clear();
           
            Console.WriteLine("Задание 4. Заглавные буквы");
            Console.WriteLine("Введите строку");
            string stroka = Console.ReadLine();
            int cnt = 0;
            foreach (Char c in stroka.ToCharArray())
            {
                if (Char.IsUpper(c))
                {
                    cnt++;
                }
            }
            if (cnt == stroka.Length)
            {
                Console.WriteLine("Все буквы заглавные");
            }
            else
            {
                Console.WriteLine("Не все буквы заглавные");
            }
            Console.ReadKey();
            Console.Clear();
             
            Console.WriteLine("Задание 5. Овца");
            Console.WriteLine("Введите целое положительное число");
            int sheep = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sheep; i++)
            {
                Console.Write(i + " овца... ");
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 6. Среднее арифметическое");
            Console.Write("Введите через пробел последовательность неотрицательных целых чисел, оканчивающуюся отрицательным числом: ");
            string str = Console.ReadLine();
            string[] str_1 = str.Split(' ');
            int[] posl = new int[str_1.Length];
            for (int i = 0; i < posl.Length; i++)
                posl[i] = int.Parse(str_1[i]);
            double sum = 0;
            try
            {
                for (int i = 0; i < (posl.Length - 1); i++)
                    sum += posl[i];
                double sr_arif = sum / (posl.Length - 1);
                Console.WriteLine($"Среднее арифметическое равно {sr_arif}");
            }
            catch (Exception)
            {
                Console.WriteLine("Пожалуйста, введите последовательность корректно");
            }
            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 7. Карты");
            try
            {
                int karta = Convert.ToInt32(Console.ReadLine());
                switch (karta)
                {
                    case 6: 
                        Console.WriteLine("шестёрка"); 
                        break;
                    case 7: 
                        Console.WriteLine("семёрка"); 
                        break;
                    case 8: 
                        Console.WriteLine("восьмёрка"); 
                        break;
                    case 9: 
                        Console.WriteLine("девятка"); 
                        break;
                    case 10: 
                        Console.WriteLine("десятка"); 
                        break;
                    case 11: 
                        Console.WriteLine("валет"); 
                        break;
                    case 12: 
                        Console.WriteLine("дама"); 
                        break;
                    case 13: 
                        Console.WriteLine("король"); 
                        break;
                    case 14: 
                        Console.WriteLine("туз"); 
                        break;
                    default: 
                        Console.WriteLine("Неверный ввод"); 
                        break;
                }
            }
            catch (Exception)
            { 
                Console.WriteLine("Ошибка"); 
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 8. Кукла");
            int kukli = 0;
            string[] sumka = { "passport", "sigi", "Hello Kitty", "pivo", "studak", "Barbie doll", "telephone" };
            foreach (string s in sumka)
            {
                if (s == "Hello Kitty" || s == "Barbie doll")
                {
                    kukli++;
                }
            }
            Console.WriteLine($"В сумке {kukli} куклы");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Задание 9. Дни недели");
            Console.WriteLine("Введите номер дня недели: ");
            int dni = int.Parse(Console.ReadLine());
            switch (dni)
            {
                case 1:
                    Console.WriteLine(Dninedeli.Понедельник);
                    break;
                case 2:
                    Console.WriteLine(Dninedeli.Вторник);
                    break;
                case 3:
                    Console.WriteLine(Dninedeli.Среда);
                    break;
                case 4:
                    Console.WriteLine(Dninedeli.Четверг);
                    break;
                case 5:
                    Console.WriteLine(Dninedeli.Пятница);
                    break;
                case 6:
                    Console.WriteLine(Dninedeli.Суббота);
                    break;
                case 7:
                    Console.WriteLine(Dninedeli.Воскресенье);
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            
            Console.WriteLine("Задание 10. Сортировка");
            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки:");
            int[] mas = new int[N];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            BubbleSort(mas);
            Console.Write("Сортировка 'пузырьком': ");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.Write("| Сортировка с помощью внутренних методов: ");
            Array.Sort(mas);
            foreach (int I in mas)
                Console.Write(I + " ");
            Console.ReadKey();
            Console.Clear();
           
            
            Console.WriteLine("Задание 11. Последовательность");
            int[] bubble = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int m=0;
            for (int i = 0; i < bubble.Length; i++)
            {
                for (int j = 0; j < bubble.Length - 1 - i; j++)
                {
                    if (bubble[j] < bubble[j + 1])
                    {
                        m++;
                    }
                    else
                    {

                        Console.WriteLine($"Элемент {j + 2} нарушает упорядоченность последовательности");
                        break;
                    }
                    if (m + 1 == bubble.Length)
                    { Console.WriteLine("Последовательность упорядочена"); }
                }
                break;
            }
        }
    }
}