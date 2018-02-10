using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An issuer of a revolving credit accont.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public class Issuer
		:
		UniqueIntEntity
		,
		IIssuer
	{
	}

}
