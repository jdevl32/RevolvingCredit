using JDevl32.Entity.Model;
using RevolvingCredit.WebAPI.ViewModel.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// The APR (type) view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class APRViewModel
		:
		UniqueBase
		,
		IAPRViewModel
	{

#region Instance Initialization

#region UniqueBase

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRViewModel()
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRViewModel(int id)
			:
			base(id)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRViewModel(int id, string shortName, string fullName, string description)
			:
			base(id, shortName, fullName, description)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRViewModel(string shortName, string fullName, string description)
			:
			base(shortName, fullName, description)
		{
		}

#endregion

#endregion

		#region Implementation of IAPRViewModel

		/// <inheritdoc />
		public double Test { get; set; }

		#endregion
	}

}
