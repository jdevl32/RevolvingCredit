using AutoMapper;
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
	/// </remarks>
	public class AccountIssuer
		:
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

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountIssuer(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountIssuer(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountIssuer(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
