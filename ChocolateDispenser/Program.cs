namespace ChocolateDispenser
{


    using System;
    using System.Collections;
    using System.Drawing;

    internal class Program
    {
        

        public static Queue<string> dispenser = new Queue<string>();
        public static void addChocolates(string color, int count)
        {
            for(int i = 0; i < count; i++)
            {
                Program.dispenser.Enqueue(color);
            }

        }

        public static string[] removeChocolates(int count)
        {
            string[] removedChocolates = new string[count];

          
            for (int i = 0; i < count; i++)
            {
                string choco = Program.dispenser.Dequeue();
                removedChocolates[i] = choco;
            }
            return removedChocolates;
        }

        public static string[] dispenseChocolates(int count)
        {
            string[] dispenseddChocolates = new string[count];


            for (int i = 0; i < count; i++)
            {
                string choco = Program.dispenser.Dequeue();
                dispenseddChocolates[i] = choco;
            }
            return dispenseddChocolates;
        }

        public static string[] dispenseChocolatesOfColor(string color, int count)
        {
            string[] dispensedChocolates = new string[count];
            int dispensedCount = 0;

            while ( dispensedCount < count )
            {
                string choco = Program.dispenser.Dequeue();

                if (choco == color)
                {
                   
                    dispensedChocolates[dispensedCount] = choco;
                    dispensedCount++;
                }
                

            }
            return dispensedChocolates;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an option");

                Console.WriteLine("1)Add chocoloates");
                Console.WriteLine("2)Remove chocoloates");
                Console.WriteLine("3)Dispense chocoloates");
                Console.WriteLine("4)Dispense chocoloates of color");

                int ans = Convert.ToInt32(Console.ReadLine());
                if (ans == 1)
                {
                    Console.WriteLine("Enter chocoloates color:");
                    string color = Console.ReadLine();

                    Console.WriteLine("Enter chocoloates count:");
                    int count = Convert.ToInt32(Console.ReadLine());
                    Program.addChocolates(color, count);

                }
            }
            
        }
    }
}