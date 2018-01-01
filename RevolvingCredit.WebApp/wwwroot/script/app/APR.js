// /script/app/APR.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Configure routing.
		// Last modification:
		// Rename controller and template (view).
		function configRoute($routeProvider)
		{
			$routeProvider
				// APR route configuration.
				.when
					(
						"/"
						,
						{
							controller: "apr"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/APR.html"
						}
					)
				// APR update route configuration.
				.when
					(
						"/update"
						,
						{
							controller: "aprUpdate"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/APR.update.html"
						}
					)
				// Default route configuration.
				.otherwise({ redirectTo: "/" });
		}

		// Create the app module.
		// Last modification:
		// Inject angular bootstrap confirm dependency.
		angular.module
			(
				"app-APR"
				,
				[
					"spinner"
					,
					"ngRoute"
					,
					"service"
					,
					"mwl.confirm"
				]
			)
			.config(configRoute);
	}
)();
