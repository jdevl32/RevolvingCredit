// /script/component/maintenance/view.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (controller and component) name.
		var name = "view";

		// Define the (view) unique item component.
		var component =
		{
			controller: name
			,
			controllerAs: "vm"
			,
			templateUrl: "/template/maintenance/view.html"
		}
		;

		// Create the (view) unique item component.
		// Last modification:
		angular.module("app").component(name, component);
	}
)();
