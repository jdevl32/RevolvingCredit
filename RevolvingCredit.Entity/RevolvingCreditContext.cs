using AutoMapper;
using JDevl32.Entity.Interface;
using JDevl32.Entity.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// The revolving credit database context.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// Change base class to mapper entity context.
	/// </remarks>
	public class RevolvingCreditContext
		:
		MapperEntityContextBase
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
		/// </remarks>
		public new ILogger<RevolvingCreditContext> Logger { get; }

#endregion

#region IRevolvingCreditContext

		// todo|jdevl32: cleanup...
		/**
		/// <inheritdoc />
		DbSet<IAccount> IRevolvingCreditContext.Account
		{
			get => Mapper.Map<DbSet<IAccount>>(Account);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						// todo|jdevl32: probably not needed ???
						if (null == Mapper)
						{
							throw new NullReferenceException($"Null {nameof(Mapper)} not allowed.");
						} // if

						Account = Mapper.Map<DbSet<Account>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountAPR> IRevolvingCreditContext.AccountAPR
		{
			get => Mapper.Map<DbSet<IAccountAPR>>(AccountAPR);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountAPR = Mapper.Map<DbSet<AccountAPR>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountIssuer> IRevolvingCreditContext.AccountIssuer
		{
			get => Mapper.Map<DbSet<IAccountIssuer>>(AccountIssuer);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountIssuer = Mapper.Map<DbSet<AccountIssuer>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountLabel> IRevolvingCreditContext.AccountLabel
		{
			get => Mapper.Map<DbSet<IAccountLabel>>(AccountLabel);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountLabel = Mapper.Map<DbSet<AccountLabel>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountLine> IRevolvingCreditContext.AccountLine
		{
			get => Mapper.Map<DbSet<IAccountLine>>(AccountLine);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountLine = Mapper.Map<DbSet<AccountLine>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountNote> IRevolvingCreditContext.AccountNote
		{
			get => Mapper.Map<DbSet<IAccountNote>>(AccountNote);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountNote = Mapper.Map<DbSet<AccountNote>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountPayment> IRevolvingCreditContext.AccountPayment
		{
			get => Mapper.Map<DbSet<IAccountPayment>>(AccountPayment);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountPayment = Mapper.Map<DbSet<AccountPayment>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountPromotion> IRevolvingCreditContext.AccountPromotion
		{
			get => Mapper.Map<DbSet<IAccountPromotion>>(AccountPromotion);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountPromotion = Mapper.Map<DbSet<AccountPromotion>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAccountStatement> IRevolvingCreditContext.AccountStatement
		{
			get => Mapper.Map<DbSet<IAccountStatement>>(AccountStatement);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						AccountStatement = Mapper.Map<DbSet<AccountStatement>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IAPR> IRevolvingCreditContext.APR
		{
			get => Mapper.Map<DbSet<IAPR>>(APR);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						APR = Mapper.Map<DbSet<APR>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IIssuer> IRevolvingCreditContext.Issuer
		{
			get => Mapper.Map<DbSet<IIssuer>>(Issuer);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						Issuer = Mapper.Map<DbSet<Issuer>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<ILabel> IRevolvingCreditContext.Label
		{
			get => Mapper.Map<DbSet<ILabel>>(Label);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						Label = Mapper.Map<DbSet<Label>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<ILine> IRevolvingCreditContext.Line
		{
			get => Mapper.Map<DbSet<ILine>>(Line);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						Line = Mapper.Map<DbSet<Line>>(value);
						break;
				} // switch
			}
		}

		/// <inheritdoc />
		DbSet<IPayment> IRevolvingCreditContext.Payment
		{
			get => Mapper.Map<DbSet<IPayment>>(Payment);
			set
			{
				switch (value)
				{
					case null:
						Account = null;
						break;

					default:
						Payment = Mapper.Map<DbSet<Payment>>(value);
						break;
				} // switch
			}
		}
		**/

		/// <summary>
		/// The logger.
		/// </summary>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		ILogger<IRevolvingCreditContext> IEntityContext<IRevolvingCreditContext>.Logger
			=> Mapper.Map<ILogger<IRevolvingCreditContext>>(Logger);

#endregion

		/// <inheritdoc />
		public DbSet<Account> Account { get; set; }

		/// <inheritdoc />
		public DbSet<AccountAPR> AccountAPR { get; set; }

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
			Logger = logger;

		/// <inheritdoc />
		public RevolvingCreditContext(DbContextOptions dbContextOptions, IConfigurationRoot configurationRoot, IHostingEnvironment hostingEnvironment, ILogger<RevolvingCreditContext> logger, IMapper mapper, string connectionStringKey)
			:
			base(dbContextOptions, configurationRoot, hostingEnvironment, logger, mapper, connectionStringKey)
			=>
			Logger = logger;

		// todo|jdevl32: implement ctors...

#endregion

#region DbContext

		/// <inheritdoc />
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			/**
			modelBuilder.Entity<APR>().HasKey
				(
					apr => new { apr.Id }
				);
			**/
			// todo|jdevl32: are these correct (or new property for ....id) ???
			modelBuilder.Entity<AccountAPR>().HasKey
				(
					accountAPR => new
						{
							accountAPR.AccountId
							,
							//accountAPR.Type.Id
							accountAPR.Type
							,
							accountAPR.UpdateTimestamp
						}
				);
			modelBuilder.Entity<AccountIssuer>().HasKey
				(
					accountIssuer => new
						{
							accountIssuer.AccountId
							,
							//accountIssuer.Issuer.Id
							accountIssuer.Issuer
							,
							accountIssuer.UpdateTimestamp
						}
				);
			modelBuilder.Entity<AccountLabel>().HasKey
				(
					accountLabel => new
						{
							accountLabel.AccountId
							,
							//accountLabel.Label.Id
							accountLabel.Label
							,
							accountLabel.UpdateTimestamp
						}
				);
			modelBuilder.Entity<AccountLine>().HasKey
				(
					accountLine => new
						{
							accountLine.AccountId
							,
							//accountLine.Line.Id
							accountLine.Line
							,
							accountLine.UpdateTimestamp
						}
				);
			modelBuilder.Entity<AccountNote>().HasKey
				(
					accountNote => new
						{
							accountNote.AccountId
							,
							accountNote.UpdateTimestamp
						}
				);
			modelBuilder.Entity<AccountPayment>().HasKey
				(
					accountPayment => new
						{
							accountPayment.AccountId
							,
							accountPayment.Due
						}
				);
			modelBuilder.Entity<AccountPromotion>().HasKey
				(
					accountPromotion => new
						{
							accountPromotion.AccountId
							,
							//accountPromotion.Type.Id
							accountPromotion.Type
							,
							accountPromotion.Start
							,
							accountPromotion.End
						}
				);
			modelBuilder.Entity<AccountStatement>().HasKey
				(
					accountStatement => new
						{
							accountStatement.AccountId
							,
							accountStatement.End
						}
				);
			base.OnModelCreating(modelBuilder);
		}

#endregion

	}

}
