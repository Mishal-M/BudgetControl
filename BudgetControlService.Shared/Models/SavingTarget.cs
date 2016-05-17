using System;

namespace BudgetControlService.Shared
{
	public class SavingTarget:ISavingTarget
	{

		#region ISavingTarget implementation

		public SavingCategory Category {
			get;
			set;
		}

		#endregion

		#region ITransaction implementation

		public string Name {
			get ;
			set ;
		}

		public string Description {
			get ;
			set ;
		}

		public double Amount {
			get ;
			set ;
		}

		#endregion
	}
}

