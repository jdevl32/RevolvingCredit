using JDevl32.Entity.Interface.Generic;

namespace RevolvingCredit.Entity.Interface
{

	/// <inheritdoc />
	/// <summary>
	/// An issuer of a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public interface IIssuer
		:
		IUniqueEntity<int>
	{
	}

}
