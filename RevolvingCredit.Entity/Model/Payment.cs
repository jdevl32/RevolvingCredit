using JDevl32.Entity.Model;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.Entity.Model
{

	/// <summary>
	/// A payment type for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class Payment
		:
		UniqueBase
		,
		IPayment
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		public Payment(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		public Payment(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		public Payment(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

	}

}
