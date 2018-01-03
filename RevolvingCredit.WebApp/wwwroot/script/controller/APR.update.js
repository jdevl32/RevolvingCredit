// /script/controller/APR.update.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the APR update controller.
		// Last modification:
		// Inject window.
		function controller($http, $routeParams, $window, itemService)
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
					itemService.successMessage = "APR updated.";

					// Redirect back to APR view.
					$window.location.href = "#!/";
				};

			// Create error handler for POST.
			var onPostError =
				function (error)
				{
					vm.errorMessage = "[001] Failed to update APR:  " + toString(error);
				};

			// Create finally handler.
			var doFinally =
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				};

			// todo|jdevl32: ??? url to use ???
			//var url = "http://localhost:58410/api/APR/" + vm.item.id;
			var url = "http://localhost:58410/api/APR";

			// Form submit handler.
			vm.onSubmit =
				function ()
				{
					vm.isBusy = true;
					vm.errorMessage = "";

					try
					{
						$http
							// Post the updated APR to the API...
							.post(url, vm.item)
							// ...using the defined handlers.
							.then(onPostSuccess, onPostError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						// Reset busy flag.
						vm.isBusy = false;
						vm.errorMessage = "[002] Failed to update APR:  " + toString(e);
					} // catch
				};
		}

		// Use the existing module, specify controller.
		// Last modification:
		// Rename controller.
		angular.module("app-APR")
			.controller
			(
				"aprUpdate"
				,
				[
					"$http"
					,
					"$routeParams"
					,
					"$window"
					,
					"itemService"
					,
					controller
				]
			);
	}
)();
