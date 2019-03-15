using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;

namespace KPLab
{
    class Payment
    {
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public int TalkDateY { get; set; }
        public int TalkDateM { get; set; }
        public int TalkDateD { get; set; }
        public float Tariff { get; set; }
        public float Discount { get; set; }
        public int StartTalkH { get; set; }
        public int StartTalkM { get; set; }
        public int EndTalkH { get; set; }
        public int EndTalkM { get; set; }
        public float TalkLength { get; set; }
        public float Total { get; set; }
        public DateTime Date { get; set; }
        public Payment(string surname, string phoneNumber, int talkDateY, int talkDateM, int talkDateD, float tariff, float discount, int startTalkH, int startTalkM, int endTalkH, int endTalkM)
        {
            Surname = surname;
            PhoneNumber = phoneNumber;
            TalkDateY = talkDateY;
            TalkDateM = talkDateM;
            TalkDateD = talkDateD;
            Tariff = tariff;
            Discount = discount;
            StartTalkH = startTalkH;
            StartTalkM = startTalkM;
            EndTalkH = endTalkH;
            EndTalkM = endTalkM;
            TalkLength = Math.Abs((EndTalkH - StartTalkH) * 60 + (endTalkM - startTalkM));
            Date = new DateTime(TalkDateY, TalkDateM, TalkDateD);
            Total = Tariff - (Tariff * Discount / 100);
        }
    }
    class Program
    {
        static bool CheckCorrectness(string surname, string phoneNumber, int talkDateY, int talkDateM, int talkDateD, float tariff, float discount, int startTalkH, int startTalkM, int endTalkH, int endTalkM)
        {
            Regex regex = new Regex(@"(\+375)(44|25|33|29|)[0-9]{7}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            if (surname[0] < 'А' || surname[0] > 'Я' && surname[0] != 'Ё')
            {
                Console.WriteLine("Фамилия с большой буквы!");
                return false;
            }
            if (!regex.IsMatch(phoneNumber))
            {
                Console.WriteLine("Формат номера +375(КК)ННННННН");
                return false;
            }
            if (talkDateY < 1950 || talkDateY > 2020)
            {
                Console.WriteLine("Неверная дата звонка! (год от 1950 до 2019)");
                return false;
            }
            if (talkDateM < 1 || talkDateM > 12)
            {
                Console.WriteLine("Неверная дата звонка! (месяц от 1 до 12)");
                return false;
            }
            if (talkDateD < 1 || talkDateD > 31)
            {
                Console.WriteLine("Неверная дата звонка! (день от 1 до 31)");
                return false;
            }
            if (tariff < 1 || tariff > 100)
            {
                Console.WriteLine("Тариф от 1 до 100!");
                return false;
            }
            if (discount < 1 || discount > 65)
            {
                Console.WriteLine("Скидка от 1 до 65!");
                return false;
            }
            if (startTalkH < 0 || startTalkH > 23)
            {
                Console.WriteLine("Неверная дата начала звонка! (час от 0 до 23)");
                return false;
            }
            if (startTalkM < 1 || startTalkM > 59)
            {
                Console.WriteLine("Неверная дата начала звонка! (минуты от 1 до 59)");
                return false;
            }
            if (endTalkH < 0 || endTalkH > 23)
            {
                Console.WriteLine("Неверная дата окончания звонка! (час от 0 до 23)");
                return false;
            }
            if (endTalkM < 1 || endTalkM > 59)
            {
                Console.WriteLine("Неверная дата начала звонка! (минуты от 1 до 59)");
                return false;
            }
            return true;
        }
        static void ShowPayments(List<Payment> payments)
        {
            foreach (var item in payments)
            {
                Console.Write($"\nФамилия: {item.Surname}");
                Console.Write($"\nНомер телефона: {item.PhoneNumber}");
                Console.Write($"\nСтоимость тарифа: {item.Tariff}");
                Console.Write($"\nЛичная скидка: {item.Discount}%");
                Console.Write($"\nДата разговора: {item.TalkDateD}.{item.TalkDateM}.{item.TalkDateY}");
                Console.Write($"\nНачало разговора: {item.StartTalkH}.{item.StartTalkM}");
                Console.Write($"\nОкончание разговора: {item.EndTalkH}.{item.EndTalkM} ");
                Console.Write($"\nСтоимость звонка: {item.Total}");
                Console.WriteLine("\n----------------------");
            }
        }
        static void ShowInstruction()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Добавить платёж \n2. Показать платежи \n3. Очистить консоль \n4. Выборка по заданию \n5. Выход\n\n");
        }
        static void AddToXml(Payment obj)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("D:/payments.xml");
            XmlElement xRoot = xmlDocument.DocumentElement;
            XmlElement paymentsElem = xmlDocument.CreateElement("payment");

