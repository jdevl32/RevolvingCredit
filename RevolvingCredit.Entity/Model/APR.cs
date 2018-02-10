using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// An APR (type) for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public class APR
		:
		UniqueIntEntity
		,
		IAPR
	{
	}

}
