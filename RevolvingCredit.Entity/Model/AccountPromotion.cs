using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Extend instance mapper base class.
	/// </remarks>
	public class AccountPromotion
		:
		InstanceMapperBase
		,
		IAccountPromotion
	{

#region Property

#region IAccountPromotion

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public DateTime Start { get; }

		/// <inheritdoc />
		public DateTime End { get; }

		/// <inheritdoc />
		IAPR IAccountPromotion.Type => Mapper.Map<IAPR>(Type);

		/// <inheritdoc />
		public double APR { get; }

#endregion

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		public APR Type { get; }

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
