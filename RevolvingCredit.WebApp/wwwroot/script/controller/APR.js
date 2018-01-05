// /script/controller/APR.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the APR (type) controller.
		// Last modification:
		// Inject window service.
		function controller($http, $window, itemService)
		{
			// Define the view model.
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Reset.
			var reset =
				function()
				{
					// Create empty container for error message.
					vm.errorMessage = "";

					// Create null tracking index.
					vm.index = null;

					// Create empty container for APR (type)(s).
					vm.items = [];

					/**
					// Create empty container for partial message.
					vm.partialMessage = "";
					/**/
				}
				;

			// Get the success message from the item service.
			vm.successMessage = itemService.successMessage;

			// Format (error) message for display.
			var formatErrorMessage =
				function(locator, action, object)
				{
					vm.errorMessage = 
						"[" 
						+ locator
						+ "] Failed to "
						+ action
						+ " APR (type)"
						+
							(
								isNullOrUndefined(vm.index)
								?
								"(s)"
								:
								" (" 
								+ toString(vm.items[vm.index]) 
								+ ")"
							) 
						+ ":  "
						+ toString(object)
						;
				}
				;

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
				}
				;

			// Create error handler for GET.
			var onGetError =
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

					formatErrorMessage("001", "get", response);
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

			// todo|jdevl32: ??? url to use ???
			var url = "http://localhost:58410/api/APR";

			// Create main method of this controller.
			var doGet =
				function()
				{
					reset();

					try
					{
						$http
							// Get the APR (type)(s) from the API...
							.get(url)
							// ...using the defined handlers.
							.then(onGetSuccess, onGetError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						// Reset busy flag.
						vm.isBusy = false;

						formatErrorMessage("002", "get", e);
					} // catch
				}
				;

			// Invoke the main method of this controller.
			doGet();

			// Create success handler for DELETE.
			var onDeleteSuccess =
				function (response)
				{
					vm.successMessage =
						"APR (type)"
						+ 
							(
								isNullOrUndefined(vm.index) 
								? 
								"s" 
								: 
								" ("
								+ toString(vm.items[vm.index])
								+ ")"
							)
						+ " removed."
						;

					// todo|jdevl32: make this global method...
					// todo|jdevl32: fix (is-dev not working) --> 
					// probably is working, but need to "override" debug to use $window instead of window
					// see https://docs.angularjs.org/guide/expression discussion on "context"...
					if (vm.isDev)
					{
						debug(response, "response");
					} // if

					// Invoke the main method of this controller 
					// (as if refresh but without redirect or reload).
					doGet();
				};

			// Create error handler for DELETE.
			var onDeleteError =
				function (response)
				{
					formatErrorMessage("001", "remove", response);
				}
				;

			// Create method to initiate (remove) state.
			vm.onRemove =
				function(index = null)
				{
					// Set the index to track.
					vm.index = index;
					vm.isBusy = true;
					vm.errorMessage = "";

					try
					{
						var promise;

						if (isNullOrUndefined(index))
						{
							// Delete the APR (type)s from the API...
							promise = $http.delete(url + "/*");
						} // if
						else
						{
							// Delete...
							promise = $http.delete
								(
									url
									,
									{
										headers:
										{
											"Content-Type": "application/json"
										}
										,
										// ...the APR (type) from the API...
										data: vm.items[index]
									}
								)
								;
						} // else

						promise
							// ...using the defined handlers.
							.then(onDeleteSuccess, onDeleteError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						// Reset busy flag.
						vm.isBusy = false;

						formatErrorMessage("002", "remove", e);
					} // catch
				}
				;

			// Create method to initiate (update) state.
			vm.onUpdate =
				function(index = null)
				{
					// Reset message(s);
					vm.errorMessage = itemService.errorMessage = "";
					vm.successMessage = itemService.successMessage = "";
					itemService.item = isNullOrUndefined(index) ? {} : vm.items[index];
				}
				;
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
				)
				;
	}
)();
