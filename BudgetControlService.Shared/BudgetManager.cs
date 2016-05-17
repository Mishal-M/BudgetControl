using System;
using System.Collections.Generic;
using System.Linq;

namespace BudgetControlService.Shared
{
	public class BudgetManager:IBudgetManager
	{
		private IBudget _budget;

		public IBudget Budget {
			get{ return _budget; }
		}

		public BudgetManager ()
		{
			if (_budget == null) {
				_budget = new Budget ();
			}
		}

		public void AddOutgoing(IOutgoing outgoing)
		{
			if (_budget.Outgoings != null) 
			{
				_budget.Outgoings.Add (outgoing);
			}
		}

		public void RemoveOutgoing(string name)
		{
			if (_budget.Outgoings != null) {
				_budget.Outgoings.RemoveAll (x => x.Name == name);
			}
		}

		public void AddIncome(IIncome incoming)
		{
			if (_budget.Incomes != null) {
				_budget.Incomes.Add (incoming);
			}
		}

		public void RemoveIncome(string name)
		{
			if (_budget.Incomes != null) {
				_budget.Incomes.RemoveAll (x => x.Name == name);
			}
		}

		public void AddSavingTarget(ISavingTarget saving)
		{
			if (_budget.SavingTargets != null) {
				_budget.SavingTargets.Add (saving);
			}
		}

		public void RemoveSavingTarget(string name)
		{
			if (_budget.SavingTargets != null) {
				_budget.SavingTargets.RemoveAll (x => x.Name == name);
			}
		}

		public double SumTransactions(List<ITransaction> transactions)
		{
			double sum = 0;
			transactions.ForEach (x => sum = sum + x.Amount);

			return sum;
		}

		public double Expendable {
			get{return CalculateExpendable ();}
		}

		private double CalculateExpendable()
		{
			var totalIncome = SumTransactions (_budget.Incomes.Select(x => x as ITransaction).ToList());
			var totalOutgoings = SumTransactions (_budget.Outgoings.Select(x => x as ITransaction).ToList());
			var totalSavingTs = SumTransactions (_budget.SavingTargets.Select(x => x as ITransaction).ToList());

			return (totalIncome - (totalOutgoings + totalSavingTs));
		}

	}
	
}

