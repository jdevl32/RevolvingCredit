using JDevl32.Entity.Interface;
using System.ComponentModel.DataAnnotations;

namespace RevolvingCredit.WebAPI.ViewModel.Interface
{
	/// <summary>
	/// A view model for a revolving credit account.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAccountViewModel
		:
		IGlobalUnique
	{

#region Property

		// todo|jdevl32: setter required ???
		/// <summary>
		/// The (safe) account number.
		/// </summary>
		/// <remarks>
		/// This should only ever contain the last four digits of the actual (full) account number.
		/// Last modification:
		/// </remarks>
		[Required(AllowEmptyStrings = false)]
		short SafeAccountNumber { get; }

#endregion

	}
}