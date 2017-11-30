using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A statement for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-engineer using EF navigation properties.
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
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		Guid AccountId { get; set; }

#endregion

		/// <summary>
		/// The end timestamp of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		DateTime End { get; set; }

#endregion

		/// <summary>
		/// The start timestamp of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		DateTime Start { get; set; }

		/// <summary>
		/// The starting balance of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		double StartBalance { get; set; }

		/// <summary>
		/// The ending balance of the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		double EndBalance { get; set; }

		/// <summary>
		/// The fee reported for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		double Fee { get; set; }

		/// <summary>
		/// The interest reported for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		double Interest { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the statement applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The minimum payment for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		IAccountPayment MinimumPayment { get; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The payments applied during the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		IList<IAccountPayment> Payments { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the cash allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		IAccountAPR CashAPR { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the credit allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		IAccountAPR CreditAPR { get; }

#endregion

#endregion

	}

}
