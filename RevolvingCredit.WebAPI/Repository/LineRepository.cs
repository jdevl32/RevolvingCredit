using JDevl32.Web.Repository.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.WebAPI.Repository
{

	/// <inheritdoc />
	/// <summary>
	/// A line (type) repository.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class LineRepository
		:
		InformableUniqueIntEntityContextRepositoryBase<RevolvingCreditContext, Line>
	{

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public LineRepository(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			base(entityContext, loggerFactory, entityContext.Line)
		{
		}

#endregion

	}

}
