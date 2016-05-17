using System;
using SQLite;
using Xamarin.Forms;

namespace BudgetControlService.Shared
{
	public class DbHelper:IDbHelper
	{
		private SQLiteConnection _db;
		static object locker = new object();

		public DbHelper ()
		{
			//_db = DependencyService.Get<ISQLite>.GetConnection ();
		}
				
	}
}

