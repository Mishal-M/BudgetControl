using System;
using System.Collections.Generic;

namespace BudgetControlService.Shared
{

	public interface IOutgoing:ITransaction
	{
		OutgoingCategory Category { get; set; }
	}

}
