using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator c1 = new Casio("Casio", "fx", "991EX");
			Calculator c2 = new Citizen("Citizen", "CT", "23RT");


			c1.showCalculationInfo();

			c2.showCalculationInfo();
		}
	}
}
