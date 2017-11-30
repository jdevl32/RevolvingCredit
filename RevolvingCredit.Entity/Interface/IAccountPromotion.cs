using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-engineer using EF navigation properties.
	/// </remarks>
	public interface IAccountPromotion
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		int TypeId { get; set; }

#endregion

		/// <summary>
		/// The start timestamp of the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		DateTime Start { get; set; }

		/// <summary>
		/// The end timestamp of the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		DateTime End { get; set; }

#endregion

		/// <summary>
		/// The APR for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		double APR { get; set; }

#region EF - Navigation

		/// <summary>
		/// The account the promotion applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; }

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAPR Type { get; }

#endregion

#endregion

	}

}
