using JDevl32.Entity.Interface;
using Microsoft.EntityFrameworkCore;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// The revolving credit database context.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IRevolvingCreditContext
		:
		IEntityContext
	{

#region Property

		/// <summary>
		/// The account table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccount> Account { get; set; }

		/// <summary>
		/// The account APR table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountAPR> AccountAPR { get; set; }

		/// <summary>
		/// The account issuer table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountIssuer> AccountIssuer { get; set; }

		/// <summary>
		/// The account table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountLabel> AccountLabel { get; set; }

		/// <summary>
		/// The account line table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountLine> AccountLine { get; set; }

		/// <summary>
		/// The account note table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountNote> AccountNote { get; set; }

		/// <summary>
		/// The account payment table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountPayment> AccountPayment { get; set; }

		/// <summary>
		/// The account promotion table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountPromotion> AccountPromotion { get; set; }

		/// <summary>
		/// The account statement table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAccountStatement> AccountStatement { get; set; }

		/// <summary>
		/// The APR (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IAPR> APR { get; set; }

		/// <summary>
		/// The issuer (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IIssuer> Issuer { get; set; }

		/// <summary>
		/// The label (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<ILabel> Label { get; set; }

		/// <summary>
		/// The line (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<ILine> Line { get; set; }

		/// <summary>
		/// The payment (type) table.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DbSet<IPayment> Payment { get; set; }

#endregion

	}

}
