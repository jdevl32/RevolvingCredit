// /script/controller/APR.js

// Exclude from global scope.
(
	function ()
	{
		"use strict";

		// Define the APR controller.
		// Last modification:
		// Inject item service dependency.
		function controller($http, itemService)
		{
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create empty container for error message.
			vm.errorMessage = "";

			// Get the success message from the item service.
			vm.successMessage = itemService.successMessage;

			// todo|jdevl32: no need to watch ?!?!
			/**
			// Create watch handler for success message.
			var watchSuccessMessage =
				function(newValue, oldValue)
				{
					vm.successMessage = newValue;
				};

			// Watch success message.
			//$watch("itemService.successMessage", watchSuccessMessage);
			/**/

			// Create empty container for APR(s).
			vm.items = [];

			// Create success handler for GET.
			var onGetSuccess =
				function (response)
				{
					// todo|jdevl32: make this global method...
					// todo|jdevl32: fix (is-dev not working) !!!
					if (vm.isDev)
					{
						debug(response, "response");
					} // if

					angular.copy(response.data, vm.items);
				};

			// Create error handler for GET.
			var onGetError =
				function (error)
				{
					// todo|jdevl32: make this global method...
					// todo|jdevl32: fix (is-dev not working) !!!
					if (vm.isDev)
					{
						debug(error, "error");
					} // if

					vm.errorMessage = "[001] Failed to get APRs:  " + toString(error);
				};

			// Create finally handler.
			var doFinally =
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				};

			// todo|jdevl32: ??? url to use ???
			var url = "http://localhost:58410/api/APR";

			try
			{
				$http
					// Get the APRs from the API...
					.get(url)
					// ...using the defined handlers.
					.then(onGetSuccess, onGetError)
					.finally(doFinally);
			} // try
			catch (e)
			{
				// Reset busy flag.
				vm.isBusy = false;
				vm.errorMessage = "[002] Failed to get APRs:  " + toString(e);
			} // catch

			// Create method to initiate (update) state.
			vm.onUpdate =
				function(index = null)
				{
					// Reset message(s);
					vm.errorMessage = itemService.errorMessage = "";
					vm.successMessage = itemService.successMessage = "";
					itemService.item = isNullOrUndefined(index) ? {} : vm.items[index];
				};
		}

		// Use the existing module, specify controller.
		// Last modification:
		// Inject item service dependency.
		angular.module("app-APR")
			.controller
				(
					"apr"
					,
					[
						"$http"
						,
						"itemService"
						,
						controller
					]
				);
	}
)();
