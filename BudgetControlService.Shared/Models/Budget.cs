using System;
using System.Collections.Generic;

namespace BudgetControlService.Shared
{
	public class Budget:IBudget
	{
		public Budget()
		{
			Incomes = new List<IIncome> ();
			Outgoings = new List<IOutgoing> ();
			SavingTargets = new List<ISavingTarget> ();
		}

		public string Name { get; set; }

		public string Description { get; set; }

		public List<IIncome> Incomes {
			get;
			set;
		}

		public List<IOutgoing> Outgoings {
			get;
			set; 
		}

		public List<ISavingTarget> SavingTargets {
			get;
			set;
		}
			

		public override string ToString ()
		{
			return string.Format ("Name:{0}", Name);
		}
			
	}
}

