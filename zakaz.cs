using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Практическая_работа__5
{
    internal class zakaz
    {
        public string spisok;
        public int itog;
        int pos = 3;
        
       
        public void menu()
        {
            
            /*int pos = 3;*/
            Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
            Console.WriteLine("Выберете параметры торта \n ------------------------");
            Console.WriteLine("  Форма торта\n  Размер торта\n  Вкус\n  Количество коржей\n  Глазурь\n  Декор\n  Конец заказа");
            Console.SetCursorPosition(5, 15);
            Console.WriteLine(spisok);

            Console.SetCursorPosition(0, 3);
            Console.WriteLine("->");
            ConsoleKeyInfo clavisha = Console.ReadKey();

            while (clavisha.Key != ConsoleKey.Enter)
            {
                if (clavisha.Key == ConsoleKey.UpArrow) { pos--; }

                else if (clavisha.Key == ConsoleKey.DownArrow) { pos++; }

                Console.Clear();
                Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                Console.WriteLine("Выберете параметры торта \n ------------------------");
                Console.WriteLine("  Форма торта\n  Размер торта\n  Вкус\n  Количество коржей\n  Глазурь\n  Декор\n  Конец заказа");
                Console.SetCursorPosition(5, 15);
                Console.WriteLine(spisok);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                clavisha = Console.ReadKey();
            }

            if (pos == 3)
            {
                Console.Clear();
                Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                Console.WriteLine("Форма торта");
                Console.WriteLine("  Круг - 300\n  Квдрат - 300\n  Пирамида - 500");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                ConsoleKeyInfo podclavisha = Console.ReadKey();
                while (podclavisha.Key != ConsoleKey.Enter)
                {
                    if (podclavisha.Key == ConsoleKey.UpArrow) { pos--; }

                    else if (podclavisha.Key == ConsoleKey.DownArrow) { pos++; }
                    else if (podclavisha.Key == ConsoleKey.Escape) { Console.Clear(); menu(); }

                    Console.Clear();
                    Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                    Console.WriteLine("Форма торта");
                    Console.WriteLine("  Круг - 300\n  Квдрат - 300\n  Пирамида - 500");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    podclavisha = Console.ReadKey();


                }
                switch (pos)
                {
                    case 2:
                        spisok = spisok + " Круг - 300";
                        itog = itog + 300;
                        break;
                    case 3:
                        spisok = spisok + " Квдрат - 300";
                        itog = itog + 300;
                        break;
                    case 4:
                        spisok = spisok + " Пирамида - 500";
                        itog = itog + 500;
                        break;
                }
                
                Console.Clear();
                menu();

            }

            else if (pos == 4)
            {
                Console.Clear();
                Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                Console.WriteLine("Размер Торта");
                Console.WriteLine("  10см - 200\n  20см - 300 \n  30см - 450");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                ConsoleKeyInfo podclavisha = Console.ReadKey();
                while (podclavisha.Key != ConsoleKey.Enter)
                {
                    if (podclavisha.Key == ConsoleKey.UpArrow) { pos--; }

                    else if (podclavisha.Key == ConsoleKey.DownArrow) { pos++; }
                    else if (podclavisha.Key == ConsoleKey.Escape) { Console.Clear(); menu(); }

                    Console.Clear();
                    Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                    Console.WriteLine("Размер Торта");
                    Console.WriteLine("  10см - 200\n  20см - 300 \n  30см - 450");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    podclavisha = Console.ReadKey();



                }
                switch (pos)
                {
                    case 2:
                        spisok = spisok + " 10см - 200";
                        itog = itog + 200;
                        break;
                    case 3:
                        spisok = spisok + " 20см - 300";
                        itog = itog + 300;
                        break;
                    case 4:
                        spisok = spisok + " 30см - 450";
                        itog = itog + 450;
                        break;
                }
                
                Console.Clear();
                menu();
            }

            else if (pos == 5) 
            {
                Console.Clear();
                Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                Console.WriteLine("Вкус Торта");
                Console.WriteLine("  Шоколадный - 100\n  Ягодный - 300 \n  Медоавик - 400");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                ConsoleKeyInfo podclavisha = Console.ReadKey();
                while (podclavisha.Key != ConsoleKey.Enter)
                {
                    if (podclavisha.Key == ConsoleKey.UpArrow) { pos--; }

                    else if (podclavisha.Key == ConsoleKey.DownArrow) { pos++; }
                    else if (podclavisha.Key == ConsoleKey.Escape) { Console.Clear(); menu(); }

                    Console.Clear();
                    Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                    Console.WriteLine("Вкус Торта");
                    Console.WriteLine("  Шоколадный - 100\n  Ягодный - 300 \n  Медоавик - 400");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    podclavisha = Console.ReadKey();



                }
                switch (pos)
                {
                    case 2:
                        spisok = spisok + " Шоколадный - 100";
                        itog = itog + 100;
                        break;
                    case 3:
                        spisok = spisok + " Ягодный - 300";
                        itog = itog + 300;
                        break;
                    case 4:
                        spisok = spisok + " Медоавик - 400";
                        itog = itog + 400;
                        break;
                }
                
                Console.Clear();
                menu();
            }

            else if (pos == 6) 
            {
                Console.Clear();
                Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                Console.WriteLine("Количество коржей");
                Console.WriteLine("  один - 100\n  два - 200 \n  три - 300 \n  четыре - 400");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                ConsoleKeyInfo podclavisha = Console.ReadKey();
                while (podclavisha.Key != ConsoleKey.Enter)
                {
                    if (podclavisha.Key == ConsoleKey.UpArrow) { pos--; }

                    else if (podclavisha.Key == ConsoleKey.DownArrow) { pos++; }
                    else if (podclavisha.Key == ConsoleKey.Escape) { Console.Clear(); menu(); }

                    Console.Clear();
                    Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                    Console.WriteLine("Количество коржей");
                    Console.WriteLine("  один - 100\n  два - 200 \n  три - 300 \n  четыре - 400");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    podclavisha = Console.ReadKey();



                }
                switch (pos)
                {
                    case 2:
                        spisok = spisok + " один - 100";
                        itog = itog + 100;
                        break;
                    case 3:
                        spisok = spisok + " два - 200";
                        itog = itog + 200;
                        break;
                    case 4:
                        spisok = spisok + " три - 300";
                        itog = itog + 300;
                        break;
                    case 5:
                        spisok = spisok + " четыре - 400";
                        itog = itog + 400;
                        break;
                }
                
                Console.Clear();
                menu();

            }

            else if (pos == 7) 
            {
                Console.Clear();
                Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                Console.WriteLine("Вид глазури");
                Console.WriteLine("  Без глазури - 0\n  шоколадная - 300 \n  сахарная - 100");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                ConsoleKeyInfo podclavisha = Console.ReadKey();
                while (podclavisha.Key != ConsoleKey.Enter)
                {
                    if (podclavisha.Key == ConsoleKey.UpArrow) { pos--; }

                    else if (podclavisha.Key == ConsoleKey.DownArrow) { pos++; }
                    else if (podclavisha.Key == ConsoleKey.Escape) { Console.Clear(); menu(); }

                    Console.Clear();
                    Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                    Console.WriteLine("Вид глазури");
                    Console.WriteLine("  Без глазури - 0\n  шоколадная - 300 \n  сахарная - 100");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    podclavisha = Console.ReadKey();



                }
                switch (pos)
                {
                    case 2:
                        spisok = spisok + " Без глазури - 0";
                        itog = itog + 0;
                        break;
                    case 3:
                        spisok = spisok + " шоколадная - 300";
                        itog = itog + 300;
                        break;
                    case 4:
                        spisok = spisok + " сахарная - 100";
                        itog = itog + 100;
                        break;
                }
                
                Console.Clear();
                menu();

            }

            else if (pos == 8)
            {
                Console.Clear();
                Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                Console.WriteLine("Декор");
                Console.WriteLine("  посыпка - 50\n  вафельная бумага - 150 \n  кокосовая стружка 100");
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");
                ConsoleKeyInfo podclavisha = Console.ReadKey();
                while (podclavisha.Key != ConsoleKey.Enter)
                {
                    if (podclavisha.Key == ConsoleKey.UpArrow) { pos--; }

                    else if (podclavisha.Key == ConsoleKey.DownArrow) { pos++; }
                    else if (podclavisha.Key == ConsoleKey.Escape) { Console.Clear(); menu(); }

                    Console.Clear();
                    Console.WriteLine("Заказ тортов у Димыча, торты на ваш выбор");
                    Console.WriteLine("Декор");
                    Console.WriteLine("  посыпка - 50\n  вафельная бумага - 150 \n  кокосовая стружка 100");
                    Console.SetCursorPosition(0, pos);
                    Console.WriteLine("->");
                    podclavisha = Console.ReadKey();



                }
                switch (pos)
                {
                    case 2:
                        spisok = spisok + " посыпка - 50";
                        itog = itog + 50;
                        break;
                    case 3:
                        spisok = spisok + " вафельная бумага - 150";
                        itog = itog + 150;
                        break;
                    case 4:
                        spisok = spisok + " кокосовая стружка 100";
                        itog = itog + 100;
                        break;
                }
                
                Console.Clear();
                menu();

            }

            else if (pos == 9)
            {
                invoice();
            }
            
        }
        public void invoice()
        {
            
            Console.Clear();
            Console.WriteLine("----- ИТОГ -----");
            Console.WriteLine("Выбранные компоненты " + spisok + " Итоговая стоимость - " + itog + "\n результаты были сохранены на рабочий стол. " +
                "\n\t Если желаете создать еще один заказ нажмите Enter..." );
            string itogi = itog.ToString();
            File.AppendAllText("C:\\Users\\zhaby\\Desktop\\История заказов.txt", spisok);
            File.AppendAllText("C:\\Users\\zhaby\\Desktop\\История заказов.txt", itogi);
            ConsoleKeyInfo start = Console.ReadKey();
            if (start.Key == ConsoleKey.Enter) { Console.Clear(); spisok = ""; itog = 0; menu(); }
            else { }
        }

    }
}