            XmlAttribute surnameAttr = xmlDocument.CreateAttribute("surname");
            XmlElement numberElem = xmlDocument.CreateElement("phoneNumber");
            XmlElement yearElem = xmlDocument.CreateElement("year");
            XmlElement monthElem = xmlDocument.CreateElement("month");
            XmlElement dayElem = xmlDocument.CreateElement("day");
            XmlElement tariffElem = xmlDocument.CreateElement("tariff");
            XmlElement discountElem = xmlDocument.CreateElement("discount");
            XmlElement startHElem = xmlDocument.CreateElement("startH");
            XmlElement startMElem = xmlDocument.CreateElement("startM");
            XmlElement endHElem = xmlDocument.CreateElement("endH");
            XmlElement endMElem = xmlDocument.CreateElement("endM");

            XmlText surnameText = xmlDocument.CreateTextNode(obj.Surname);
            XmlText numberText = xmlDocument.CreateTextNode(obj.PhoneNumber);
            XmlText yeartext = xmlDocument.CreateTextNode(obj.TalkDateY.ToString());
            XmlText monthText = xmlDocument.CreateTextNode(obj.TalkDateM.ToString());
            XmlText dayText = xmlDocument.CreateTextNode(obj.TalkDateD.ToString());
            XmlText tariffText = xmlDocument.CreateTextNode(obj.Tariff.ToString());
            XmlText discountText = xmlDocument.CreateTextNode(obj.Discount.ToString());
            XmlText startHText = xmlDocument.CreateTextNode(obj.StartTalkH.ToString());
            XmlText startMText = xmlDocument.CreateTextNode(obj.StartTalkM.ToString());
            XmlText endHText = xmlDocument.CreateTextNode(obj.EndTalkH.ToString());
            XmlText endMText = xmlDocument.CreateTextNode(obj.EndTalkM.ToString());

            surnameAttr.AppendChild(surnameText);
            numberElem.AppendChild(numberText);
            yearElem.AppendChild(yeartext);
            monthElem.AppendChild(monthText);
            dayElem.AppendChild(dayText);
            tariffElem.AppendChild(tariffText);
            discountElem.AppendChild(discountText);
            startHElem.AppendChild(startHText);
            startMElem.AppendChild(startMText);
            endHElem.AppendChild(endHText);
            endMElem.AppendChild(endMText);

            paymentsElem.Attributes.Append(surnameAttr);
            paymentsElem.AppendChild(numberElem);
            paymentsElem.AppendChild(yearElem);
            paymentsElem.AppendChild(monthElem);
            paymentsElem.AppendChild(dayElem);
            paymentsElem.AppendChild(tariffElem);
            paymentsElem.AppendChild(discountElem);
            paymentsElem.AppendChild(startHElem);
            paymentsElem.AppendChild(startMElem);
            paymentsElem.AppendChild(endHElem);
            paymentsElem.AppendChild(endMElem);

