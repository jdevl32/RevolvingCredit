using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Extend instance mapper base class.
	/// </remarks>
	public class AccountLabel
		:
		InstanceMapperBase
		,
		IAccountLabel
	{

#region Property

#region IAccountLabel

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		ILabel IAccountLabel.Label => Mapper.Map<ILabel>(Label);

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

		/// <summary>
		/// The label for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		public Label Label { get; }

#endregion

#region Instance Initialization

#region InstanceMapperBase

		/// <inheritdoc />
		public AccountLabel(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
