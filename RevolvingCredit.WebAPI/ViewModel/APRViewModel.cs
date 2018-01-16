using JDevl32.Web.ViewModel;
using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.WebAPI.ViewModel
{

	/// <summary>
	/// An APR (type) view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Remove unique item type from unique item view model (base class).
	/// </remarks>
	public class APRViewModel
		:
		// todo|jdevl32: cleanup...
		//UniqueBase
		//,
		//IAPRViewModel
		UniqueViewModelBase
		,
		IAPR
	{

#region Property

//#region IAPRViewModel

//#endregion

#endregion

#region Instance Initialization

		/**
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

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRViewModel(IMapper mapper)
			:
			base(mapper)
		{
		}
		/**/

#endregion

	}

}
