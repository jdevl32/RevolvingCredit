// /script/app/APR.js

// Exclude from global scope.
(
	function ()
	{
		"use strict";

		// Configure routing.
		// Last modification:
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
				// APR edit route configuration.
				.when
					(
						"/edit"
						,
						{
							controller: "aprEdit"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/APR.edit.html"
						}
					)
				// Default route configuration.
				.otherwise({ redirectTo: "/" });
		}

		// Create the app module.
		// Last modification:
		// Inject service(s) dependency.
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
				]
			)
			.config(configRoute);
	}
)();
