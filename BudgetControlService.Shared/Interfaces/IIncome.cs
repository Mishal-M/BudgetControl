using System;
using System.Collections.Generic;

namespace BudgetControlService.Shared
{

	public interface IIncome:ITransaction
	{
		IncomeCategory Category { get; set; }
	}

}