            xRoot.AppendChild(paymentsElem);
            xmlDocument.Save("D:/payments.xml");
        }
        static void Main(string[] args)
        {
            XDocument xDoc = new XDocument(new XElement("payments"));
            xDoc.Save("D:/payments.xml");
            List<Payment> payments = new List<Payment>(20);
            payments.Add(new Payment("Маковский", "+375447702390", 1990, 5, 8, 60, 10, 15, 5, 15, 10));
            payments.Add(new Payment("Чириков", "+375449842286", 1991, 6, 20, 10, 1, 20, 6, 21, 8));
            payments.Add(new Payment("Маковский", "+375257702390", 1990, 5, 8, 60, 11, 16, 8, 16, 10));
            payments.Add(new Payment("Деменков", "+375332698512", 2001, 11, 5, 15, 15, 15, 15, 16, 16));
            payments.Add(new Payment("Матвеевский", "+375253692584", 2002, 5, 5, 5, 5, 5, 5, 6, 6));
            payments.Add(new Payment("Кудашев", "+375442281488", 2003, 10, 10, 30, 30, 10, 10, 11, 11));
            payments.Add(new Payment("Маковский", "+375257702390", 1990, 6, 9, 60, 10, 9, 9, 10, 10));
            payments.Add(new Payment("Старженский", "+375448850258", 2003, 4, 4, 60, 3, 4, 4, 5, 5));
            payments.Add(new Payment("Селиванов", "+375441234569", 2005, 9, 9, 60, 10, 8, 8, 9, 9));
            payments.Add(new Payment("Бунин", "+375251584589", 2006, 1, 1, 30, 1, 6, 8, 7, 8));
            payments.Add(new Payment("Штейн", "+375336984758", 1980, 6, 8, 80, 60, 17, 17, 18, 18));
            payments.Add(new Payment("Бушинский", "+375256981236", 2000, 10, 7, 50, 50, 1, 1, 2, 3));
            payments.Add(new Payment("Маковский", "+375447702390", 1990, 5, 8, 60, 10, 18, 18, 19, 19));
            payments.Add(new Payment("Селиванов", "+375441234569", 2006, 5, 9, 45, 45, 10, 15, 11, 20));
            payments.Add(new Payment("Щуленников", "+375331593578", 2015, 7, 25, 90, 10, 19, 48, 20, 9));
            payments.Add(new Payment("Бушинский", "+375256981236", 2000, 10, 7, 50, 50, 3, 3, 3, 5));
            payments.Add(new Payment("Зинченко", "+375447702385", 2018, 3, 3, 40, 5, 16, 15, 17, 15));
            payments.Add(new Payment("Ростовцев", "+375447702390", 2016, 5, 6, 30, 1, 6, 6, 8, 8));
            payments.Add(new Payment("Ростовцев", "+375447702390", 2016, 5, 6, 30, 1, 8, 9, 9, 9));
            payments.Add(new Payment("Щуленников", "+375331593578", 2015, 7, 25, 90, 10, 21, 5, 22, 10));
            foreach (var item in payments)
            {
                AddToXml(item);
            }
            string surname = "", phoneNumber = "";
            int talkDateY = 0, talkDateM = 0, talkDateD = 0, choose = 0, endTalkM = 0, endTalkH = 0, startTalkM = 0, startTalkH = 0, choose2 = 0;
            float tariff = 0, discount = 0;
            bool correctness = false, check = false;
            ShowInstruction();
            while (choose != 3)
            {
                while (!correctness)
                {
                    try
                    {
                        Console.Write("Ваш выбор: "); choose = int.Parse(Console.ReadLine());
                        switch (choose)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    Console.Write("Фамилия: "); surname = Console.ReadLine();
                                    Console.Write("Номер телефона формата +375(КК)ННННННН: "); phoneNumber = Console.ReadLine();
                                    Console.Write("Год разговора: "); talkDateY = int.Parse(Console.ReadLine());
                                    Console.Write("Месяц разговора: "); talkDateM = int.Parse(Console.ReadLine());
                                    Console.Write("День разговора: "); talkDateD = int.Parse(Console.ReadLine());
                                    Console.Write("Стоимость тарифа: "); tariff = float.Parse(Console.ReadLine());
                                    Console.Write("Личная скидка: "); discount = float.Parse(Console.ReadLine());
                                    Console.Write("Начало разговора (час): "); startTalkH = int.Parse(Console.ReadLine());
                                    Console.Write("Начало разговора (минуты): "); startTalkM = int.Parse(Console.ReadLine());
                                    Console.Write("Окончание разговора (час): "); endTalkH = int.Parse(Console.ReadLine());
                                    Console.Write("Окончание разговора (минуты): "); endTalkM = int.Parse(Console.ReadLine());
                                    check = CheckCorrectness(surname, phoneNumber, talkDateY, talkDateM, talkDateD, tariff, discount, startTalkH, startTalkM, endTalkH, endTalkM);
                                    if (check)
                                    {
                                        payments.Add(new Payment(surname, phoneNumber, talkDateY, talkDateM, talkDateD, tariff, discount, startTalkH, startTalkM, endTalkH, endTalkM));
                                        AddToXml(payments.Last());
                                        Console.WriteLine("Успешно добавлено!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверные данные! Попробуйте ещё раз.");
                                    }
                                    ShowInstruction();
                                    break;
                                }
                            case 2:
                                {
                                    ShowPayments(payments);
                                    break;
                                }
                            case 3:
                                {
                                    Console.Clear();
                                    ShowInstruction();
                                    break;
                                }
                            case 4:
                                {
                                    Console.Clear();
                                    Console.WriteLine("1. Одновременная сортировка по фамилии и дате разговора");
                                    Console.WriteLine("2. Вывести повторяющиеся имена телефонов");
                                    Console.WriteLine("3. Вывести разговоры по убыванию времени их длительности");
                                    Console.WriteLine("4. Вывести цену самого дорогого разговора с учётом скидки");
                                    Console.WriteLine("5. Выполнить группировку по каждому полю");
                                    Console.WriteLine("----------------------");
                                    while (choose2 != 6)
                                    {
                                        Console.Write("Ваш выбор: "); choose2 = int.Parse(Console.ReadLine());
                                        switch (choose2)
                                        {
                                            case 1:
                                                {
                                                    var sort1 = from payment
                                                                in payments
                                                                orderby payment.Surname, payment.TalkDateY, payment.TalkDateM, payment.TalkDateD descending
                                                                select payment;
                                                    foreach (var item in sort1)
                                                    {
                                                        Console.WriteLine($"\nФамилия: {item.Surname}");
                                                        Console.WriteLine($"Дата разговора: {item.TalkDateD}.{item.TalkDateM}.{item.TalkDateY}");
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    var duplNum = from payment in payments
                                                                  group payment by payment.PhoneNumber
                                                                  into g
                                                                  where g.Count() > 1
                                                                  select new { PhoneNumber = g.Key, Count = g.Count() };
                                                    foreach (var item in duplNum)
                                                    {
                                                        Console.WriteLine($"{item.PhoneNumber}: {item.Count}");
                                                    }
                                                    break;
                                                }
                                            case 3:
                                                {
                                                    var sort2 = from payment
                                                                in payments
                                                                orderby payment.TalkLength
                                                                select payment;
                                                    foreach (var item in sort2)
                                                    {
                                                        Console.WriteLine($"\nФамилия: {item.Surname}");
                                                        Console.WriteLine($"Длина разговора: {item.TalkLength}");
                                                    }
                                                    break;
                                                }
                                            case 4:
                                                {
                                                    float maxPrice = payments.Max(p => p.Total);
                                                    Console.WriteLine($"{maxPrice}");
                                                    break;
                                                }
                                            case 5:
                                                {
                                                    var g1 = from payment
                                                                     in payments
                                                             group payment by payment.Surname
                                                                     into g
                                                             select new { Surname = g.Key, Count = g.Count() };
                                                    var g2 = from payment
                                                             in payments
                                                             group payment by payment.Date
                                                             into g
                                                             select new { Date = g.Key, Count = g.Count() };
                                                    var g3 = from payment
                                                             in payments
                                                             group payment by payment.Tariff
                                                             into g
                                                             select new { Tariff = g.Key, Count = g.Count() };
                                                    XDocument xmlGroup1 = new XDocument(new XElement("group1", from g in g1 select new XElement("payments", new XElement("surname", g.Surname), new XElement("count", g.Count))));
                                                    XDocument xmlGroup2 = new XDocument(new XElement("group2", from g in g2 select new XElement("payments", new XElement("date", g.Date), new XElement("count", g.Count))));
                                                    XDocument xmlGroup3 = new XDocument(new XElement("group3", from g in g3 select new XElement("payments", new XElement("tariff", g.Tariff), new XElement("count", g.Count))));
                                                    xmlGroup1.Save("D:/xmlGroup1.xml");
                                                    xmlGroup2.Save("D:/xmlGroup2.xml");
                                                    xmlGroup3.Save("D:/xmlGroup3.xml");
                                                    break;
                                                }
                                            case 6:
                                                {
                                                    break;
                                                }
                                            default:
                                                {
                                                    Console.WriteLine("Неверный выбор!");
                                                    break;
                                                }
                                        }
                                    }
                                    break;
                                }
                            case 5:
                                {
                                    Environment.Exit(0);
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Неверный выбор!");
                                    break;
                                }
                        }
                    }
                    catch
                    {
                        Console.Clear();
                        Console.WriteLine("Неверные данные! Попробуйте снова");
                        ShowInstruction();
                        correctness = false;
                    }
                }
            }
        }
    }
}
public void CalcAverageMark()
{
    int sum = 0;
    foreach (var item in marks)
    {
        sum += item;
    }
    averageMark = sum / marks.Count;
}