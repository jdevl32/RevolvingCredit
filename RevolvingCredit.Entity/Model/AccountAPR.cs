using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An APR for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Extend instance mapper base class.
	/// </remarks>
	public class AccountAPR
		:
		InstanceMapperBase
		,
		IAccountAPR
	{

#region Property

#region IAccountAPR

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

		/// <inheritdoc />
		IAPR IAccountAPR.Type => Mapper.Map<IAPR>(Type);

		/// <inheritdoc />
		public double APR { get; }

#endregion

		/// <summary>
		/// The APR (type).
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
		public AccountAPR(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
