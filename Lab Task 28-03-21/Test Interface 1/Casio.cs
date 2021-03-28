using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21
{
	public class Casio : Calculator, IBasicCalculatorInterface, IScientificCalculatorInterface
	{

		public Casio(string companyName, string name, string model) : base(companyName, name, model)
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
		public int XtoY(int x, int y)
		{
			return x % y;
		}
		public int power(int x, int y)
		{
			return ((x ^ 3) + (y ^ 2));
		}
		override public void showCalculationInfo()
		{
			base.showCalculationInfo();
			Console.WriteLine("Sum: " + sum(7, 4));
			Console.WriteLine("Sub: " + sub(3, 9));
			Console.WriteLine("Multiplication: " + multiplication(4, 6));
			Console.WriteLine("Division: " + division(6, 2));
			Console.WriteLine("X to Y: " + XtoY(4, 4));
			Console.WriteLine("Power: " + power(2, 2));
		}
	}
}
