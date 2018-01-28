// /script/controller/maintenance/unique.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the unique item controller.
		// Last modification:
		// Inject log service.
		function controller($log, $stateParams, $window, itemService, apiService)
		{
			// Define the view model.
			var vm = this;
			vm.isBusy = true;
			vm.isDev = false;

			// Create action member.
			var action = "";

			// Get the (view-model) display name from the state-params service.
			vm.displayName = $stateParams.displayName;

			// Set the (item service from the view-model) display name.
			itemService.displayName = vm.displayName;

			// Create method to reset state.
			var reset =
				// Last modification:
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
			var getItemDetail =
				// Last modification:
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
			var doDebug =
				// Last modification:
				// Add log service.
				function(locator, message, detail, object, name)
				{
					// todo|jdevl32: debug (for now, but eventually need to log) ???
					$log.debug
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
			var formatErrorMessage =
				// Last modification:
				// Add item detail(s).
				// Segregate error (display and debug) message.
				// Refactor debug.
				// Add name (of object).
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
			var formatSuccessMessage =
				// Last modification:
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
			var onGetSuccess =
				// Last modification:
				// (Re-)implement log/debug.
				function (response)
				{
					// todo|jdevl32: make this global method...
					// todo|jdevl32: fix (is-dev not working) --> 
					// probably is working, but need to "override" debug to use $window instead of window
					// see https://docs.angularjs.org/guide/expression discussion on "context"...
					if (vm.isDev || true)
					{
						$log.debug(toString(response, "response"));
					} // if

					angular.copy(response.data, vm.items);
				}
			;

			// Create error handler for (all) API method(s).
			var onError =
				// Last modification:
				// Refactor debug response.
				function (response)
				{
					formatErrorMessage("001", response, "response");
				}
			;

			// Create finally handler.
			var doFinally =
				// Last modification:
				function ()
				{
					// Reset busy flag.
					vm.isBusy = false;
				}
			;

			// Create catch handler.
			var doCatch =
				// Last modification:
				// Refactor debug e(xception/rror).
				function(e)
				{
					doFinally();
					formatErrorMessage("002", e, "e");
				}
			;

			// Get the (API) URL from the state-params service.
			var url = $stateParams.url;

			// Set the (item service) (API) URL.
			itemService.url = url;

			// Create the entry method of this controller.
			var doGet =
				// Last modification:
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
			var onDeleteSuccess =
				// Last modification:
				// Refactor format success message.
				// Refactor debug response.
				function (response)
				{
					formatSuccessMessage("003", response, "response");

					// Invoke the entry method of this controller 
					// (as if refresh but without redirect or reload).
					doGet();
				}
			;

			// Create method to initiate (remove) state.
			vm.onRemove =
				// Last modification:
				function(index = null)
				{
					// Set the index to track.
					vm.index = index;
					vm.isBusy = true;
					vm.errorMessage = "";
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
			vm.onSave =
				// Last modification:
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
		// Inject log service.
		angular
			.module("app")
			.controller
				(
					"unique"
					,
					[
						"$log"
						,
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
