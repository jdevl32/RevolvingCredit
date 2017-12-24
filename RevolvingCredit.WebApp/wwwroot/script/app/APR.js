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
							controller: "APR"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/APR.html"
						}
					)
				/**
				// APR edit route configuration.
				.when
					(
						"/edit/:name"
						,
						{
							controller: "APREdit"
							,
							controllerAs: "vm"
							,
							templateUrl: "/view/APR.edit.html"
						}
					)
				**/
				// Default route configuration.
				.otherwise({ redirectTo: "/" });
		}

		// Create the module.
		// Last modification:
		angular.module("app-APR", ["spinner", "ngRoute"]).config(configRoute);
	}
)();
