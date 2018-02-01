// /script/component/maintenance/maintenance.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (controller and component) name.
		var name = "maintenance";

		// Define the maintenance component.
		var component =
		{
			templateUrl: "/template/maintenance.html"
		}
		;

		// Create the maintenance component.
		// Last modification:
		angular.module("app").component(name, component);
	}
)();
