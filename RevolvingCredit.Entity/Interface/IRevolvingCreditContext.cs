using JDevl32.Entity.Interface;
using Microsoft.EntityFrameworkCore;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// The revolving credit database context.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-implement entity context interface as generic.
	/// Change db-set types from interface to class.
	/// </remarks>
	public interface IRevolvingCreditContext
		:
		IEntityContext<IRevolvingCreditContext>
	{

#region Property

		/// <summary>
		/// The account table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<Account> Account { get; set; }

		/// <summary>
		/// The account APR table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountAPR> AccountAPR { get; set; }

		/// <summary>
		/// The account issuer table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountIssuer> AccountIssuer { get; set; }

		/// <summary>
		/// The account table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountLabel> AccountLabel { get; set; }

		/// <summary>
		/// The account line table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountLine> AccountLine { get; set; }

		/// <summary>
		/// The account note table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountNote> AccountNote { get; set; }

		/// <summary>
		/// The account payment table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountPayment> AccountPayment { get; set; }

		/// <summary>
		/// The account promotion table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountPromotion> AccountPromotion { get; set; }

		/// <summary>
		/// The account statement table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<AccountStatement> AccountStatement { get; set; }

		/// <summary>
		/// The APR (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<APR> APR { get; set; }

		/// <summary>
		/// The issuer (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<Issuer> Issuer { get; set; }

		/// <summary>
		/// The label (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<Label> Label { get; set; }

		/// <summary>
		/// The line (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<Line> Line { get; set; }

		/// <summary>
		/// The payment (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<Payment> Payment { get; set; }

#endregion

	}

}
