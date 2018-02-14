// /script/controller/maintenance/view.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (view) unique item controller name.
		var viewName = "view";

		// Define the (view) unique item controller.
		var controller =
			// Last modification:
			// Remove log service (migrate to message service).
			// Inject message service.
			function ($stateParams, $window, apiService, itemService, messageService)
			{
				// Define the view model.
				var vm = this;
				vm.isBusy = true;
				vm.isDev = false;

				// Get the (view-model) display name from the state-params service.
				vm.displayName = $stateParams.displayName;

				// Set the (item service from the view-model) display name.
				itemService.displayName = vm.displayName;

				// Get the (optional) unique item template from the state-params service.
				vm.template = $stateParams.template;

				// Create action member.
				var action = "";

				// Create method to reset action state.
				var reset =
					// Last modification:
					function ()
					{
						// Create empty container for error message.
						vm.errorMessage = "";

						// Create null tracking index.
						vm.index = null;

						// Create empty container for unique item(s).
						vm.items = [];
					}
				;

				// Get the success message from the item service.
				vm.successMessage = itemService.successMessage;

				// Create method to get item detail(s).
				var getItemDetail =
					// Last modification:
					function ()
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

				// todo|jdevl32: refactor (with save.js) ???

				// Create method to format (error) message (for display and debug).
				var formatErrorMessage =
					// Last modification:
					// Refactor debug message.
					// Implement message service.
					function (locator, object, name)
					{
						return vm.errorMessage =
							messageService.debugErrorMessage
								(
									getItemDetail
									,
									action
									,
									vm.displayName
									,
									locator
									,
									object
									,
									name
								)
						;
					}
				;

				// Create method to format (success) message (for display and debug).
				var formatSuccessMessage =
					// Last modification:
					// Refactor debug message.
					// Implement message service.
					function (locator, object, name)
					{
						return vm.successMessage =
							messageService.debugSuccessMessage
								(
									getItemDetail
									,
									action
									,
									vm.displayName
									,
									locator
									,
									object
									,
									name
								)
						;
					}
				;

				// Create success handler for GET.
				var onGetSuccess =
					// Last modification:
					// Implement message service.
					function (response)
					{
						// todo|jdevl32: make this global method...
						// todo|jdevl32: fix (is-dev not working) --> 
						// probably is working, but need to "override" debug to use $window instead of window
						// see https://docs.angularjs.org/guide/expression discussion on "context"...
						if (vm.isDev || true)
						{
							messageService.doDebug("debug-onGetSuccess-001-view", "", "", response, "response");
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
						formatErrorMessage("002", response, "response");
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
					function (e)
					{
						doFinally();
						formatErrorMessage("003", e, "e");
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
						// Reset the action state for fresh get.
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
						formatSuccessMessage("001", response, "response");

						// Invoke the entry method of this controller 
						// (as if refresh but without redirect or reload).
						doGet();
					}
				;

				// Create method to initiate (remove) action state.
				vm.onRemove =
					// Last modification:
					// Implement message service.
					function (index = null)
					{
						// Set the index to track.
						vm.index = index;
						vm.isBusy = true;
						vm.errorMessage = "";
						action = "remove";

						// todo|jdevl32: remove (debug only)...
						messageService.debugMessage(getItemDetail, action, vm.displayName, "debug-vm.onRemove-001-view", vm, "vm");

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

				// Create method to initiate (save) action state.
				vm.onSave =
					// Last modification:
					// Implement message service.
					function (index = null)
					{
						// Reset message(s).
						vm.errorMessage = itemService.errorMessage = "";
						vm.successMessage = itemService.successMessage = "";
						itemService.item = isNullOrUndefined(index) ? {} : vm.items[index];
						// todo|jdevl32: only necessary if debug (below) - otherwise could set inline (debug, below) ???
						action = "save";

						// todo|jdevl32: remove (debug only)...
						messageService.debugMessage(getItemDetail, action, vm.displayName, "debug-vm.onSave-001-view", vm, "vm");
					}
				;
			}
		;

		// todo|jdevl32: constant(s)...

		// Define the module dependenc(y/ies).
		var dependency =
			[
				"$stateParams"
				,
				"$window"
				,
				"apiService"
				,
				"itemService"
				,
				"messageService"
				,
				controller
			]
		;

		// Using the existing app module, create the controller.
		// Last modification:
		angular.module("app").controller(viewName, dependency);
	}
)();
