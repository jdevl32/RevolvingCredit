// /script/app/app.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the module configuration.
		var config =
			// Configure state machine and routing.
			// Last modification:
			// Implement revolving credit account state(s).
			function ($logProvider, $stateProvider, $urlRouterProvider)
			{
				// Enable debugging.
				$logProvider.debugEnabled(true);

				var maintenanceName = "maintenance";
				var maintenanceURL = "/" + maintenanceName;
				var accountName = "account";
				var accountURL = "/" + accountName;
				var saveName = "save";
				var saveURL = "/" + saveName;
				var aprName = "apr";
				var aprURL = "/" + aprName;

				// Default route configuration.
				$urlRouterProvider.otherwise(maintenanceURL + accountURL);

				// Define the revolving credit account common params.
				var accountParams = 
				{
					displayName: "Revolving Credit Account"
					,
					url: "http://localhost:58410/api/account"
				}
				;

				// Define the APR (type) common params.
				var aprParams = 
				{
					displayName: "APR (type)"
					,
					url: "http://localhost:58410/api/APR"
				}
				;

				// Create method to capture state entry.
				var onStateEnter =
					// Last modification:
					function($log, $state)
					{
						// todo|jdevl32: is this the right state (current) to get ???
						// Get the current state (from the state service).
						var state = $state.current;

						// todo|jdevl32: capture all of state (this) or just name (this.name) ???
						var message = "Enter state (" + toString(state) + ")...";

						try
						{
							$log.debug(message);
						} // try
						catch (e)
						{
							debug("Error capturing state entry (" + toString(message, "message") + "):  " + toString(e));
						} // catch
					}
				;

				// Create method to capture state exit.
				var onStateExit =
					// Last modification:
					function ($log, $state)
					{
						// Get the current state (from the state service).
						var state = $state.current;

						// todo|jdevl32: capture all of state (this) or just name (this.name) ???
						var message = "...Exit state (" + toString(state) + ").";

						try
						{
							$log.debug(message);
						} // try
						catch (e)
						{
							debug("Error capturing state exit (" + toString(message, "message") + "):  " + toString(e));
						} // catch
					}
				;

				// Define the (abstract) maintenance state.
				var maintenanceState =
				{
					abstract: true
					,
					component: maintenanceName
					,
					name: maintenanceName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					url: maintenanceURL
				}
				;

				//var mainViewName = "main";
				//var mainStateViewName = mainViewName + "@" + maintenanceName;

				var uniqueView =
				{
					component: "unique"
				}
				;

				var uniqueSaveView =
				{
					component: "uniqueSave"
				}
				;

				var uniqueViewMap =
				{
					"main@maintenance": uniqueView
				}
				;

				var uniqueSaveViewMap =
				{
					"main@maintenance": uniqueSaveView
				}
				;

				//var accountView =
				//{
				//	"main@maintenance": uniqueView
				//}
				//;

				// Define the revolving credit account (child of maintenance) view state.
				var accountMaintenanceState =
				{
					name: maintenanceName + "." + accountName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: accountParams
					,
					url: accountURL
					,
					views: uniqueViewMap
				}
				;

				// Define the revolving credit account (child of maintenance) save state.
				var accountMaintenanceSaveState =
				{
					name: accountMaintenanceState.name + "." + saveName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: accountParams
					,
					url: saveURL
					,
					views: uniqueSaveViewMap
				}
				;

				// Define the APR (type) (child of maintenance) view state.
				var aprMaintenanceState =
				{
					name: maintenanceName + "." + aprName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: aprParams
					,
					url: aprURL
					,
					views: uniqueViewMap
				}
				;

				// Define the APR (type) (child of maintenance) save state.
				var aprMaintenanceSaveState =
				{
					name: aprMaintenanceState.name + "." + saveName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: aprParams
					,
					url: saveURL
					,
					views: uniqueSaveViewMap
				}
				;

				$stateProvider
					// Create the (abstract) maintenance state.
					.state(maintenanceState)
					// Create the revolving credit account (child of maintenance) view state.
					.state(accountMaintenanceState)
					// Create the revolving credit account (child of maintenance) save state.
					.state(accountMaintenanceSaveState)
					// Create the APR (type) (child of maintenance) view state.
					.state(aprMaintenanceState)
					// Create the APR (type) (child of maintenance) save state.
					.state(aprMaintenanceSaveState)
				;
			}
		;

		// Define the module dependenc(y/ies).
		var dependency =
			[
				"spinner"
				,
				"ui.router"
				,
				"service"
				,
				"mwl.confirm"
			]
		;

		// Create the app module.
		// Last modification:
		// (Re-)implement AngularUI router.
		angular.module("app", dependency).config(config);
	}
)();
