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
					// Get the set of APRs from the API...
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

			// Create empty container for edit/new APR.
			vm.item = {};

			// Create method to determine edit state.
			vm.isEdit =
				function()
				{
					return !$.isEmptyObject(vm.item);
				};

			// Create method to initiate edit state.
			vm.onEdit =
				function(index)
				{
					vm.item = vm.items[index];
				};

			// Create success handler for POST.
			var onPostSuccess =
				function (response)
				{
					// todo|jdevl32: ??? distinguish between edit/new ???
					// Add new APR to the container.
					vm.items.push(response.data);

					// Clear/reset edit/new APR (form).
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
		angular.module("app-APR").controller("apr", controller);
	}
)();
