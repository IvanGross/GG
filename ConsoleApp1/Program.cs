using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WorkShop
    {
        private string name;
        public string Name { get; set; }
        private string head;
        public string Head { get; set; }
        private int number;
        public int Number { get; set; }
        public WorkShop()
        {
            Name = "Производство молока";
            Head = "Федоров Иван Васильевич";
            Number = 50;
        }

        public WorkShop(string _Name, string _Head, int _Number)
        {
            Name = _Name;
            Head = _Head;
            Number = 50;
        }

        public void Fill()
        {
            Console.WriteLine("Введите данные");
            Name = Console.ReadLine();
            Head = Console.ReadLine();
            Number = Convert.ToInt32(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Название цеха: {Name}, Начальник цеха: {Head}, Количество работающих: {Number}");
        }

        class program
        {
            static void Main(string[] args)
            {
                WorkShop myWorkShop = new WorkShop();
                myWorkShop.Fill();
                myWorkShop.Print();
                Console.ReadKey();
            }
        }
    }
}
