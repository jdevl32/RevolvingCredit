using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A statement for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-engineer using EF navigation properties.
	/// </remarks>
	public class AccountStatement
		:
		InstanceMapperBase
		,
		IAccountStatement
	{

#region Property

#region IAccountStatement

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public int AccountId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime End { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime Start { get; }

		/// <inheritdoc />
		public double StartBalance { get; }

		/// <inheritdoc />
		public double EndBalance { get; }

		/// <inheritdoc />
		public double Fee { get; }

		/// <inheritdoc />
		public double Interest { get; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountStatement.Account => Mapper.Map<IAccount>(Account);

#endregion

		/// <inheritdoc />
		IAccountPayment IAccountStatement.MinimumPayment => Mapper.Map<IAccountPayment>(MinimumPayment);

		/// <inheritdoc />
		IList<IAccountPayment> IAccountStatement.Payments => Mapper.Map<IList<IAccountPayment>>(Payments);

		/// <inheritdoc />
		IAccountAPR IAccountStatement.CashAPR => Mapper.Map<IAccountAPR>(CashAPR);

		/// <inheritdoc />
		IAccountAPR IAccountStatement.CreditAPR => Mapper.Map<IAccountAPR>(CreditAPR);

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the statement applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

#endregion

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The minimum payment for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		public AccountPayment MinimumPayment { get; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The payments applied during the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		public IList<AccountPayment> Payments { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the cash allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		public AccountAPR CashAPR { get; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the credit allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[NotMapped]
		public AccountAPR CreditAPR { get; }

#endregion

#region Instance Initialization

#region InstanceMapperBase

		/// <inheritdoc />
		public AccountStatement(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
