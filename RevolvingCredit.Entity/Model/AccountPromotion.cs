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
	/// Re-engineer using EF navigation properties.
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
		public int AccountId { get; set; }

		/// <inheritdoc />
		public int TypeId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime Start { get; set; }

		/// <inheritdoc />
		public DateTime End { get; set; }

#endregion

		/// <inheritdoc />
		public double APR { get; }

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountPromotion.Account => Mapper.Map<IAccount>(Account);

		/// <inheritdoc />
		IAPR IAccountPromotion.Type => Mapper.Map<IAPR>(Type);

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual APR Type { get; }

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
