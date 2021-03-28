using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21
{
	public class Citizen : Calculator, IBasicCalculatorInterface
	{
		public Citizen()
		{
		}
		public Citizen(string companyName, string name, string model) : base(companyName, name, model)
		{

		}
		public int sum(int x, int y)
		{
			return x + y;
		}
		public int sub(int x, int y)
		{
			return y - x;
		}
		public int multiplication(int x, int y)
		{
			return x * y;
		}
		public int division(int x, int y)
		{
			return y / x;
		}

		override public void showCalculationInfo()
		{
			base.showCalculationInfo();
			Console.WriteLine("Sum: " + sum(5, 5));
			Console.WriteLine("Sub: " + sub(4, 6));
			Console.WriteLine("Multiplication: " + multiplication(5, 6));
			Console.WriteLine("Division: " + division(18, 3));
		}
	}
}