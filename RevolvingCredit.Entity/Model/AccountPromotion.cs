using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A promotion for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountPromotion
		:
		//UniqueBase
		//,
		IAccountPromotion
	{

#region Property

#region IAccountPromotion

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public DateTime Start { get; }

		/// <inheritdoc />
		public DateTime End { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		IAPR IAccountPromotion.Type { get; }

		/// <inheritdoc />
		public double APR { get; }

#endregion

		/// <summary>
		/// The APR (type) for the promotion.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APR Type { get; }

#endregion

#region Instance Initialization

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountPromotion(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountPromotion(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountPromotion(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
