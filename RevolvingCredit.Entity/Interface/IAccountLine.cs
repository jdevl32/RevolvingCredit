﻿using System;

namespace RevolvingCredit.Entity.Interface
{
	public interface IAccountLine
	{

		/// <summary>
		/// The id of the account the line applies to.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		int AccountId { get; }

		/// <summary>
		/// The line (type) on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		ILine Line { get; }

		/// <summary>
		/// The limit of the line on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		double Limit { get; }

		/// <summary>
		/// The update timestamp of the line on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		DateTime UpdateTimestamp { get; }

	}
	
}
