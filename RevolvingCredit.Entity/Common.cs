using AutoMapper;
using RevolvingCredit.Entity.Interface;
using RevolvingCredit.Entity.Model;

namespace RevolvingCredit.Entity
{

	/// <summary>
	/// A common (utitlity) class.
	/// </summary>
	/// <remarks>
	/// Last modification:
	/// </remarks>
	public static class Common
	{

		/// <summary>
		/// Configure the auto-mapper profile.
		/// </summary>
		/// <param name="autoMapperProfile">
		/// The auto-mapper profile to configure.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public static void Configure(Profile autoMapperProfile)
			=>
			Configure(autoMapperProfile as IProfileExpression);

		/// <summary>
		/// Configure the profile expression.
		/// </summary>
		/// <param name="profileExpression">
		/// The profile expression to configure.
		/// </param>
		/// <remarks>
		/// Last modification:
		/// </remarks>
		public static void Configure(IProfileExpression profileExpression)
		{
			// todo|jdevl32: ???
			/**
			CreateMap<Account, IAccount>()
				.ConstructUsing(source => new Account())
				.ReverseMap();
			/**/
			profileExpression
				.CreateMap<AccountAPR, IAccountAPR>()
				.ConstructUsing(source => new AccountAPR(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountBalance, IAccountBalance>()
				.ConstructUsing(source => new AccountBalance(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountIssuer, IAccountIssuer>()
				.ConstructUsing(source => new AccountIssuer(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountLabel, IAccountLabel>()
				.ConstructUsing(source => new AccountLabel(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountLine, IAccountLine>()
				.ConstructUsing(source => new AccountLine(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountNote, IAccountNote>()
				.ConstructUsing(source => new AccountNote(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountPayment, IAccountPayment>()
				.ConstructUsing(source => new AccountPayment(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountPromotion, IAccountPromotion>()
				.ConstructUsing(source => new AccountPromotion(source.Mapper))
				.ReverseMap()
			;
			profileExpression
				.CreateMap<AccountStatement, IAccountStatement>()
				.ConstructUsing(source => new AccountStatement(source.Mapper))
				.ReverseMap()
			;
			/**
			CreateMap<APR, IAPR>()
				.ConstructUsing(source => new APR { Id = source.Id })
				.ReverseMap();
			// todo|jdevl32: ??? what about balance (and interface) ???
			CreateMap<Issuer, IIssuer>()
				.ConstructUsing(source => new Issuer { Id = source.Id })
				.ReverseMap();
			CreateMap<Label, ILabel>()
				.ConstructUsing(source => new Label { Id = source.Id })
				.ReverseMap();
			CreateMap<Line, ILine>()
				.ConstructUsing(source => new Line { Id = source.Id })
				.ReverseMap();
			CreateMap<Payment, IPayment>()
				.ConstructUsing(source => new Payment { Id = source.Id })
				.ReverseMap();
			/**/
			// todo|jdevl32: cleanup...
			/**
			CreateMap<APR, UniqueBase>()
				.ConstructUsing(source => new APR { Id = source.Id })
				.ReverseMap();
			/**/
			// todo|jdevl32: cleanup...
			/**
			CreateMap<APRViewModel, APR>()
				.ReverseMap();
			/**/
			// todo|jdevl32: cleanup...
			/**
			CreateMap<APRViewModel, IUniqueViewModel<IAPR>>()
				.ReverseMap();
			/**/
			// todo|jdevl32: cleanup...
			/**
			CreateMap<IAPR, IUniqueViewModel<IAPR>>()
				// todo|jdevl32: ??? what about (null) mapper ???
				.ConstructUsing(source => new APRViewModel(null))
				.ReverseMap();
			/**/
			// todo|jdevl32: maybe not needed ???
			profileExpression
				.CreateMap<RevolvingCreditContext, IRevolvingCreditContext>()
				.ConstructUsing
				(
					source => new RevolvingCreditContext
					(
						source.DbContextOptions
						,
						source.ConfigurationRoot
						,
						source.HostingEnvironment
						,
						source.Logger
						,
						source.Mapper
						,
						source.ConnectionStringKey
					)
				)
				.ReverseMap()
			;
		}

	}

}
