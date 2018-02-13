using JDevl32.Entity.Interface.Generic;

namespace RevolvingCredit.Entity.Interface
{

	/// <inheritdoc />
	/// <summary>
	/// A line (type) for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor unique entity item(s) on (value) type of (global) unique identifier.
	/// </remarks>
	public interface ILine
		:
		IUniqueEntity<int>
	{
	}

}
