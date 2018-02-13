// /script/controller/maintenance/save.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the (save) unique item controller.
		var controller =
			// Last modification:
			// Inject state service dependency.
			function ($state, $stateParams, $window, apiService, itemService, messageService)
			{
				// Define the view-model.
				var vm = this;
				vm.isBusy = true;
				vm.isDev = false;

				// Get the (view-model) display name from the item service.
				vm.displayName = itemService.displayName;

				// Create the (view-model) error message.
				vm.errorMessage = "";

				// Get the unique item to save (for the view-model) from the item service.
				vm.item = itemService.item;

				// Get the (optional) unique item template from the state-params service.
				vm.template = $stateParams.template;

				// Create action member.
				var action = "";

				// Create method to get item detail(s).
				var getItemDetail =
					// Last modification:
					function ()
					{
						return {
							suffix: ""
							,
							detail: " "
								+ "("
								+ toString(vm.item)
								+ ")"
						}
						;
					}
				;

				// todo|jdevl32: refactor (with view.js) ???

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

				// Create success handler for (all) API method(s).
				var onSuccess =
					// Last modification:
					function (response)
					{
						// todo|jdevl32: ??? can this be delegated back to unique (parent) controller ???
						// Set success message in the item service that can be relayed back and displayed.
						itemService.successMessage = formatSuccessMessage("001", response, "response");

						// Clear/reset save unique item (form and item service).
						itemService.item = vm.item = {};

						// Redirect back to unique item view (parent state).
						$state.go("^");
					}
				;

				// Create error handler for (all) API method(s).
				var onError =
					// Last modification:
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
					// Refactor format error message.
					// Refactor debug e(xception/rror).
					function (e)
					{
						doFinally();
						formatErrorMessage("003", e, "e");
					}
				;

				// Get the (API) URL from the item service.
				var url = itemService.url;

				// Create method to check save (new) action state.
				vm.isNew =
					// Last modification:
					// Enhance save (new) action state determination.
					function ()
					{
						// The unique item key (property) is the id.
						var key = "id";

						// The save action state is new...
						// ...if the unique item is empty...
						return _.isEmpty(vm.item)
						// ...or, if the unique item key (id) value is undefined...
							|| !_.has(vm.item, key)
						// ...or, if the unique item key (id) value is invalid (zero).
							|| 0 === _.property(key)(vm.item)
						;
					}
				;

				// Create method to initiate (cancel) action state.
				vm.onCancel =
					// Last modification:
					function()
					{
						// Reset message(s).
						vm.errorMessage = itemService.errorMessage = "";
						vm.successMessage = itemService.successMessage = "";
						itemService.item = {};
						// todo|jdevl32: only necessary if debug (below) - otherwise could set inline (debug, below) ???
						action = "cancel";

						// todo|jdevl32: remove (debug only)...
						messageService.debugMessage(getItemDetail, action, vm.displayName, "debug-vm.onCancel-001-save", vm, "vm");
					}
				;

				// Create method to initiate (remove) action state.
				vm.onRemove =
					// Last modification:
					function ()
					{
						vm.isBusy = true;
						vm.errorMessage = "";
						action = "remove";

						// todo|jdevl32: remove (debug only)...
						messageService.debugMessage(getItemDetail, action, vm.displayName, "debug-vm.onRemove-001-save", vm, "vm");

						// Delete the unique item from the API using the defined handlers.
						apiService.delete
							(
								url
								,
								onSuccess
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
									data: vm.item
								}
							)
						;
					}
				;

				// Form submit handler.
				vm.onSubmit =
					// Last modification:
					// Implement message service.
					function ()
					{
						vm.isBusy = true;
						vm.errorMessage = "";
						action = "save";

						// todo|jdevl32: remove (debug only)...
						messageService.debugMessage(getItemDetail, action, vm.displayName, "debug-vm.onSubmit-001-save", vm, "vm");

						// Post the saved unique item to the API using the defined handlers.
						apiService.post(url, onSuccess, onError, doFinally, doCatch, vm.item);
					}
				;
			}
		;

		// todo|jdevl32: constant(s)...

		// Define the module dependenc(y/ies).
		// Last modification:
		// Inject state service dependency.
		var dependency =
			[
				"$state"
				,
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

		// Use the existing module, specify controller.
		// Last modification:
		angular.module("app").controller("save", dependency);
	}
)();
