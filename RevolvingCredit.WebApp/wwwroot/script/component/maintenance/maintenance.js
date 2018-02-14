// /script/component/maintenance/maintenance.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (component) name and URL (part).
		var maintenanceName = "maintenance";
		var maintenanceUrl = "/" + maintenanceName;

		// Define the maintenance component.
		var component =
		{
			templateUrl: "/template" + maintenanceUrl + ".html"
		}
		;

		// Create the maintenance component.
		// Last modification:
		angular.module("app").component(maintenanceName, component);
	}
)();
