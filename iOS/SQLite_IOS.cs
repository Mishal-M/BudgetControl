using System;
using BudgetControlService.Shared;
using System.IO;

//[assembly:Xamarin.Forms.Dependency(typeof())]
namespace BudgetControl.App.iOS
{
	public class SQLite_IOS:ISQLite
	{
		public SQLite_IOS ()
		{
		}

		#region ISQLite implementation

		public SQLite.SQLiteConnection GetConnection ()
		{
			var path = "/Users/Mishal/Data/BudgetControl.db";
			File.Open (path, FileMode.OpenOrCreate);

			var connection = new SQLite.SQLiteConnection (path);
			return connection;
		}

		#endregion
	}
}

