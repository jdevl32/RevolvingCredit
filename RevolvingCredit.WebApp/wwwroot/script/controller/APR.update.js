// /script/controller/APR.update.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the APR update controller.
		// Last modification:
		// Inject API service.
		// Remove http service.
		function controller($routeParams, $window, itemService, apiService)
		{
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create empty container for error message.
			vm.errorMessage = "";

			// Get the APR to update from the item service.
			vm.item = itemService.item;

			// Create success handler for POST.
			var onPostSuccess =
				function (response)
				{
					// todo|jdevl32: make this global method...
					// todo|jdevl32: fix (is-dev not working) !!!
					if (vm.isDev)
					{
						debug(response, "response");
					} // if

					// Clear/reset update APR (form and item service).
					itemService.item = vm.item = {};

					// Set success message in the item service that can be relayed back and displayed.
					itemService.successMessage = "APR saved.";

					// Redirect back to APR view.
					$window.location.href = "#!/";
				}
			;

			// Create error handler for POST.
			var onPostError =
				function (response)
				{
					vm.errorMessage = "[001] Failed to save APR:  " + toString(response);
				}
			;

			// Create finally handler.
			var doFinally =
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				}
			;

			// Create catch handler.
			var doCatch =
				function(e)
				{
					doFinally();
					vm.errorMessage = "[002] Failed to save APR:  " + toString(e);
				}
			;

			// todo|jdevl32: ??? url to use ???
			//var url = "http://localhost:58410/api/APR/" + vm.item.id;
			var url = "http://localhost:58410/api/APR";

			// Form submit handler.
			vm.onSubmit =
				function ()
				{
					vm.isBusy = true;
					vm.errorMessage = "";

					// Post the saved APR to the API using the defined handlers.
					apiService.post(url, onPostSuccess, onPostError, doFinally, doCatch, vm.item);
				}
			;
		}

		// Use the existing module, specify controller.
		// Last modification:
		// Inject API service.
		// Remove http service.
		angular
			.module("app-APR")
			.controller
				(
					"aprUpdate"
					,
					[
						"$routeParams"
						,
						"$window"
						,
						"itemService"
						,
						"apiService"
						,
						controller
					]
				)
		;
	}
)();
