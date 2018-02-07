// /script/service/service/message.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the Message service object.
		var MessageService =
			// Last modification:
			function ($log)
			{
				// Create method to debug.
				var _doDebug =
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

				// Create method to (debug and display) message.
				var _doDebugMessage =
					// Last modification:
					function (getDetailMethod, getMessageMethod, action, displayName, locator, object, name)
					{
						var arg = getDetailMethod();
						var message = getMessageMethod(action, displayName, arg.suffix);

						_doDebug(locator, message, arg.detail, object, name);

						message += ".";
						return message;
					}
				;

				// Create method to get message (for display and debug).
				var _getDebugMessage =
					// Last modification:
					function (action, displayName, suffix)
					{
						return ""
							+ "Action :="
							+ action
							+ " "
							+ displayName
							+ suffix
						;
					}
				;

				// Create method to get (error) message (for display and debug).
				var _getErrorMessage =
					// Last modification:
					function (action, displayName, suffix)
					{
						return ""
							+ "Failed to "
							+ action
							+ " "
							+ displayName
							+ suffix
						;
					}
				;

				// Create method to get (success) message (for display and debug).
				var _getSuccessMessage =
					// Last modification:
					function (action, displayName, suffix)
					{
						return ""
							+ displayName
							+ suffix
							+ " "
							+ action
							+ "d"
						;
					}
				;

				// Create method to display and debug (error) message.
				var _debugErrorMessage =
					// Last modification:
					function (getDetailMethod, action, displayName, locator, object, name)
					{
						return _doDebugMessage
							(
								getDetailMethod
								,
								_getErrorMessage
								,
								action
								,
								displayName
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

				// Create method to display and debug message.
				var _debugMessage =
					// Last modification:
					function (getDetailMethod, action, displayName, locator, object, name)
					{
						return _doDebugMessage
							(
								getDetailMethod
								,
								_getDebugMessage
								,
								action
								,
								displayName
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

				// Create method to display and debug (success) message.
				var _debugSuccessMessage =
					// Last modification:
					function (getDetailMethod, action, displayName, locator, object, name)
					{
						return _doDebugMessage
							(
								getDetailMethod
								,
								_getSuccessMessage
								,
								action
								,
								displayName
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

				this.doDebug = _doDebug;
				this.doDebugMessage = _doDebugMessage;
				this.getDebugMessage = _getDebugMessage;
				this.getErrorMessage = _getErrorMessage;
				this.getSuccessMessage = _getSuccessMessage;
				this.debugErrorMessage = _debugErrorMessage;
				this.debugMessage = _debugMessage;
				this.debugSuccessMessage = _debugSuccessMessage;
			}
		;

		// Define the service dependenc(y/ies).
		var dependency = 
			[
				"$log"
				,
				MessageService
			]
		;

		// Create the service module.
		// Last modification:
		// Use the dependency (array).
		angular.module("service").service("messageService", dependency);
	}
)();
