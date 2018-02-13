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
			// Implement issuer.
			function ($logProvider, $stateProvider, $urlRouterProvider)
			{
				// Enable debugging.
				$logProvider.debugEnabled(true);

				// Define component/controller/route name(s) and URL(s).
				var accountName = "account";
				var accountURL = "/" + accountName;
				var aprName = "apr";
				var aprURL = "/" + aprName;
				var issuerName = "issuer";
				var issuerURL = "/" + issuerName;
				var labelName = "label";
				var labelURL = "/" + labelName;
				var lineName = "line";
				var lineURL = "/" + lineName;
				var maintenanceName = "maintenance";
				var maintenanceURL = "/" + maintenanceName;
				var partialFileExt = ".partial.html";
				var saveName = "save";
				var saveURL = "/" + saveName;
				var templateName = "template";
				var templateURL = "/" + templateName;
				var viewName = "view";
				var viewURL = "/" + viewName;

				// Default route configuration.
				$urlRouterProvider.otherwise(maintenanceURL + accountURL);

				// Define the revolving credit account partial template(s).
				var accountTemplate =
				{
					saveURL: templateURL + maintenanceURL + saveURL + accountURL + partialFileExt
					,
					viewURL: templateURL + maintenanceURL + viewURL + accountURL + partialFileExt
				}
				;

				// Define the revolving credit account common params.
				var accountParams = 
				{
					displayName: "Revolving Credit Account"
					,
					template: accountTemplate
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

				// Define the issuer common params.
				var issuerParams = 
				{
					displayName: "Issuer"
					,
					url: "http://localhost:58410/api/issuer"
				}
				;

				// Define the (major) label common params.
				var labelParams = 
				{
					displayName: "(Major) label"
					,
					url: "http://localhost:58410/api/label"
				}
				;

				// Define the line (type) common params.
				var lineParams = 
				{
					displayName: "Line (type)"
					,
					url: "http://localhost:58410/api/line"
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

				// Define the default save view.
				var saveView =
				{
					component: saveName
				}
				;

				// Define the default view view.
				var viewView =
				{
					component: viewName
				}
				;

				// Define the revolving credit account save view-map.
				var accountSaveViewMap =
				{
					"main@maintenance": saveView
				}
				;

				// Define the revolving credit account view view-map.
				var accountViewViewMap =
				{
					"main@maintenance": viewView
				}
				;

				// Define the default save view-map.
				var saveViewMap =
				{
					"main@maintenance": saveView
				}
				;

				// Define the default view view-map.
				var viewViewMap =
				{
					"main@maintenance": viewView
				}
				;

				// Define the revolving credit account view state.
				var accountMaintenanceViewState =
				{
					// ...as a child of the (parent) maintenance state.
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
					views: accountViewViewMap
				}
				;

				// Define the revolving credit account save state.
				var accountMaintenanceSaveState =
				{
					// todo|jdevl32: is parent correct ???
					// ...as a child of the (parent) revolving credit account view state.
					name: accountMaintenanceViewState.name + "." + saveName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: accountParams
					,
					url: saveURL
					,
					views: accountSaveViewMap
				}
				;

				// Define the APR (type) view state.
				var aprMaintenanceViewState =
				{
					// ...as a child of the (parent) maintenance state.
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
					views: viewViewMap
				}
				;

				// Define the APR (type) save state.
				var aprMaintenanceSaveState =
				{
					// todo|jdevl32: is parent correct ???
					// ...as a child of the (parent) APR (type) view state.
					name: aprMaintenanceViewState.name + "." + saveName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: aprParams
					,
					url: saveURL
					,
					views: saveViewMap
				}
				;

				// Define the issuer view state.
				var issuerMaintenanceViewState =
				{
					// ...as a child of the (parent) maintenance state.
					name: maintenanceName + "." + issuerName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: issuerParams
					,
					url: issuerURL
					,
					views: viewViewMap
				}
				;

				// Define the issuer save state.
				var issuerMaintenanceSaveState =
				{
					// todo|jdevl32: is parent correct ???
					// ...as a child of the (parent) issuer view state.
					name: issuerMaintenanceViewState.name + "." + saveName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: issuerParams
					,
					url: saveURL
					,
					views: saveViewMap
				}
				;

				// Define the (major) label view state.
				var labelMaintenanceViewState =
				{
					// ...as a child of the (parent) maintenance state.
					name: maintenanceName + "." + labelName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: labelParams
					,
					url: labelURL
					,
					views: viewViewMap
				}
				;

				// Define the (major) label save state.
				var labelMaintenanceSaveState =
				{
					// todo|jdevl32: is parent correct ???
					// ...as a child of the (parent) (major) label view state.
					name: labelMaintenanceViewState.name + "." + saveName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: labelParams
					,
					url: saveURL
					,
					views: saveViewMap
				}
				;

				// Define the line (type) view state.
				var lineMaintenanceViewState =
				{
					// ...as a child of the (parent) maintenance state.
					name: maintenanceName + "." + lineName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: lineParams
					,
					url: lineURL
					,
					views: viewViewMap
				}
				;

				// Define the line (type) save state.
				var lineMaintenanceSaveState =
				{
					// todo|jdevl32: is parent correct ???
					// ...as a child of the (parent) line (type) view state.
					name: lineMaintenanceViewState.name + "." + saveName
					,
					onEnter: onStateEnter
					,
					onExit: onStateExit
					,
					params: lineParams
					,
					url: saveURL
					,
					views: saveViewMap
				}
				;

				$stateProvider
					// Create the revolving credit account save state.
					.state(accountMaintenanceSaveState)
					// Create the revolving credit account view state.
					.state(accountMaintenanceViewState)
					// Create the APR (type) save state.
					.state(aprMaintenanceSaveState)
					// Create the APR (type) view state.
					.state(aprMaintenanceViewState)
					// Create the issuer save state.
					.state(issuerMaintenanceSaveState)
					// Create the issuer view state.
					.state(issuerMaintenanceViewState)
					// Create the (major) label save state.
					.state(labelMaintenanceSaveState)
					// Create the (major) label view state.
					.state(labelMaintenanceViewState)
					// Create the line (type) save state.
					.state(lineMaintenanceSaveState)
					// Create the line (type) view state.
					.state(lineMaintenanceViewState)
					// Create the (abstract, ancestor) maintenance state.
					.state(maintenanceState)
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
