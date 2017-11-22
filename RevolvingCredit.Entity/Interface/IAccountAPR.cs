using System;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountAPR
		//:
		//IUnique
	{

#region Property

		/// <summary>
		/// The id of the account the APR applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		int AccountId { get; }

		/// <summary>
		/// The update timestamp of the APR for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DateTime UpdateTimestamp { get; }

		/// <summary>
		/// The APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAPR Type { get; }

		/// <summary>
		/// The APR.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double APR { get; }

#endregion

	}
	
}
