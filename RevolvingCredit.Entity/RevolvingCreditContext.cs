using AutoMapper;
using JDevl32.Entity.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;
using System.Linq;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// The revolving credit database context.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Re-implement logger from mapper entity context base class.
	/// Re-implement base class as generic.
	/// </remarks>
	public class RevolvingCreditContext
		:
		MapperEntityContextBase<RevolvingCreditContext>
		,
		IRevolvingCreditContext
	{

#region Property

#region MapperEntityContextBase

		/// <summary>
		/// The database connection string key.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public override string ConnectionStringKey { get; } = "ConnectionStrings:RevolvingCreditConnection";

		/// <summary>
		/// The logger.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// Add setter.
		/// </remarks>
		public new ILogger<RevolvingCreditContext> Logger { get; protected set; }

#endregion

#region IRevolvingCreditContext

#endregion

		/// <inheritdoc />
		public DbSet<Account> Account { get; set; }

		/// <inheritdoc />
		public DbSet<AccountAPR> AccountAPR { get; set; }

		/// <inheritdoc />
		public DbSet<AccountBalance> AccountBalance { get; set; }

		/// <inheritdoc />
		public DbSet<AccountIssuer> AccountIssuer { get; set; }

		/// <inheritdoc />
		public DbSet<AccountLabel> AccountLabel { get; set; }

		/// <inheritdoc />
		public DbSet<AccountLine> AccountLine { get; set; }

		/// <inheritdoc />
		public DbSet<AccountNote> AccountNote { get; set; }

		/// <inheritdoc />
		public DbSet<AccountPayment> AccountPayment { get; set; }

		/// <inheritdoc />
		public DbSet<AccountPromotion> AccountPromotion { get; set; }

		/// <inheritdoc />
		public DbSet<AccountStatement> AccountStatement { get; set; }

		/// <inheritdoc />
		public DbSet<APR> APR { get; set; }

		/// <inheritdoc />
		public DbSet<Issuer> Issuer { get; set; }

		/// <inheritdoc />
		public DbSet<Label> Label { get; set; }

		/// <inheritdoc />
		public DbSet<Line> Line { get; set; }

		/// <inheritdoc />
		public DbSet<Payment> Payment { get; set; }

#endregion

#region Instance Initialization

		/// <inheritdoc />
		public RevolvingCreditContext(DbContextOptions dbContextOptions, IConfigurationRoot configurationRoot, IHostingEnvironment hostingEnvironment, ILogger<RevolvingCreditContext> logger, IMapper mapper)
			:
			base(dbContextOptions, configurationRoot, hostingEnvironment, logger, mapper)
			=>
			SetLogger(logger);

		/// <inheritdoc />
		public RevolvingCreditContext(DbContextOptions dbContextOptions, IConfigurationRoot configurationRoot, IHostingEnvironment hostingEnvironment, ILogger<RevolvingCreditContext> logger, IMapper mapper, string connectionStringKey)
			:
			base(dbContextOptions, configurationRoot, hostingEnvironment, logger, mapper, connectionStringKey)
			=>
			SetLogger(logger);

		// todo|jdevl32: implement ctors...

#endregion

#region DbContext

		/// <inheritdoc />
		/// <remarks>
		/// Last modification:
		/// Add account balance.
		/// Turn off cascading deletes (to avoid cycles).
		/// </remarks>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AccountAPR>()
				.HasKey
					(
						accountAPR => new
						{
							accountAPR.AccountId
							,
							accountAPR.TypeId
							,
							accountAPR.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountBalance>()
				.HasKey
					(
						accountBalance => new
						{
							accountBalance.AccountId
							,
							accountBalance.Timestamp
						}
					)
			;
			modelBuilder.Entity<AccountIssuer>()
				.HasKey
					(
						accountIssuer => new
						{
							accountIssuer.AccountId
							,
							accountIssuer.IssuerId
							,
							accountIssuer.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountLabel>()
				.HasKey
					(
						accountLabel => new
						{
							accountLabel.AccountId
							,
							accountLabel.LabelId
							,
							accountLabel.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountLine>()
				.HasKey
					(
						accountLine => new
						{
							accountLine.AccountId
							,
							accountLine.LineId
							,
							accountLine.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountNote>()
				.HasKey
					(
						accountNote => new
						{
							accountNote.AccountId
							,
							accountNote.UpdateTimestamp
						}
					)
			;
			modelBuilder.Entity<AccountPayment>()
				.HasKey
					(
						accountPayment => new
						{
							accountPayment.AccountId
							,
							accountPayment.Due
						}
					)
			;
			modelBuilder.Entity<AccountPromotion>()
				.HasKey
					(
						accountPromotion => new
						{
							accountPromotion.AccountId
							,
							accountPromotion.TypeId
							,
							accountPromotion.Start
							,
							accountPromotion.End
						}
					)
			;
			modelBuilder.Entity<AccountStatement>()
				.HasKey
					(
						accountStatement => new
						{
							accountStatement.AccountId
							,
							accountStatement.End
						}
					)
			;

			// Get all foreign keys.
			foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(entityType => entityType.GetForeignKeys()))
			{
				// Foreign keys (account-statement => account-balance)...
				if
					(
						nameof(AccountStatement) == foreignKey.DeclaringEntityType.ShortName()
						&&
						nameof(AccountBalance) == foreignKey.PrincipalEntityType.ShortName()
					)
				{
					switch (foreignKey.DependentToPrincipal.Name)
					{
						// End-balance and start-balance navigation properties...
						// todo|jdevl32: constant(s)...
						case "EndBalance":
						case "StartBalance":
							// Turn off cascading deletes (to avoid cycles).
							foreignKey.DeleteBehavior = DeleteBehavior.Restrict;

							// todo|jdevl32: consider implementing cascade-like (instead-of-delete) triggers

							break;
					} // switch
				} // if
			} // foreach

			base.OnModelCreating(modelBuilder);
		}

#endregion

#region MapperEntityContextBase

		// todo|jdevl32: ???
		/**
		/// <inheritdoc />
		protected override void SetLogger<TDerivedClass>(ILogger<TDerivedClass> logger)
		{
			base.SetLogger(logger);

			Logger = Mapper.Map<ILogger<RevolvingCreditContext>>(logger);
		}
		/**/

#endregion

	}

}
