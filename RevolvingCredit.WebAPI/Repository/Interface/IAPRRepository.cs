using JDevl32.Web.Repository.Interface;
using RevolvingCredit.Entity.Interface;
using System.Collections.Generic;

namespace RevolvingCredit.WebAPI.Repository.Interface
{

	/// <summary>
	/// The APR repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Inherit entity context repository interface.
	/// </remarks>
	public interface IAPRRepository
		:
		IEntityContextRepository
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
		/// Remove (all) the APRs.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		void Remove();

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
