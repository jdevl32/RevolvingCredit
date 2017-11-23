using System;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A payment record for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountPayment
	{

#region Property

		/// <summary>
		/// The id of the account the payment applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		int AccountId { get; }

		/// <summary>
		/// The due timestamp of the payment.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DateTime Due { get; }

		/// <summary>
		/// The payment amount.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double Amount { get; }

#endregion

	}
}