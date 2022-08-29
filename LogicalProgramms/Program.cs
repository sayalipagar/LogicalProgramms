namespace LogicalProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.Perfect No\n 3.Prime No\n 4.Reverse No\n 5.Temprature Conversion");
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
                    case 3:
                        PrimeNo primeNo = new PrimeNo();
                        primeNo.PrimeCheck();
                        break;
                    case 4:
                        ReverseNo reverseNo = new ReverseNo();
                        reverseNo.NumberCheck();
                        break;
                    case 5:
                        TempConversion tempConversion = new TempConversion();
                        tempConversion.Conversion();
                        break;
                }
            }

        }
    }
}