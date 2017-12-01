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
	/// Add (EF-required) setters.
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
		IAccount IAccountIssuer.Account
		{
			get => Mapper.Map<IAccount>(Account);
			set => Mapper.Map<Account>(value);
		}

		/// <inheritdoc />
		IIssuer IAccountIssuer.Issuer
		{
			get => Mapper.Map<IIssuer>(Issuer);
			set => Mapper.Map<Issuer>(value);
		}

#endregion

#endregion

#region EF - Navigation

		/// <summary>
		/// The account the issuer applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Account Account { get; set; }

		/// <summary>
		/// The issuer of the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual Issuer Issuer { get; set; }

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
