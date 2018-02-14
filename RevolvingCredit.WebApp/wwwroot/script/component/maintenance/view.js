// /script/component/maintenance/view.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (controller and component) name and URL (part).
		var maintenanceName = "maintenance";
		var maintenanceUrl = "/" + maintenanceName;
		var viewName = "view";
		var viewUrl = "/" + viewName;

		// Define the (view) unique item component.
		var component =
		{
			controller: viewName
			,
			controllerAs: "vm"
			,
			templateUrl: "/template" + maintenanceUrl + viewUrl + ".html"
		}
		;

		// Create the (view) unique item component.
		// Last modification:
		angular.module("app").component(viewName, component);
	}
)();
