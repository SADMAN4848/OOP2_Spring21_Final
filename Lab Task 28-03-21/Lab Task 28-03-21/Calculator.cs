using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_28_03_21
{
	public abstract class Calculator
	{
		private string companyName;
		private string name;
		private string model;

		public Calculator()
		{
		}
		public Calculator(string companyName, string name, string model)
		{
			this.companyName = companyName;
			this.name = name;
			this.model = model;
		}

		public void setCompanyName(string companyName)
		{
			this.companyName = companyName;
		}
		public string getCompanyName()
		{
			return companyName;
		}
		public void setName(string name)
		{
			this.name = name;
		}
		public string getName()
		{
			return name;
		}
		public void setModel(string model)
		{
			this.model = model;
		}
		public string getModel()
		{
			return model;
		}
		virtual public void showCalculationInfo()
		{
			Console.WriteLine("Company Name: " + companyName);
			Console.WriteLine("Name: " + name);
			Console.WriteLine("Model: " + model);
		}

	}
}
