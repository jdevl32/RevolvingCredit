using AutoMapper;
using JDevl32.Mapper;
using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An issuer of a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-engineer using EF navigation properties.
	/// </remarks>
	public class AccountIssuer
		:
		InstanceMapperBase
		,
		IAccountIssuer
	{

#region Property

#region IAccountIssuer

#region EF - Primary Key

#region EF - Foreign Key

		/// <inheritdoc />
		public Guid AccountId { get; set; }

		/// <inheritdoc />
		public int IssuerId { get; set; }

#endregion

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; set; }

#endregion

#region EF - Navigation

		/// <inheritdoc />
		IAccount IAccountIssuer.Account => Mapper.Map<IAccount>(Account);

		/// <inheritdoc />
		IIssuer IAccountIssuer.Issuer => Mapper.Map<IIssuer>(Issuer);

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the issuer applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; }

		/// <summary>
		/// The issuer of the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Issuer Issuer { get; }

#endregion

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
