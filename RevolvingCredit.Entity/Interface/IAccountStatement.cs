using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A statement for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-implement account statement balance(s).
	/// </remarks>
	public interface IAccountStatement
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the statement applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Modify foreign key annotation.
		/// </remarks>
		[ForeignKey("Account, EndBalance, StartBalance")]
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The end timestamp of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add foreign key annotation.
		/// </remarks>
		[ForeignKey("EndBalance")]
		[Required]
		DateTime End { get; set; }

#endregion

#endregion

		/// <summary>
		/// The start timestamp of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add foreign key annotation.
		/// </remarks>
		[ForeignKey("StartBalance")]
		[Required]
		DateTime Start { get; set; }

		/// <summary>
		/// The starting balance (amount) of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Rename.
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		[Required]
		double StartBalanceAmount { get; set; }

		/// <summary>
		/// The ending balance (amount) of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Rename.
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		[Required]
		double EndBalanceAmount { get; set; }

		/// <summary>
		/// The fee reported for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double Fee { get; set; }

		/// <summary>
		/// The interest reported for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double Interest { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the statement applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; set; }

		/// <summary>
		/// The ending balance of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccountBalance EndBalance { get; set; }

		/// <summary>
		/// The starting balance of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccountBalance StartBalance { get; set; }

#endregion

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The minimum payment for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		IAccountPayment MinimumPayment { get; set; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The payments applied during the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		IList<IAccountPayment> Payments { get; set; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the cash allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		IAccountAPR CashAPR { get; set; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the credit allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add not-mapped annotation.
		/// </remarks>
		[NotMapped]
		IAccountAPR CreditAPR { get; set; }

#endregion

	}

}
