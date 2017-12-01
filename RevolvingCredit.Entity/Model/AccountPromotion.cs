using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add (EF-required) setters.
	/// </remarks>
	public class AccountPromotion
		:
		InstanceMapperBase
		,
		IAccountPromotion
	{

#region Property

#region IAccountPromotion

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public Guid AccountId { get; set; }

		/// <inheritdoc />
		public int TypeId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime Start { get; set; }

		/// <inheritdoc />
		public DateTime End { get; set; }

#endregion

		/// <inheritdoc />
		public double APR { get; set; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountPromotion.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

		/// <inheritdoc />
		IAPR IAccountPromotion.Type
		{
			get => Mapper.Map<IAPR>(Type);
			set => Mapper.Map<APR>(value);
		}

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; set; }

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual APR Type { get; set; }

#endregion

#endregion

#region Instance Initialization

#region InstanceMapperBase

		/// <inheritdoc />
		public AccountPromotion(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
