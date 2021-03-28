using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21
{
	public interface IBasicCalculatorInterface
	{
		int sum(int x, int y);
		int sub(int x, int y);
		int multiplication(int x, int y);
		int division(int x, int y);
	}
}
