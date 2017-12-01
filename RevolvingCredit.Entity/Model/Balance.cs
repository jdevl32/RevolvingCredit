using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A balance type for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class Balance
		:
		UniqueBase
		,
		IBalance
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		public Balance(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		public Balance(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		public Balance(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

	}

}
