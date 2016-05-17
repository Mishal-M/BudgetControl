using System;
using SQLite;

namespace BudgetControlService.Shared
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection ();
	}
}

