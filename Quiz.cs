using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Quiz
    {
        static int[] minIncomeArray = new int[]
            { 20000, 30000, 40000, 80000,
              120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[]
            { 0.02, 0.035, 0.07, 0.115,
              0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[]
            { 0, 200, 550, 3350,
              7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetTaxBracket(annualIncome);
            double taxPayable =
                CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }

        static int AskForIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            int income = Int32.Parse(Console.ReadLine());
            return income;
        }

        static void PrintResult(int annualIncome, double payableTaxAmount)
        {
            Console.WriteLine("For taxable annual income of {0:c}, the tax payable amount is ${1:#,##0.00}",
                annualIncome, payableTaxAmount);
        }

        static double CalculateIncomeTax(int annualIncome, int taxBracket)
        {
            double tax = 0;
            if (taxBracket == -1)
            {
                tax = 0;
            }
            else
            {
                tax = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket]
                    + basePayableAmountArray[taxBracket];
            }
            return tax;
        }

        static int GetTaxBracket(int annualIncome)
        {
            for (int i = minIncomeArray.Length - 1; i >= 0; i--)
            {
                if (annualIncome >= minIncomeArray[i])
                {
                    return i;
                }
            }
            //if we reached here, it means that annualIncome < minIncomeArray[0]
            return -1;
        }
    }
}
