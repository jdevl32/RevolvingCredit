using AutoMapper;
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

		/// <inheritdoc />
		IAccountPayment IAccountStatement.MinimumPayment => Mapper.Map<IAccountPayment>(MinimumPayment);

		/// <inheritdoc />
		public double StartBalance { get; }

		/// <inheritdoc />
		public double EndBalance { get; }

		/// <inheritdoc />
		IList<IAccountPayment> IAccountStatement.Payments => Mapper.Map<IList<IAccountPayment>>(Payments);

		/// <inheritdoc />
		public double Fee { get; }

		/// <inheritdoc />
		public double Interest { get; }

		/// <inheritdoc />
		IAccountAPR IAccountStatement.CashAPR => Mapper.Map<IAccountAPR>(CashAPR);

		/// <inheritdoc />
		IAccountAPR IAccountStatement.CreditAPR => Mapper.Map<IAccountAPR>(CreditAPR);

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
