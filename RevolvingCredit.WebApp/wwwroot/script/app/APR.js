// /script/app/APR.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Configure routing.
		// Last modification:
		// Rename.
		// (Re-)implement AngularUI router.
		function config($urlRouterProvider, $stateProvider)
		{
			// Default route configuration.
			$urlRouterProvider.otherwise("/");

			$stateProvider
				// APR route configuration.
				.state
					(
						"apr"
						,
						{
							controller: "apr"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/APR.html"
							,
							url: "/"
						}
					)
				// APR update route configuration.
				.state
					(
						"aprUpdate"
						,
						{
							controller: "aprUpdate"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/APR.update.html"
							,
							url: "/update"
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
