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
	/// </remarks>
	public interface IAccountStatement
	{

#region Property

		/// <summary>
		/// The id of the account the statement applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		int AccountId { get; }

		/// <summary>
		/// The start timestamp of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime Start { get; }

		/// <summary>
		/// The end timestamp of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		DateTime End { get; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The minimum payment for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		IAccountPayment MinimumPayment { get; }

		/// <summary>
		/// The starting balance of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		double StartBalance { get; }

		/// <summary>
		/// The ending balance of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		double EndBalance { get; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The payments applied during the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		IList<IAccountPayment> Payments { get; }

		/// <summary>
		/// The fee reported for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double Fee { get; }

		/// <summary>
		/// The interest reported for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double Interest { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the cash allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		IAccountAPR CashAPR { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the credit allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		IAccountAPR CreditAPR { get; }

#endregion

	}
}