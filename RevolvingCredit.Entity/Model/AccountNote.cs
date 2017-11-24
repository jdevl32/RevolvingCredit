using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A note on a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountNote
		:
		IAccountNote
	{

#region Property

#region IAccountNote

		/// <inheritdoc />
		public int AccountId { get; }

		/// <inheritdoc />
		public string Note { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

#endregion

#region Instance Initialization

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountNote(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountNote(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountNote(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
