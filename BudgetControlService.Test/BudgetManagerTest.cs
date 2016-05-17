using System;
using NUnit.Framework;
using BudgetControlService.Shared;
using System.Linq;

namespace BudgetControlService.Test
{
	[TestFixture]
	public class BudgetManagerTest
	{
		private IBudgetManager _budgetMgr;
		private IBudget _budget;

		[SetUp]
		public void Init()
		{
			_budgetMgr = new BudgetManager ();
			_budget = _budgetMgr.Budget;
		}

		[Test]
		public void ShouldAddOutgoing()
		{
			var outgoing = CreateOutgoing ();

			_budgetMgr.AddOutgoing (outgoing);

			Assert.That (_budget.Outgoings.Count == 1);
			Assert.That (_budget.Outgoings.First ().Name == "Rent");
		}

		[Test]
		public void ShouldDeleteOutgoing()
		{
			//Add an expense before we can delete it.
			ShouldAddOutgoing ();

			_budgetMgr.RemoveOutgoing ("Rent");
			Assert.That (_budget.Outgoings.Count == 0);
			Assert.IsNull (_budget.Outgoings.FirstOrDefault (x => x.Name == "Name"));
		}

		[Test]
		public void ShouldAddIncome()
		{
			var income = CreateIncome ();
			_budgetMgr.AddIncome (income);

			Assert.That (_budget.Incomes.Count == 1);
			Assert.IsNotNull (_budget.Incomes.First (x => x.Name == "Salary"));
		}

		[Test]
		public void ShouldDeleteIncome()
		{
			ShouldAddIncome ();

			_budgetMgr.RemoveIncome ("Salary");

			Assert.That (_budget.Incomes.Count == 0);
			Assert.IsNull (_budget.Incomes.FirstOrDefault (x => x.Name == "Salary"));
		}

		[Test]
		public void ShouldAddSavingTarget()
		{
			var savingT = CreateSavingTarget ();

			_budgetMgr.AddSavingTarget (savingT);
			Assert.That (_budget.SavingTargets.Count == 1);
			Assert.IsNotNull (_budget.SavingTargets.FirstOrDefault (x => x.Name == "MyISA"));
		}

		[Test]
		public void ShouldDeleteSavingTarget()
		{
			ShouldAddSavingTarget ();

			_budgetMgr.RemoveSavingTarget ("MyISA");
			Assert.That (_budget.SavingTargets.Count == 0);
			Assert.IsNull (_budget.SavingTargets.FirstOrDefault (x => x.Name == "MyISA"));
		}

		[Test]
		public void ShouldCalculateExpendable()
		{
			ShouldAddIncome ();
			ShouldAddOutgoing ();
			ShouldAddSavingTarget ();

			var expendable = _budgetMgr.Expendable;

			Assert.That (expendable == 800);
		}

		private IOutgoing CreateOutgoing ()
		{
			var outgoing = new Outgoing {
				Amount = 100,
				Category = OutgoingCategory.Rent,
				Description = "Some Description",
				Name = "Rent"
			};

			return outgoing;
		}

		private IIncome CreateIncome()
		{
			var income = new Income {
				Amount = 1000,
				Category = IncomeCategory.Salary,
				Name = "Salary"
			};

			return income;				 
		}

		private ISavingTarget CreateSavingTarget()
		{
			var savingT = new SavingTarget {
				Amount = 100,
				Category = SavingCategory.ISA,
				Name = "MyISA"
			};

			return savingT;
		}
	}
}

