// /script/controller/APR.edit.js

// Exclude from global scope.
(
	function ()
	{
		"use strict";

		// Define the APR edit controller.
		// Last modification:
		// Inject item service dependency.
		function controller($routeParams, $http, itemService)
		{
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create empty container for error message.
			vm.errorMessage = "";

			// Get the APR to edit from the item service.
			vm.item = itemService.item;

			// Create success handler for POST.
			var onPostSuccess =
				function (response)
				{
					// Clear/reset edit APR (form).
					vm.item = {};
				};

			// Create error handler for POST.
			var onPostError =
				function (error)
				{
					vm.errorMessage = "Failed to edit APR:  " + toString(error);
				};

			// Create finally handler.
			var doFinally =
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				};

			// todo|jdevl32: ??? url to use ???
			var url = "http://localhost:58410/api/APR/" + vm.item.id;

			// Form submit handler.
			vm.onSubmit =
				function ()
				{
					vm.isBusy = true;
					vm.errorMessage = "";

					$http
						// Post the modified APR to the API...
						.post(url, vm.item)
						// ...using the defined handlers.
						.then(onPostSuccess, onPostError)
						.finally(doFinally);
				};
		}

		// Use the existing module, specify controller.
		// Last modification:
		// Inject item service dependency.
		angular.module("app-APR")
			.controller
			(
				"aprEdit"
				,
				[
					"$routeParams"
					,
					"$http"
					,
					"itemService"
					,
					controller
				]
			);
	}
)();
