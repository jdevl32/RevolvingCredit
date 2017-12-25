// /script/controller/APR.edit.js

// Exclude from global scope.
(
	function ()
	{
		"use strict";

		// Define the APR edit controller.
		// Last modification:
		function controller($routeParams, $http)
		{
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Get the id of the APR to edit from the route params.
			vm.id = $routeParams.id;

			// Create empty container for error message.
			vm.errorMessage = "";

			// Create empty container for edit or new APR.
			vm.item = {};

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

					angular.copy(response.data, vm.item);
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

					vm.errorMessage = "[001] Failed to get APR:  " + toString(error);
				};

			// Create finally handler.
			var doFinally =
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				};

			// todo|jdevl32: ??? url to use ???
			var url = "http://localhost:58410/api/APR/" + vm.id;

			try
			{
				$http
					// Get the APR to edit from the API...
					.get(url)
					// ...using the defined handlers.
					.then(onGetSuccess, onGetError)
					.finally(doFinally);
			} // try
			catch (e)
			{
				// Reset busy flag.
				vm.isBusy = false;
				vm.errorMessage = "[002] Failed to get APR:  " + toString(e);
			} // catch

			// Create success handler for POST.
			var onPostSuccess =
				function (response)
				{
					// Add new APR to the container.
					vm.items.push(response.data);

					// Clear/reset new APR (form).
					vm.item = {};
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
						.post(url, vm.item)
						// ...using the defined handlers.
						.then(onPostSuccess, onPostError)
						.finally(doFinally);
				};
		}

		// Use the existing module, specify controller.
		angular.module("app-APR").controller("aprEdit", controller);
	}
)();
