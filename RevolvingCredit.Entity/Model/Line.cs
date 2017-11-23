using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A line type for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class Line
		:
		UniqueBase
		,
		ILine
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		public Line(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		public Line(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		public Line(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

	}

}
