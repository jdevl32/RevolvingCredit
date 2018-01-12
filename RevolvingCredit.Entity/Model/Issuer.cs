using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An issuer of a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Remove constructor(s).
	/// </remarks>
	public class Issuer
		:
		UniqueBase
		,
		IIssuer
	{

		// todo|jdevl32: cleanup...
		/**
#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Issuer()
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Issuer(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Issuer(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public Issuer(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion
		/**/

	}

}
