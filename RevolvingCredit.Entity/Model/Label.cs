using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A (major) label for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class Label
		:
		UniqueBase
		,
		ILabel
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		public Label(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		public Label(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		public Label(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

	}

}
