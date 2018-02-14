// /script/component/maintenance/save.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (controller and component) name and URL (part).
		var maintenanceName = "maintenance";
		var maintenanceUrl = "/" + maintenanceName;
		var saveName = "save";
		var saveUrl = "/" + saveName;

		// Define the (save) unique item component.
		var component =
		{
			controller: saveName
			,
			controllerAs: "vm"
			,
			templateUrl: "/template" + maintenanceUrl + saveUrl + ".html"
		}
		;

		// Create the (save) unique item component.
		// Last modification:
		angular.module("app").component(saveName, component);
	}
)();
