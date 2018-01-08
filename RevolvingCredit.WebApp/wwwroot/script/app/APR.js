// /script/app/APR.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Configure routing.
		// Last modification:
		// Refactor using unique (save) item(s).
		function config($urlRouterProvider, $stateProvider)
		{
			// Default route configuration.
			$urlRouterProvider.otherwise("/");

			$stateProvider
				// APR route configuration.
				.state
					(
						"unique"
						,
						{
							controller: "unique"
							,
							controllerAs: "vm"
							// todo|jdevl32: ??? how to include data specific to each type ???
							/**
							,
							data:
							{
								displayName: "APR (type)"
							}
							/**/
							,
							templateUrl: "/view/maintenance/unique.html"
							,
							url: "/"
						}
					)
				// APR save route configuration.
				.state
					(
						"save"
						,
						{
							controller: "uniqueSave"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/maintenance/unique.save.html"
							,
							url: "/save"
						}
					)
			;
		}

		// Create the app module.
		// Last modification:
		// (Re-)implement AngularUI router.
		angular.module
			(
				"app-APR"
				,
				[
					"spinner"
					,
					"ui.router"
					,
					"service"
					,
					"mwl.confirm"
				]
			)
			.config(config);
	}
)();
