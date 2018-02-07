// /script/controller/maintenance/unique.save.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the unique item save controller.
		var controller =
			// Last modification:
			// Inject log service.
			function ($log, $stateParams, $window, itemService, apiService)
			{
				// Define the view-model.
				var vm = this;
				vm.isBusy = true;
				vm.isDev = false;

				// Create action member.
				var action = "";

				// Get the (view-model) display name from the item service.
				vm.displayName = itemService.displayName;

				// Create the (view-model) error message.
				vm.errorMessage = "";

				// Get the unique item to save (for the view-model) from the item service.
				vm.item = itemService.item;

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

				// todo|jdevl32: !!! refactor (with unique.js) !!!

				// Create method to debug.
				var doDebug =
					// Last modification:
					// (Re-)implement log/debug.
					function (locator, message, detail, object, name)
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

				// Create (debug and display) message method.
				var debugMessage =
					// Last modification:
					function (locator, getMessageMethod, itemAction, displayName, object, name)
					{
						var item = getItemDetail();
						var message = getMessageMethod(itemAction, displayName, item.suffix);

						doDebug(locator, message, item.detail, object, name);

						message += ".";
						return message;
					}
				;

				// Create get message method (for display and debug).
				var getDebugMessage =
					// Last modification:
					function (itemAction, displayName, itemSuffix)
					{
						return ""
							+ "Action :="
							+ itemAction
							+ " "
							+ displayName
							+ itemSuffix
						;
					}
				;

				// Create get (error) message method (for display and debug).
				var getErrorMessage =
					// Last modification:
					function (itemAction, displayName, itemSuffix)
					{
						return ""
							+ "Failed to "
							+ itemAction
							+ " "
							+ displayName
							+ itemSuffix
						;
					}
				;

				// Create get (success) message method (for display and debug).
				var getSuccessMessage =
					// Last modification:
					function (itemAction, displayName, itemSuffix)
					{
						return ""
							+ displayName
							+ itemSuffix
							+ " "
							+ itemAction
							+ "d"
						;
					}
				;

				// Create format (error) message method (for display and debug).
				var formatErrorMessage =
					// Last modification:
					// Refactor get message.
					function (locator, object, name)
					{
						return vm.errorMessage =
							debugMessage
								(
									locator
									,
									getErrorMessage
									,
									action
									,
									vm.displayName
									,
									object
									,
									name
								)
						;
					}
				;

				// Create format (success) message method (for display and debug).
				var formatSuccessMessage =
					// Last modification:
					// Refactor get message.
					function (locator, object, name)
					{
						return vm.successMessage =
							debugMessage
								(
									locator
									,
									getSuccessMessage
									,
									action
									,
									vm.displayName
									,
									object
									,
									name
								)
						;
					}
				;

				// Create success handler for POST.
				var onPostSuccess =
					// Last modification:
					// Refactor format success message.
					// Refactor debug response.
					function (response)
					{
						// todo|jdevl32: ??? can this be delegated back to unique (parent) controller ???
						// Set success message in the item service that can be relayed back and displayed.
						itemService.successMessage = formatSuccessMessage("001", response, "response");

						// Clear/reset save unique item (form and item service).
						itemService.item = vm.item = {};

						// todo|jdevl32: ??? state.go ???
						// Redirect back to unique item view.
						$window.location.href = "#!/";
					}
				;

				// Create error handler for POST.
				var onPostError =
					// Last modification:
					// Refactor format error message.
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

				// Form submit handler.
				vm.onSubmit =
					// Last modification:
					function ()
					{
						vm.isBusy = true;
						vm.errorMessage = "";
						action = "save";

						// todo|jdevl32: remove (debug only)...
						debugMessage("debug-vm.onSubmit-001", getDebugMessage, action, vm.displayName, vm, "vm");

						// Post the saved unique item to the API using the defined handlers.
						apiService.post(url, onPostSuccess, onPostError, doFinally, doCatch, vm.item);
					}
				;
			}
		;

		// Define the module dependenc(y/ies).
		var dependency =
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
		;

		// Use the existing module, specify controller.
		// Last modification:
		// Inject log service.
		angular.module("app").controller("uniqueSave", dependency);
	}
)();
