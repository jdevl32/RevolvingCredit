using System;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountPromotion
		//:
		//IUnique
	{

#region Property

		/// <summary>
		/// The id of the account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		int AccountId { get; }

		/// <summary>
		/// The start timestamp of the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DateTime Start { get; }

		/// <summary>
		/// The end timestamp of the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DateTime End { get; }

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAPR Type { get; }

		/// <summary>
		/// The APR for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double APR { get; }

#endregion

	}
	
}
