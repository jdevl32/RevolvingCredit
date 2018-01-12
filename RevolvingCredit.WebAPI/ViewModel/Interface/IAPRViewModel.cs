using RevolvingCredit.Entity.Interface;

namespace RevolvingCredit.WebAPI.ViewModel.Interface
{

	// todo|jdevl32: this should probably be (able to be) removed once new implementation...
	/// <inheritdoc />
	/// <remarks>
	/// Last modification:
	/// Remove test.
	/// </remarks>
	public interface IAPRViewModel
		:
		// todo|jdevl32: ??? (all unique view model(s)) ???
		//IUnique
		IAPR
	{

#region Property

		// todo|jdevl32: may not need to expose id (in which case define new private here...)

#endregion

	}

}
