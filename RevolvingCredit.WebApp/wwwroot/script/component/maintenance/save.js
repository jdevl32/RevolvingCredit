// /script/component/maintenance/save.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (controller and component) name.
		var name = "save";

		// Define the (save) unique item component.
		var component =
		{
			controller: name
			,
			controllerAs: "vm"
			,
			templateUrl: "/template/maintenance/save.html"
		}
		;

		// Create the (save) unique item component.
		// Last modification:
		angular.module("app").component(name, component);
	}
)();
