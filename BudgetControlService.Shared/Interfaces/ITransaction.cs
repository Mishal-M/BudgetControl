using System;

namespace BudgetControlService.Shared
{
	public interface ITransaction
	{
		String Name { get; set; }
		String Description { get; set;}
		double Amount { get; set; }
	}
}

