using System;
using System.Collections.Generic;

namespace BudgetControlService.Shared
{
	public interface ISavingTarget:ITransaction
	{
		SavingCategory Category { get; set; }
	}

}

