using System;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// An issuer of a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountIssuer
	{

#region Property

		/// <summary>
		/// The id of the account the issuer applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		int AccountId { get; }

		/// <summary>
		/// The issuer on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IIssuer Issuer { get; }

		/// <summary>
		/// The update timestamp of the issuer on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DateTime UpdateTimestamp { get; }

#endregion

	}

}
