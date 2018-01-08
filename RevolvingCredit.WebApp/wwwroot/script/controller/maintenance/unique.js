// /script/controller/maintenance/unique.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the unique item controller.
		// Last modification:
		function controller($window, itemService, apiService)
		{
			// Define the view model.
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create action member.
			var action = "";

			// todo|jdevl32: !!! needs to be injected (via data ???) !!!
			vm.displayName = "APR (type)";

			itemService.displayName = vm.displayName;

			// Create method to reset state.
			var reset =
				function()
				{
					// Create empty container for error message.
					vm.errorMessage = "";

					// Create null tracking index.
					vm.index = null;

					// Create empty container for unique item(s).
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
						+ " " 
						+ vm.displayName
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

			// Create error handler for (all) API method(s).
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

			// todo|jdevl32: !!! needs to be injected (via data ???) !!!
			var url = "http://localhost:58410/api/APR";

			// Create main method of this controller.
			var doGet =
				function()
				{
					// Reset the state for fresh get.
					reset();

					// Set (get) action.
					action = "get";

					// Get the unique item(s) using the defined handlers.
					apiService.get(url, onGetSuccess, onError, doFinally, doCatch);
				}
			;

			// Invoke the main method of this controller.
			doGet();

			// Create success handler for DELETE.
			var onDeleteSuccess =
				function (response)
				{
					vm.successMessage =
						vm.displayName
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
						+ " "
						+ vm.action
						+ "d."
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
					vm.action = "remove";

					// Check if for all (invalid index).
					if (isNullOrUndefined(index))
					{
						// Delete (all) the unique item(s) from the API using the defined handlers.
						apiService.delete(url + "/*", onDeleteSuccess, onError, doFinally, doCatch);
					} // if
					else
					{
						// Delete the unique item from the API using the defined handlers.
						apiService.delete
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
									data: vm.items[index]
								}
							)
						;
					} // else
				}
			;

			// Create method to initiate (save) state.
			vm.onSave =
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
		angular
			.module("app-APR")
			.controller
				(
					"unique"
					,
					[
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
