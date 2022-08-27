namespace LogicalProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.Perfect No");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.print();
                        break;
                    case 2:
                        PerfectNo perfectNo = new PerfectNo();
                        perfectNo.Perfect();
                        break;
                }
            }

        }
    }
}