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
	/// (Re-)implement as (generic) informable unique (integer) identifier entity context sower (base class).
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

		/**
		public const IEnumerable<APR> DefaultEntity =
			new []
			{
				new APR
				{
					Description = $"{DefaultDisplayName} that applies to the line of cash for a revolving credit account."
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
					Description = $"{DefaultDisplayName} that applies to the line of credit for a revolving credit account."
					,
					FullName = "Credit APR"
					//,
					//Id = 2
					,
					ShortName = "Credit"
				}
			}
		;
		/**/

#endregion

#region Property

#region Overrides of InformableEntityContextSowerBase<RevolvingCreditContext, APR, int>

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		protected override IEnumerable<APR> Entity { get; set; }

#endregion

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
		/// </remarks>
		public APRSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, string displayName)
			:
			// todo|jdelv32: implement default entity !!!
			base(entityContext, loggerFactory, displayName)
			//this(entityContext, loggerFactory, displayName, )
		{
		}

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public APRSower(RevolvingCreditContext entityContext, ILoggerFactory loggerFactory, IEnumerable<APR> entity)
			:
			this(entityContext, loggerFactory, DefaultDisplayName, entity)
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

	}

}
