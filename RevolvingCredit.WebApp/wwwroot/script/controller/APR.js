// /script/controller/APR.js

// Exclude from global scope.
(
	function ()
	{
		"use strict";

		// Define the APR controller.
		// Last modification:
		function controller($http)
		{
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create empty container for error message.
			vm.errorMessage = "";

			// Create empty container for APR(s).
			vm.APR = [];

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

					angular.copy(response.data, vm.APR);
				};

			// Create error handler for GET.
			var onGetError =
				function (error)
				{
					vm.errorMessage = "[001] Failed to get APRs:  " + toString(error);
				};

			// Create finally handler.
			var doFinally =
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				};

			var url = "/api/APR";

			try
			{
				$http
					// Get the set of APRs from the API...
					.get(url)
					// ...Using the defined handlers.
					.then(onGetSuccess, onGetError)
					.finally(doFinally);
			} // try
			catch (e)
			{
				vm.isBusy = false;
				vm.errorMessage = "[002] Failed to get APRs:  " + toString(e);
			} // catch

			// Create empty container for new APR.
			vm.new = {};

			// Create success handler for POST.
			var onPostSuccess =
				function (response)
				{
					// Add new APR to the container.
					vm.APR.push(response.data);

					// Clear/reset new APR (form).
					vm.new = {};
				};

			// Create error handler for POST.
			var onPostError =
				function (error)
				{
					vm.errorMessage = "Failed to save APR:  " + toString(error);
				};

			// Form submit handler.
			vm.onSubmit =
				function ()
				{
					vm.isBusy = true;
					vm.errorMessage = "";

					$http
						// Post the new APR to the API...
						.post(url, vm.new)
						// ...Using the defined handlers.
						.then(onPostSuccess, onPostError)
						.finally(doFinally);
				};
		}

		// Use the existing module, specify controller.
		angular.module("app-APR").controller("APR", controller);
	}
)();
