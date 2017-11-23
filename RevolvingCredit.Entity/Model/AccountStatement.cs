using RevolvingCredit.Entity.Interface;
using System;
using System.Collections.Generic;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A statement for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountStatement
		:
		IAccountStatement
	{

#region Property

#region IAccountStatement

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public DateTime Start { get; }

		/// <inheritdoc />
		public DateTime End { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		IAccountPayment IAccountStatement.MinimumPayment { get; }

		/// <inheritdoc />
		public double StartBalance { get; }

		/// <inheritdoc />
		public double EndBalance { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		IList<IAccountPayment> IAccountStatement.Payments { get; }

		/// <inheritdoc />
		public double Fee { get; }

		/// <inheritdoc />
		public double Interest { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		IAccountAPR IAccountStatement.CashAPR { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		IAccountAPR IAccountStatement.CreditAPR { get; }

#endregion

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The minimum payment for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountPayment MinimumPayment { get; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The payments applied during the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public IList<AccountPayment> Payments { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the cash allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountAPR CashAPR { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the credit allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public AccountAPR CreditAPR { get; }

#endregion

#region Instance Initialization

		// todo|jdevl32: implement ctors...

#endregion

	}

}
