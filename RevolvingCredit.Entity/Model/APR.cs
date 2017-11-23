using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// The APR type for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class APR
		:
		UniqueBase
		,
		IAPR
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		public APR(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		public APR(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		public APR(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

	}

}
