using System;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountLabel
		//:
		//IUnique
	{

#region Property

		/// <summary>
		/// The id of the account the label applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		int AccountId { get; }

		/// <summary>
		/// The label on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		ILabel Label { get; }

		/// <summary>
		/// The update timestamp of the label on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DateTime UpdateTimestamp { get; }

#endregion

	}

}
