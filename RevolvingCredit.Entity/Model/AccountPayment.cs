﻿using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A payment record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add (EF-required) setters.
	/// </remarks>
	public class AccountPayment
		:
		InstanceMapperBase
		,
		IAccountPayment
	{

#region Property

#region IAccountPayment

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public Guid AccountId { get; set; }

		/// <inheritdoc />
		public int TypeId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime Due { get; set; }

#endregion

		/// <inheritdoc />
		public double Amount { get; set; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountPayment.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

		/// <inheritdoc />
		IPayment IAccountPayment.Type
		{
			get => Mapper.Map<IPayment>(Type);
			set => Mapper.Map<Payment>(value);
		}

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the payment applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; set; }

		/// <summary>
		/// The payment (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Payment Type { get; set; }

#endregion

#endregion

#region Instance Initialization

		/// <inheritdoc />
		public AccountPayment(IMapper mapper)
			:
			base(mapper)
		{
		}

		// todo|jdevl32: implement ctors...

#endregion

	}

}
