using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//coffey.niall.com
//Task
//Given the meal price(base cost of a meal), 
//tip percent(the percentage of the meal price being added as tip), 
//and tax percent(the percentage of the meal price being added as tax)
//    for a meal, find and print the meal's total cost.

//Input Format

//The first line has a double,  (the cost of the meal before tax and tip). 
//The second line has an integer,  (the percentage of  being added as tip). 
//The third line has an integer,  (the percentage of  being added as tax).

//Output Format

//Print The total meal cost is totalCost dollars.,
//where  totalcost is the rounded integer result of the entire bill
//( mealcost with added tax and tip).

//Sample Input
//12.00 mealcost
//20    tip
//8     tax
//Sample Output
//The total meal cost is 15 dollars.
namespace Day2Operators
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double mealCost = 10.25;
            int tip = 17;
            int tax = 5;
            
            double mealCostTax = ((mealCost/100) * tax) + mealCost;
            Console.WriteLine(mealCostTax);
            double mealCostTaxTip = ((mealCost/100)*tip) + mealCostTax;
            int iMealCostTaxTip = (int)Math.Round(mealCostTaxTip);
            Console.WriteLine(mealCostTaxTip);
            Console.WriteLine(iMealCostTaxTip);
            Console.ReadLine( );
            
           

        }
    }
}
