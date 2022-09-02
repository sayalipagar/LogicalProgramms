﻿namespace LogicalProgramms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nselect Program\n 1.FibonacciSeries\n 2.Perfect No\n 3.Prime No\n 4.Reverse No\n 5.Temprature Conversion\n 6.Monthly Payment\n 7.Stop Watch\n 8.Day Of Week\n 9.Coupon No");
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
                    case 6:
                        MonthlyPayment monthlyPayment = new MonthlyPayment();
                        monthlyPayment.Payment();
                        break;
                    case 7:
                        StopWatch stopWatch = new StopWatch();
                        stopWatch.calElapsedTime();
                        break;
                    case 8:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.CalDay();
                        break;
                    case 9:
                        CoupenNo coupen = new CoupenNo();
                        coupen.DistCouponNumber();
                        break;
                }
            }

        }
    }
}