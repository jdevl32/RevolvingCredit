using System;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.Entity.Interface
{

	/// <summary>
	/// An APR for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-engineer using EF navigation properties.
	/// </remarks>
	public interface IAccountAPR
	{

#region Property

#region EF - Primary Key

#region EF - Foreign Key

		/// <summary>
		/// The id of the account the APR applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		Guid AccountId { get; set; }

		/// <summary>
		/// The id of the APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		int TypeId { get; set; }

#endregion

		/// <summary>
		/// The update timestamp of the APR for the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		DateTime UpdateTimestamp { get; set; }

#endregion

		/// <summary>
		/// The APR (value).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add (EF-required) setter.
		/// </remarks>
		[Required]
		double APR { get; set; }

#region EF Navigation

		/// <summary>
		/// The account the APR applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAccount Account { get; }

		/// <summary>
		/// The APR (type).
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IAPR Type { get; }

#endregion

#endregion

	}

}
