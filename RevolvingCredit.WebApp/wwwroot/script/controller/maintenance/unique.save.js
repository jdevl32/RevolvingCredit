// /script/controller/maintenance/unique.save.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the unique item save controller.
		// Last modification:
		// Inject state-params (replacing route-params).
		function controller($stateParams, $window, itemService, apiService)
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
			// Last modification:
			var getItemDetail =
				function()
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

			// Create success handler for POST.
			// Last modification:
			// Refactor format success message.
			// Refactor debug response.
			var onPostSuccess =
				function (response)
				{
					// todo|jdevl32: ??? can this be delegated back to unique (parent) controller ???
					// Set success message in the item service that can be relayed back and displayed.
					//itemService.successMessage = vm.displayName + " " + action + "d.";
					itemService.successMessage = formatSuccessMessage("001", response, "response");

					// Clear/reset save unique item (form and item service).
					itemService.item = vm.item = {};

					// todo|jdevl32: ??? state.go ???
					// Redirect back to unique item view.
					$window.location.href = "#!/";
				}
			;

			// Create error handler for POST.
			// Last modification:
			// Refactor format error message.
			// Refactor debug response.
			var onPostError =
				function (response)
				{
					formatErrorMessage("002", response, "response");
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
			// Refactor format error message.
			// Refactor debug e(xception/rror).
			var doCatch =
				function(e)
				{
					doFinally();
					//vm.errorMessage = "[002] Failed to " + action + " " + vm.displayName + ":  " + toString(e);
					formatErrorMessage("003", e, "e");
				}
			;

			// todo|jdevl32: !!! needs to be injected (via ???) !!!
			//var url = "http://localhost:58410/api/APR";
			// Get the (API) URL from the item service.
			var url = itemService.url;

			// Form submit handler.
			// Last modification:
			vm.onSubmit =
				function ()
				{
					vm.isBusy = true;
					vm.errorMessage = "";
					action = "save";

					// Post the saved unique item to the API using the defined handlers.
					apiService.post(url, onPostSuccess, onPostError, doFinally, doCatch, vm.item);
				}
			;
		}

		// Use the existing module, specify controller.
		// Last modification:
		// Inject state-params (replacing route-params).
		angular
			.module("app-APR")
			.controller
				(
					"uniqueSave"
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
