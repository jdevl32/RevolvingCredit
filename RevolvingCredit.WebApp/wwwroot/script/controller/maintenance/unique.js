// /script/controller/maintenance/unique.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the unique item controller.
		// Last modification:
		// Add the (API) URL associated with the item.
		function controller($stateParams, $window, itemService, apiService)
		{
			// Define the view model.
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create action member.
			var action = "";

			// todo|jdevl32: !!! needs to be injected (via data ???) !!!
			//vm.displayName = "APR (type)";
			// Get the (view-model) display name from the state-params service.
			vm.displayName = $stateParams.displayName;

			// Set the (item service from the view-model) display name.
			itemService.displayName = vm.displayName;

			// Create method to reset state.
			// Last modification:
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

			// Create method to get item detail(s).
			// Last modification:
			var getItemDetail =
				function()
				{
					var item =
					{
						suffix: ""
						,
						detail: ""
					}
					;

					if (isNullOrUndefined(vm.index))
					{
						item.suffix = "(s)";
					} // if
					else
					{
						item.detail = " "
							+ "("
							+ toString(vm.items[vm.index])
							+ ")"
						;
					} // else

					return item;
				}
			;

			// todo|jdevl32: !!! refactor (with unique.save.js) !!!

			// Create method to debug.
			// Last modification:
			var doDebug =
				function(locator, message, detail, object, name)
				{
					// todo|jdevl32: debug (for now, but eventually need to log) ???
					debug
						(
							"[" 
							+ "[" 
							+ locator
							+ "] "
							+ message
							+ detail
							+ ".:  "
							+ name
							+ "="
							+ toString(object)
							+ "]"
						)
					;
				}
			;

			// Create format (error) message method (for display and debug).
			// Last modification:
			// Add item detail(s).
			// Segregate error (display and debug) message.
			// Refactor debug.
			// Add name (of object).
			var formatErrorMessage =
				function(locator, object, name)
				{
					var item = getItemDetail();
					vm.errorMessage = ""
						+ "Failed to "
						+ action
						+ " " 
						+ vm.displayName
						+ item.suffix
					;

					doDebug(locator, vm.errorMessage, item.detail, object, name);

					vm.errorMessage += ".";
					return vm.errorMessage;
				}
			;

			// Create format (success) message method (for display and debug).
			// Last modification:
			var formatSuccessMessage =
				function(locator, object, name)
				{
					var item = getItemDetail();
					vm.successMessage = ""
						+ vm.displayName
						+ item.suffix
						+ " " 
						+ action
						+ "d"
					;

					doDebug(locator, vm.successMessage, item.detail, object, name);

					vm.successMessage += ".";
					return vm.successMessage;
				}
			;

			// Create success handler for GET.
			// Last modification:
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
			// Refactor debug response.
			var onError =
				function (response)
				{
					formatErrorMessage("001", response, "response");
				}
			;

			// Create finally handler.
			// Last modification:
			var doFinally =
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				}
			;

			// Create catch handler.
			// Last modification:
			// Refactor debug e(xception/rror).
			var doCatch =
				function(e)
				{
					doFinally();
					formatErrorMessage("002", e, "e");
				}
			;

			// todo|jdevl32: !!! needs to be injected (via data ???) !!!
			//var url = "http://localhost:58410/api/APR";
			// Get the (API) URL from the state-params service.
			var url = $stateParams.url;

			// Set the (item service) (API) URL.
			itemService.url = url;

			// Create the entry method of this controller.
			// Last modification:
			var doGet =
				function()
				{
					// Reset the state for fresh get.
					reset();

					// Set (get) action.
					action = "get";

					// Get the unique item(s) from the API using the defined handlers.
					apiService.get(url, onGetSuccess, onError, doFinally, doCatch);
				}
			;

			// Invoke the entry method of this controller.
			doGet();

			// Create success handler for DELETE.
			// Last modification:
			// Refactor format success message.
			// Refactor debug response.
			var onDeleteSuccess =
				function (response)
				{
					//vm.successMessage =
					//	vm.displayName
					//	+ 
					//		(
					//			isNullOrUndefined(vm.index) 
					//			? 
					//			"s" 
					//			: 
					//			" ("
					//			+ toString(vm.items[vm.index])
					//			+ ")"
					//		)
					//	+ " "
					//	+ vm.action
					//	+ "d."
					//	;
					formatSuccessMessage("003", response, "response");

					// Invoke the entry method of this controller 
					// (as if refresh but without redirect or reload).
					doGet();
				}
			;

			// Create method to initiate (remove) state.
			// Last modification:
			vm.onRemove =
				function(index = null)
				{
					// Set the index to track.
					vm.index = index;
					vm.isBusy = true;
					vm.errorMessage = "";
					//vm.action = "remove";
					action = "remove";

					// Check if for all unique item(s) (invalid index).
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
			// Last modification:
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
		// Inject state-params.
		angular
			.module("app-APR")
			.controller
				(
					"unique"
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
