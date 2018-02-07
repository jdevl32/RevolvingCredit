// /script/service/service/item.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the Item service object.
		var ItemService =
			// Last modification:
			// Add the (API) URL associated with the item..
			function ()
			{
				// The display name for the item.
				this.displayName = "";

				// The (API) URL associated with the item.
				this.url = "";

				// The error message associated with the item.
				this.errorMessage = "";

				// The success message associated with the item.
				this.successMessage = "";

				// The item which this service holds.
				this.item = {};
			}
		;

		// Define the service dependenc(y/ies).
		var dependency = 
			[
				ItemService
			]
		;

		// Create the service module.
		// Last modification:
		// Use the dependency (array).
		angular.module("service").service("itemService", dependency);
	}
)();
