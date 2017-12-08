﻿using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A payment type for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add (EF-required) default (parameterless) constructor.
	/// </remarks>
	public class Payment
		:
		UniqueBase
		,
		IPayment
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Payment()
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Payment(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Payment(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Payment(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

	}

}
