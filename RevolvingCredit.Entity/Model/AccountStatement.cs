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
	/// Remove not-mapped annotation (on EF navigation properties).
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
		public Guid AccountId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime End { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime Start { get; set; }

		/// <inheritdoc />
		public double StartBalance { get; set; }

		/// <inheritdoc />
		public double EndBalance { get; set; }

		/// <inheritdoc />
		public double Fee { get; set; }

		/// <inheritdoc />
		public double Interest { get; set; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountStatement.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

		/// <inheritdoc />
		IAccountPayment IAccountStatement.MinimumPayment
		{
			get => Mapper.Map<IAccountPayment>(MinimumPayment);
			set => Mapper.Map<AccountPayment>(value);
		}

		/// <inheritdoc />
		IList<IAccountPayment> IAccountStatement.Payments
		{
			get => Mapper.Map<IList<IAccountPayment>>(Payments);
			set => Mapper.Map<AccountPayment>(value);
		}

		/// <inheritdoc />
		IAccountAPR IAccountStatement.CashAPR
		{
			get => Mapper.Map<IAccountAPR>(CashAPR);
			set => Mapper.Map<AccountAPR>(value);
		}

		/// <inheritdoc />
		IAccountAPR IAccountStatement.CreditAPR
		{
			get => Mapper.Map<IAccountAPR>(CreditAPR);
			set => Mapper.Map<AccountAPR>(value);
		}

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the statement applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; set; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The minimum payment for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		public virtual AccountPayment MinimumPayment { get; set; }

		// todo|jdevl32: shouldn't this come from account-payment ???
		/// <summary>
		/// The payments applied during the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		public virtual IList<AccountPayment> Payments { get; set; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the cash allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		public virtual AccountAPR CashAPR { get; set; }

		// todo|jdevl32: shouldn't this come from account-apr ???
		/// <summary>
		/// The APR of the credit allowance for the statement.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		//[NotMapped]
		public virtual AccountAPR CreditAPR { get; set; }

#endregion

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
