using RevolvingCredit.Entity.Interface;
using System;

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
		//UniqueBase
		//,
		IAccountIssuer
	{

#region Property

#region IAccountIssuer

		/// <inheritdoc />
		public int AccountId { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		IIssuer IAccountIssuer.Issuer { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

		/// <summary>
		/// The issuer on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
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
