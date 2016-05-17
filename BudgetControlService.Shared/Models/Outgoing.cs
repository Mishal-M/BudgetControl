using System;

namespace BudgetControlService.Shared
{
	public class Outgoing:IOutgoing
	{
		#region IOutgoing implementation

		public OutgoingCategory Category { get; set; }

		#endregion

		#region ITransaction implementation

		public string Name { get; set; }

		public string Description { get; set; }

		public double Amount { get; set; }

		#endregion

		public override string ToString ()
		{
			return string.Format ("Name:{0} Amount:{1}", Name, Amount);
		}
	}
}

