using RevolvingCredit.Entity.Interface;
using System.Collections.Generic;

namespace RevolvingCredit.WebAPI.Repository.Interface
{

	/// <summary>
	/// The APR repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Add remove.
	/// </remarks>
	public interface IAPRRepository
	{

		/// <summary>
		/// Get the APRs.
		/// </summary>
		/// <returns>
		/// The APRs.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// Rename.
		/// </remarks>
		IEnumerable<IAPR> Get();

		/// <summary>
		/// Remove the APR.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		void Remove(IAPR apr);

		/// <summary>
		/// Update the APR.
		/// </summary>
		/// <remarks>
		/// Update is either add or modify (depending on existence).
		/// Last modification:
		/// </remarks>
		void Update(IAPR apr);

	}

}
