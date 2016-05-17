using System;
using BudgetControlService.Shared;
using System.Collections.ObjectModel;
using System.Linq;

namespace BudgetControl.App
{
	public class BudgetViewModel
	{
		private IBudgetManager _budgetManager;
		private IBudget _budget;

		public BudgetViewModel ()
		{
			_budgetManager = new BudgetManager ();
			_budget = _budgetManager.Budget;
		}

		public string Name {
			get{
				return _budget.Name;
			}
		}

		public ObservableCollection<string> Incomes {
			get{
				var incomes = _budget.Incomes.Select (i => i.ToString ());
				return new ObservableCollection<string> (incomes);
			}
		}
			
	}
}

