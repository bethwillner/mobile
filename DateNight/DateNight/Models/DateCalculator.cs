using System;
namespace DateNight.Models
{
	public class DateCalculator
	{
		public string CoffeeCost { get; set; }
		//get cost for coffee and set the coffee cost as that 
		public string DinnerCost { get; set; }
		public string MovieCost { get; set; }

		public string GetTotalCost()
		//get total cost returning string method

		{
			decimal decCoffee, decDinner, decMovie;
			//creating decimals for costs of stuff

			if(!Decimal.TryParse(CoffeeCost, out decCoffee))
			//is it passing or failing the tryparse
			{
				if(!string.IsNullOrEmpty(CoffeeCost))
				//if they typed in something besides leaving it empty or a num
				{
				throw new Exception("Invalid Coffee Cost");
				//if fail then give them a message
				}

			}

            if (!Decimal.TryParse(DinnerCost, out decDinner))
            {
                if (!string.IsNullOrEmpty(DinnerCost))
                {
                    throw new Exception("Invalid Dinner Cost");
                }
            }

            if (!Decimal.TryParse(MovieCost, out decMovie))
            {
                if (!string.IsNullOrEmpty(MovieCost))
                {
                    throw new Exception("Invalid Movie Cost");
                }
            }

            return (decCoffee + decDinner + decMovie).ToString("c");
			//return the added up total of the decimals into a string
		}
	}
}

