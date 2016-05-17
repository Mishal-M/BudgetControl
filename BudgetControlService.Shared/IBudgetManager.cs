using System;
using System.Collections.Generic;

namespace BudgetControlService.Shared
{
	public interface IBudgetManager
	{
		IBudget Budget { get;}

		void AddOutgoing (IOutgoing outgoing);

		void RemoveOutgoing (string name);

		void AddIncome (IIncome income);

		void RemoveIncome(string name);

		void AddSavingTarget (ISavingTarget saving);

		void RemoveSavingTarget(string name);

		double SumTransactions (List<ITransaction> transactions);

		double Expendable { get; }
	}

	
}

