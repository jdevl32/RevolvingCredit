﻿// /script/app/app.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Configure routing.
		// Last modification:
		// Inject log provider.
		// Add methods to capture state entry and exit.
		function config($logProvider, $stateProvider, $urlRouterProvider)
		{
			// Enable debugging.
			$logProvider.debugEnabled(true);

			// Default route configuration.
			$urlRouterProvider.otherwise("/maintenance/apr");

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
				name: "maintenance"
				,
				onEnter: onStateEnter
				,
				onExit: onStateExit
				,
				templateUrl: "/template/maintenance.html"
				,
				url: "/maintenance"
			}
			;

			// Define the APR (type) (child to maintenance) view state.
			var aprViewState =
			{
				controller: "unique"
				,
				controllerAs: "vm"
				,
				name: "apr"
				,
				onEnter: onStateEnter
				,
				onExit: onStateExit
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

			// Define the APR (type) (child to maintenance) save state.
			var aprSaveState =
			{
				controller: "uniqueSave"
				,
				controllerAs: "vm"
				,
				name: "save"
				,
				onEnter: onStateEnter
				,
				onExit: onStateExit
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
				// Create the (abstract) maintenance state.
				.state(maintenanceState)
				// Create the APR (type) (child to maintenance) view state.
				.state(aprViewState)
				// Create the APR (type) (child to maintenance) save state.
				.state(aprSaveState)
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