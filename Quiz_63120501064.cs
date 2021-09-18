using System;

namespace QuizTest_63120501064
{
    class Program
    {
        static void Main(string[] args)
        {
            InputRose();
            Roseinfo();

            Console.WriteLine(" ");
            Console.WriteLine(" ");

            InputSunflower();
            Sunflowerinfo();

        }
        static void InputRose()
        {
            Console.Write("Input Total Rose:");
            int TotalRose = int.Parse(Console.ReadLine());
        }
        static void InputSunflower()
        {
            Console.Write("Input Total Sunflower:");
            int TotalSunflower = int.Parse(Console.ReadLine());
        }
        static void Roseinfo()
        {
            //Rose = new Rose(1,"ดอกกุหลาบสีขาว","สวยงามมาก","2","10.5","6");//
            Console.WriteLine("Input Rose");
            Console.Write("ID:");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Plant Name:");
            string Name = Console.ReadLine();
            Console.Write("Plant Description:");
            string Description = Console.ReadLine();
            Console.Write("Amount:");
            int Amount = int.Parse(Console.ReadLine());
            Console.Write("Height:");
            string Height = Console.ReadLine();
            Console.Write("Circumference:");
            string Circumference = Console.ReadLine();
        }
        static void Sunflowerinfo()
        {
            //Sunflower = new Sunflower(1, "ดอกทานตะวันเล็ก","สวยงามมาก",1,"2.0","2.0);//
            Console.WriteLine("Input Sunflower");
            Console.Write("ID:");
            int ID = int.Parse(Console.ReadLine());
            Console.Write("Plant Name:");
            string Name = Console.ReadLine();
            Console.Write("Plant Description:");
            string Description = Console.ReadLine();
            Console.Write("Amount:");
            int Amount = int.Parse(Console.ReadLine());
            Console.Write("Height:");
            string Height = Console.ReadLine();
            Console.Write("Circumference:");
            string Circumference = Console.ReadLine();
        }
    }
}
