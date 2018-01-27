// /script/app/app.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Configure routing.
		// Last modification:
		// Refactor angular-ui.
		function config($urlRouterProvider, $stateProvider)
		{
			// Default route configuration.
			$urlRouterProvider.otherwise("/maintenance/apr");

			var aprParams = 
			{
				displayName: "APR (type)"
				,
				url: "http://localhost:58410/api/APR"
			}
			;

			var maintenanceState =
			{
				abstract: true
				,
				name: "maintenance"
				,
				templateUrl: "/template/maintenance.html"
				,
				url: "/maintenance"
			}
			;

			var aprViewState =
			{
				controller: "unique"
				,
				controllerAs: "vm"
				,
				name: "apr"
				,
				params: aprParams
				,
				parent: maintenanceState
				,
				templateUrl: "/template/unique.html"
				,
				url: "/apr"
			}
			;

			var aprSaveState =
			{
				controller: "uniqueSave"
				,
				controllerAs: "vm"
				,
				name: "save"
				,
				params: aprParams
				,
				parent: maintenanceState
				,
				templateUrl: "/template/unique.save.html"
				,
				url: "/save"
			}
			;

			$stateProvider
				// 
				.state
					(
						//"maintenance"
						//,
						maintenanceState
					)
				// 
				.state
					(
						//"apr"
						//,
						aprViewState
					)
				// 
				.state
					(
						//"save"
						//,
						aprSaveState
					)
			;
		}

		// Create the app module.
		// Last modification:
		// (Re-)implement AngularUI router.
		angular.module
			(
				"app"
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
