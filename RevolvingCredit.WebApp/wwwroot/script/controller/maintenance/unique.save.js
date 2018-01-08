// /script/controller/maintenance/unique.save.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the unique item save controller.
		// Last modification:
		// Inject state-params (replacing route-params).
		function controller($stateParams, $window, itemService, apiService)
		{
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create action member.
			var action = "";

			// Get the display name from the item service.
			vm.displayName = itemService.displayName;

			// Create empty container for error message.
			vm.errorMessage = "";

			// Get the unique item to save from the item service.
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

					// Clear/reset save unique item (form and item service).
					itemService.item = vm.item = {};

					// todo|jdevl32: ??? can this be delegated back to unique (parent) controller ???
					// Set success message in the item service that can be relayed back and displayed.
					itemService.successMessage = vm.displayName + " " + action + "d.";

					// todo|jdevl32: ??? state.go ???
					// Redirect back to unique item view.
					$window.location.href = "#!/";
				}
			;

			// Create error handler for POST.
			var onPostError =
				function (response)
				{
					vm.errorMessage = "[001] Failed to " + action + " " + vm.displayName + ":  " + toString(response);
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
					vm.errorMessage = "[002] Failed to " + action + " " + vm.displayName + ":  " + toString(e);
				}
			;

			// todo|jdevl32: !!! needs to be injected (via ???) !!!
			var url = "http://localhost:58410/api/APR";

			// Form submit handler.
			vm.onSubmit =
				function ()
				{
					vm.isBusy = true;
					vm.errorMessage = "";
					action = "save";

					// Post the saved unique item to the API using the defined handlers.
					apiService.post(url, onPostSuccess, onPostError, doFinally, doCatch, vm.item);
				}
			;
		}

		// Use the existing module, specify controller.
		// Last modification:
		// Inject state-params (replacing route-params).
		angular
			.module("app-APR")
			.controller
				(
					"uniqueSave"
					,
					[
						"$stateParams"
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
