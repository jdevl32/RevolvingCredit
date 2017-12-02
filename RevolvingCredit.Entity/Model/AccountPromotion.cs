using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Invert foreign key annotations.
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

#region EF - Foreign Key

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

#endregion

#region EF - Navigation

#region EF - Foreign Key

		/// <summary>
		/// The account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("AccountId")]
		public virtual Account Account { get; set; }

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[ForeignKey("TypeId")]
		public virtual APR Type { get; set; }

#endregion

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
