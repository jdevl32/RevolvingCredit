// /script/component/maintenance/unique.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (controller and component) name.
		var name = "unique";

		// Define the unique item component.
		var component =
		{
			controller: name
			,
			controllerAs: "vm"
			,
			templateUrl: "/template/unique.html"
		}
		;

		// Create the unique item component.
		// Last modification:
		angular.module("app").component(name, component);
	}
)();
