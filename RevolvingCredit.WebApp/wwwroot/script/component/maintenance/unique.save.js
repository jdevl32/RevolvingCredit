// /script/component/maintenance/unique.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (controller and component) name.
		var name = "uniqueSave";

		// Define the unique item save component.
		var component =
		{
			controller: name
			,
			controllerAs: "vm"
			,
			templateUrl: "/template/unique.save.html"
		}
		;

		// Create the unique item component.
		// Last modification:
		angular.module("app").component(name, component);
	}
)();
