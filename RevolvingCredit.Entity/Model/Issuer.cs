using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An issuer of a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class Issuer
		:
		UniqueBase
		,
		IIssuer
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		public Issuer(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		public Issuer(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		public Issuer(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

	}

}
