using System;

namespace Ninith_lab
{
    class Ninth_lab
    {
        enum Months
        {
            января = 1,
            февраля,
            марта,
            фпреля, 
            мая,
            июня, 
            июля, 
            августа, 
            сентября, 
            октября, 
            ноября,
            декабря
        }

        enum OneToNine 
        {
            первое = 1,
            второе, 
            третье, 
            четвёртое, 
            пятое,
            шестое,
            седьмое, 
            восьмое, 
            девятое
        }

        enum Direction
        {
            ю,
            з,
            с,
            в
        }


        static void Main(string[] args)
        {
            // Первое задание
            Console.WriteLine("Введите день и месяц (Через Enter): ");
            First(Convert.ToInt32(Console.ReadLine()),
                  Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            //Второе задание
            Console.WriteLine("Введите начальное положение(«С» — север, «З» — запад, «Ю» — юг, «В» — восток)" +
                              " и след. действие (-1,0,1): ");
            Second(Console.ReadLine(),
                   Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Третье задание
            Console.WriteLine("Введите количество учебных заданий(от 10 до 40): ");
            Third(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();

            // Четвёртое задание
            Console.WriteLine("Введите число: ");
            Fourth(Console.ReadLine());
            Console.WriteLine();

            // Пятое задание 
            Console.WriteLine("Введите год: ");
            Fifth(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine();


        }


        private static void First(int Day, int Month)
        {
            string output = "";

            if (Day > 31 || Day < 1) Console.WriteLine("Выбран несуществующий день");

            else {
                switch (Day / 10)
                {
                    case 0:
                        output += (OneToNine)Day + " ";
                        output += (Months)Month;
                        break;
                    case 1:
                        switch (Day % 10)
                        {
                            case 0:
                                output += "Десятое ";
                                break;
                            case 1:
                                output += "Одиннадцатое ";
                                break;
                            case 2:
                                output += "Двенадцатое ";
                                break;
                            case 3:
                                output += "Тринадцатое ";
                                break;
                            case 4:
                                output += "Четырнадцатое ";
                                break;
                            case 5:
                                output += "Пятнадцатое ";
                                break;
                            case 6:
                                output += "Шестнадцатое ";
                                break;
                            case 7:
                                output += "Семнадцатое ";
                                break;
                            case 8:
                                output += "Восемнадцатое ";
                                break;
                            case 9:
                                output += "Девятнадцатое ";
                                break;
                        }
                        output += (Months)Month;
                        break;
                    case 2:
                        if (Day != 0)
                        {
                            output += "Двадцать ";
                            output += (OneToNine)(Day % 10) ;
                        }
                        else output += "Двадцатое ";
                        output += (Months)Month;
                        break;
                    case 3:
                        if (Day % 10 == 0)
                        {
                            output += "Тридцатое ";
                            output += (Months)Month;
                        }

                        else if (Day % 10 == 1)
                        {
                            output += "Тридцать первое ";
                            output += (Months)Month;
                        }
                        else
                        {
                            output = "Дата введена неправильно";
                        }
                        break;
                    default:
                        output = "Дата введена неправильно";
                        break;
                }
            }
            Console.WriteLine(output);
        }

        private static int EnumElementIndexByName(string element)
        {
            var arr = Enum.GetNames(typeof(Direction));
            for (int index = 0; index < arr.Length; index++)
            {
                if (arr[index].ToLower() == element.ToLower().Replace(" ", ""))
                {
                    return index;
                }
            }
            return -1;
        }
        private static void Second(string dir, int changeDir)
        {
            var index = EnumElementIndexByName(dir.ToLower());
            if (index == -1) Console.WriteLine("Данные были введены некорретные данные");

            else
            {
                var newdir = changeDir + index;
                if (newdir == -1) Console.WriteLine("В");
                else if (newdir == 4) Console.WriteLine("С");
                else Console.WriteLine( ((Direction)(changeDir + index)).ToString().ToUpper());
            }
            
        }

        private static void Third(int N)
        {
            string output = "";
            if (N / 10 == 1)
            {
                switch (N % 10)
                {
                    case 0:
                        output = "Десять учебных заданий";
                        break;
                    case 1:
                        output = "Одиннадцать учебных заданий";
                        break;
                    case 2:
                        output = "Двенадцать учебных заданий";
                        break;
                    case 3:
                        output = "Тринадцать учебных заданий";
                        break;
                    case 4:
                        output = "Четырнадцать учебных заданий";
                        break;
                    case 5:
                        output ="Пятнадцать учебных заданий";
                        break;
                    case 6:
                        output = "Шестнадцать учебных заданий";
                        break;
                    case 7:
                        output = "Семнадцать учебных заданий";
                        break;
                    case 8:
                        output = "Восемнадцать учебных заданий";
                        break;
                    case 9:
                        output = "Девятнадцать учебных заданий";
                        break;
                }
            }
            else
            {
                switch (N / 10)
                {
                    case 2:
                        output = "Двадцать ";
                        break;
                    case 3:
                        output = "Тридцать ";
                        break;
                    case 4:
                        if(N % 10 == 0) output = "Сорок учебных заданий";
                        else output = "Введены некорректные данные";
                        break;
                    default:
                        if(N / 10 != 0) output = "Введены некорректные данные";
                        break; 
                }
                if(N < 40) 
                {
                    switch(N% 10) 
                    {
                        case 1:
                            output += "одно учебное задание";
                            break;
                        case 2:
                            output += "два учебных задания";
                            break;
                        case 3:
                            output += "три учебных задания";
                            break;
                        case 4:
                            output += "четыре учебных задания";
                            break;
                        case 5:
                            output += "пять учебных задания";
                            break;
                        case 6:
                            output += "шесть учебных задания";
                            break;
                        case 7:
                            output += "семь учебных задания";
                            break;
                        case 8:
                            output += "восемь учебных задания";
                            break;
                        case 9:
                            output += "девять учебных задания";
                            break;
                    }
                }
            }
            Console.WriteLine(output);
        }

        private static void Fourth(string NumberAsString)
        {
            string[] hundreds = new[] {"Cто", "Двести", "Триста", "Четыреста", "Пятьсот", 
                                    "Шестьсот", "Семьсот", "Восемьсот", "Девятьсот" };
            string[] tens = new[] {"", "десять", "двадцать", "тридцать", "сорок", "пятьдесят",
                                    "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] units = new[] {"" , "один", "два", "три", "четыре", "пять",
                                    "шесть", "семь", "восемь", "девять" };

            if (NumberAsString.Replace(" ", "").Length != 3) Console.WriteLine("Введены некорректные данные");
            else
            {
                int NumberAsInteger = Convert.ToInt32(NumberAsString);
                string output = hundreds[NumberAsInteger / 100 - 1] + " " + tens[(NumberAsInteger / 10) % 10] + " " 
                                +  units[NumberAsInteger % 10];
                Console.WriteLine(output);
            }
        }

        private static void Fifth(int Year)
        {
            string output = "Год ";
            switch (Year % 10)
            {
                case 0:
                case 1:
                    output += "бел";
                    break;
                case 2:
                case 3:
                    output += "черн";
                    break;
                case 4:
                case 5:
                    output += "зелён";
                    break;
                case 6:
                case 7:
                    output += "красн";
                    break;
                case 8:
                case 9:
                    output += "жёлт";
                    break;
            }


            switch ((Year + 1) % 12)
            {            
                case 2:
                case 3:
                case 4:
                    output += "ого ";
                    break;
                case 0:
                case 1:
                case 5:
                case 6:                   
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                    output += "ой ";
                    break;
            }

            switch ((Year + 8) % 12)
            {
                case 0:
                    output += "крысы";
                    break;
                case 1:
                    output += "коровы";
                    break;
                case 2:
                    output += "тигра";
                    break;
                case 3:
                    output += "зайца";
                    break;
                case 4:
                    output += "дракон";
                    break;
                case 5:
                    output += "змеи";
                    break;
                case 6:
                    output += "лошади";
                    break;
                case 7:
                    output += "овцы";
                    break;
                case 8:
                    output += "обезьяны";
                    break;
                case 9:
                    output += "курицы";
                    break;
                case 10:
                    output += "собаки";
                    break;
                case 11:
                    output += "свиньи";
                    break;
            }
            Console.WriteLine(output);
        }

    }
}
