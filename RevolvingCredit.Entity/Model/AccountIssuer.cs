using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An issuer of a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Extend instance mapper base class.
	/// </remarks>
	public class AccountIssuer
		:
		InstanceMapperBase
		,
		IAccountIssuer
	{

#region Property

#region IAccountIssuer

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		IIssuer IAccountIssuer.Issuer => Mapper.Map<IIssuer>(Issuer);

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

		/// <summary>
		/// The issuer of the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		[Required]
		public Issuer Issuer { get; }

#endregion

#region Instance Initialization

#region InstanceMapperBase

		/// <inheritdoc />
		public AccountIssuer(IMapper mapper)
			:
			base(mapper)
		{
		}

#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
