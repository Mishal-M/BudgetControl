using System;
using System.Collections.Generic;

namespace BudgetControlService.Shared
{
	public interface IBudget
	{
		string Name { get; set;}

		string Description { get; set; }
		
		List<IIncome> Incomes { get; set;}

		List<IOutgoing> Outgoings { get; set;}

		List<ISavingTarget> SavingTargets { get; set; }
	}
		
}

