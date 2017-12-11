using AutoMapper;
using JDevl32.Entity;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using System.Linq;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// An APR sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public class APRSower
		:
		EntityContextSowerBase<APRSower, RevolvingCreditContext>
		//IEntityContextSower
		//,
		//ILoggable<APRSower>
		//,
		//IInstanceMapper
	{

#region Property

		// todo|jdevl32: cleanup...
		/**
#region IEntityContextSower

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		IEntityContext IEntityContextSower.EntityContext => Mapper.Map<IEntityContext>(EntityContext);

#endregion

#region ILoggable<APRSower>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public ILogger<APRSower> Logger { get; }

#endregion

#region IInstanceMapper

		/// <inheritdoc />
		public IMapper Mapper { get; }

#endregion

		/// <remarks>
		/// Last modification:
		/// </remarks>
		public virtual IRevolvingCreditContext EntityContext { get; }
		**/

#endregion

#region Instance Initialization

#region EntityContextSowerBase<APRSower, RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRSower(RevolvingCreditContext revolvingCreditContext, ILogger<APRSower> logger, IMapper mapper)
			:
			base(revolvingCreditContext, logger, mapper)
		{
		}

#endregion

#endregion

#region EntityContextSowerBase<APRSower, RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Add database generated identity annotation.
		/// Enhance logging.
		/// </remarks>
		public override async Task Seed()
		{
			Logger.LogInformation("Seed APR...");

			var @new = string.Empty;

			if (EntityContext.APR.Any())
			{
				Logger.LogInformation("...APR already seeded.");
			} // if
			else
			{
				@new = "New ";

				await EntityContext.APR.AddRangeAsync
					(
						new APR
						{
							Description = "APR that applies to the line of cash for a revolving credit account."
							,
							FullName = "Cash APR"
							//,
							//Id = 1
							,
							ShortName = "Cash"
						}
						,
						new APR
						{
							Description = "APR that applies to the line of credit for a revolving credit account."
							,
							FullName = "Credit APR"
							//,
							//Id = 2
							,
							ShortName = "Credit"
						}
					);

				await EntityContext.SaveChangesAsync();
			} // else

			Logger.LogInformation($"{@new}APR count = {EntityContext.APR.Count()}.");
		}

#endregion

	}

}
