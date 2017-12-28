// /script/service/service/item.js

// Exclude from global scope.
(
	function ()
	{
		"use strict";

		// .
		// Last modification:
		function ItemService()
		{
			// The item for which this service holds.
			this.item = {};
		}

		// Create the service module.
		// Last modification:
		angular.module("service", [])
			.service("itemService", ItemService);
	}
)();
