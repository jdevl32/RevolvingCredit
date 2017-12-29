// /script/service/service/item.js

// Exclude from global scope.
(
	function ()
	{
		"use strict";

		// Item service object.
		// Last modification:
		// Add message(s).
		function ItemService()
		{
			// The error message associated with the item.
			this.errorMessage = "";

			// The success message associated with the item.
			this.successMessage = "";

			// The item which this service holds.
			this.item = {};
		}

		// Create the service module.
		// Last modification:
		angular.module("service", [])
			.service("itemService", ItemService);
	}
)();
