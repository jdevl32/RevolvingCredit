// /script/controller/APR.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the APR controller.
		// Last modification:
		// Inject window service.
		function controller($http, $window, itemService)
		{
			// Define the view model.
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create empty container for error message.
			vm.errorMessage = "";

			// Get the success message from the item service.
			vm.successMessage = itemService.successMessage;

			// Create empty container for APR(s).
			vm.items = [];

			// Create success handler for GET.
			var onGetSuccess =
				function (response)
				{
					// todo|jdevl32: make this global method...
					// todo|jdevl32: fix (is-dev not working) --> 
					// probably is working, but need to "override" debug to use $window instead of window
					// see https://docs.angularjs.org/guide/expression discussion on "context"...
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
					// todo|jdevl32: fix (is-dev not working) --> 
					// probably is working, but need to "override" debug to use $window instead of window
					// see https://docs.angularjs.org/guide/expression discussion on "context"...
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

			// Create main method of this controller.
			var doGet =
				function()
				{
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
				};

			// Invoke the main method of this controller.
			doGet();

			// Create success handler for DELETE.
			var onDeleteSuccess =
				function (response)
				{
					// todo|jdevl32: make this global method...
					// todo|jdevl32: fix (is-dev not working) --> 
					// probably is working, but need to "override" debug to use $window instead of window
					// see https://docs.angularjs.org/guide/expression discussion on "context"...
					if (vm.isDev)
					{
						debug(response, "response");
					} // if

					vm.successMessage = "APR removed.";

					// Invoke the main method of this controller 
					// (as if refresh but without redirect or reload).
					doGet();
				};

			// Create error handler for DELETE.
			var onDeleteError =
				function (error)
				{
					vm.errorMessage = "[001] Failed to remove APR:  " + toString(error);
				};

			// Create method to initiate (remove) state.
			vm.onRemove =
				function(index = null)
				{
					// todo|jdevl32: implement remove all (null index)...
					//itemService.item = isNullOrUndefined(index) ? {} : vm.items[index];
					vm.isBusy = true;
					vm.errorMessage = "";

					try
					{
						$http
							// Delete the APR from the API...
							.delete
								(
									url
									,
									{
										headers:
										{
											"Content-Type": "application/json"
										}
										,
										data: vm.items[index]
									}
								)
							// ...using the defined handlers.
							.then(onDeleteSuccess, onDeleteError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						// Reset busy flag.
						vm.isBusy = false;
						vm.errorMessage = "[002] Failed to remove APR:  " + toString(e);
					} // catch
				};

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
		// Inject window service.
		angular.module("app-APR")
			.controller
				(
					"apr"
					,
					[
						"$http"
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
