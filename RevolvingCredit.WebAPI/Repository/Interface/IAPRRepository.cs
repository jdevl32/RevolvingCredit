using RevolvingCredit.Entity.Interface;
using System.Collections.Generic;

namespace RevolvingCredit.WebAPI.Repository.Interface
{

	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public interface IAPRRepository
	{

		/// <summary>
		/// 
		/// </summary>
		/// <returns>
		/// 
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IEnumerable<IAPR> GetAPR();

	}

}
