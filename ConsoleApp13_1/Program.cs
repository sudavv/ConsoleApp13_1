using System;

namespace ConsoleApp3_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.Write("Введите адрес ");
            string address = Console.ReadLine();
            int lenght = 0, width = 0, height = 0, floor = 0;
            try
            {
                Console.Write("Введите длину здания ");
                lenght = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите ширину здания ");
                width = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите высоту здания ");
                height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество этажей ");
                floor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }
            catch
            {
                Console.Write("Не число");
                Console.ReadLine();
                Run();
                Environment.Exit(0);
            }

            Building building = new Building(address, lenght, width, height);
            
            building.Print();

            MultiBuilding multiBuilding = new MultiBuilding(address, lenght, width, height, floor);
            multiBuilding.Print();

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        public class Building
        {
            public string address { get; set; }
            public int lenght { get; set; }
            public int width { get; set; }
            public int height { get; set; }

            public Building(string address, int lenght, int width, int height)
            {
                this.address = address;
                this.lenght = lenght;
                this.width = width;
                this.height = height;
            }

            public void Print()
            {
                Console.WriteLine("Адрес здания: {0} \nДлина здания: {1} \nШирина здания: {2} \nВысота здания: {3}", address, lenght, width, height);
                Console.WriteLine();
            }
        }

        sealed class MultiBuilding:Building
        {            
            public int floor { get; set; }

            public MultiBuilding(string address, int lenght, int width, int height, int floor)
                : base(address, lenght, width, height)
            {
                this.floor = floor;
            }

            new public void Print()
            {
                Console.WriteLine("Адрес здания: {0} \nДлина здания: {1} \nШирина здания: {2} \nВысота здания: {3} \nЭтажность здания: {4}", address, lenght, width, height, floor);
            }
        }
    }
}