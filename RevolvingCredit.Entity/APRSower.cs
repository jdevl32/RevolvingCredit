using JDevl32.Entity.Generic;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RevolvingCredit.Entity
{

	/// <inheritdoc />
	/// <summary>
	/// An APR (type) sower (seeder).
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Refactor (set of) unique entity item(s) to seed.
	/// Remove unnecessary constructor.
	/// </remarks>
	public class APRSower
		:
		InformableUniqueIntEntityContextSowerBase<RevolvingCreditContext, APR>
	{

#region Constant

		/// <summary>
		/// The (default) display name.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public const string DefaultDisplayName = "APR (type)";

#endregion

#region Instance Initialization

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Refactor loggable logger category name.
		/// </remarks>
		public APRSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory)
			:
			this(entityContext, loggerFactory, DefaultDisplayName)
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Implement the default (set of) unique entity item(s) to seed.
		/// </remarks>
		public APRSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName)
			:
			this(entityContext, loggerFactory, displayName, GetDefaultEntity(displayName))
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName, IEnumerable<APR> entity)
			:
			base(entityContext, loggerFactory, displayName, entity)
		{
		}

#endregion

#region Overrides of EntityContextSowerBase<RevolvingCreditContext>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// (Re-)implement as (generic) informable entity context sower (base class).
		/// </remarks>
		public override async Task Seed()
			=>
			await Seed(EntityContext.APR);

#endregion

		/// <summary>
		/// Get the default (set of) unique entity item(s) to seed.
		/// </summary>
		/// <param name="displayName">
		/// A display name.
		/// </param>
		/// <returns>
		/// The default (set of) unique entity item(s) to seed.
		/// </returns>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public static IEnumerable<APR> GetDefaultEntity(string displayName)
		{
			return
				new []
				{
					new APR
					{
						Description = $"{displayName} that applies to the line of cash for a revolving credit account."
						,
						FullName = "Cash APR"
						,
						ShortName = "Cash"
					}
					,
					new APR
					{
						Description = $"{displayName} that applies to the line of credit for a revolving credit account."
						,
						FullName = "Credit APR"
						,
						ShortName = "Credit"
					}
				}
			;
		}

	}

}
