using JDevl32.Entity.Interface;

namespace RevolvingCredit.WebAPI.ViewModel.Interface
{

	/// <summary>
	/// The APR (type) view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAPRViewModel
		:
		IUnique
	{

#region Property

		double Test { get; }

#endregion

	}

}
