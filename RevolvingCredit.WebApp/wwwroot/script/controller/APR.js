// /script/controller/APR.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the APR (type) controller.
		// Last modification:
		// Inject APR service.
		// Remove http service.
		function controller($window, itemService, aprService)
		{
			// Define the view model.
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create action member.
			var action = "";

			// Create method to reset state.
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

			// Create format (error) message method for display.
			// Last modification:
			// (Re-)implement action as controller member.
			var formatErrorMessage =
				function(locator, object)
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

			// Create error handler for (all) action(s).
			// Last modification:
			var onError =
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

					formatErrorMessage("001", response);
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
					formatErrorMessage("002", e);
				}
				;

			// todo|jdevl32: ??? url to use ???
			var url = "http://localhost:58410/api/APR";

			// Create main method of this controller.
			var doGet =
				function()
				{
					// Reset the state for fresh get.
					reset();

					// Set (get) action.
					action = "get";

					// Get the APR (type)(s) using the defined handlers.
					aprService.get(url, onGetSuccess, onError, doFinally, doCatch);

					/**
					try
					{
						$http
							// Get the APR (type)(s) from the API...
							.get(url)
							// ...using the defined handlers.
							.then(onGetSuccess, onError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						// Reset busy flag.
						vm.isBusy = false;

						formatErrorMessage("002", e);
					} // catch
					/**/
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

			/**
			// Create error handler for DELETE.
			var onDeleteError =
				function (response)
				{
					formatErrorMessage("001", response);
				}
				;
			/**/

			// Create method to initiate (remove) state.
			vm.onRemove =
				function(index = null)
				{
					// Set the index to track.
					vm.index = index;
					vm.isBusy = true;
					vm.errorMessage = "";

					// Check if for all (invalid index).
					if (isNullOrUndefined(index))
					{
						// Delete (all) the APR (type)s from the API...
						aprService.delete(url + "/*", onDeleteSuccess, onError, doFinally, doCatch);
					} // if
					else
					{
						// Delete...
						aprService.delete
							(
								url
								,
								onDeleteSuccess
								,
								onError
								,
								doFinally
								,
								doCatch
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

					/**
					try
					{
						var promise;

						// Check if for all (invalid index).
						if (isNullOrUndefined(index))
						{
							// Delete (all) the APR (type)s from the API...
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

						formatErrorMessage("002", e);
					} // catch
					/**/
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
		// Inject APR service.
		// Remove http service.
		angular
			.module("app-APR")
			.controller
				(
					"apr"
					,
					[
						"$window"
						,
						"itemService"
						,
						"aprService"
						,
						controller
					]
				)
				;
	}
)();
