using RevolvingCredit.Entity.Interface;
using System;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class AccountLabel
		:
		//UniqueBase
		//,
		IAccountLabel
	{

#region Property

#region IAccountLabel

		/// <inheritdoc />
		public int AccountId { get; }

		// todo|jdevl32: implement auto-mapper...
		/// <inheritdoc />
		ILabel IAccountLabel.Label { get; }

		/// <inheritdoc />
		public DateTime UpdateTimestamp { get; }

#endregion

		/// <summary>
		/// The label on the account.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Label Label { get; }

#endregion

#region Instance Initialization

//#region UniqueBase

//		/// <inheritdoc />
//		public AccountLabel(int id)
//			:
//			base(id)
//		{
//		}

//		/// <inheritdoc />
//		public AccountLabel(int id, string shortName, string fullName, string description)
//			:
//			base(id, shortName, fullName, description)
//		{
//		}

//		/// <inheritdoc />
//		public AccountLabel(string shortName, string fullName, string description)
//			:
//			base(shortName, fullName, description)
//		{
//		}

//#endregion

		// todo|jdevl32: implement ctors...

#endregion

	}

}
