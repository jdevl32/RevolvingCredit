// /script/service/service/API.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the API service object.
		var APIService =
			// Last modification:
			// Refactor (use local method(s)).
			function ($http)
			{
				// Define DELETE method.
				var _delete = 
					// Last modification:
					function(url, onSuccess, onError, doFinally, doCatch, config = null)
					{
						try
						{
							$http
								// Delete the APR (type)(s) from the API...
								.delete(url, config)
								// ...using the provided handlers.
								.then(onSuccess, onError)
								.finally(doFinally)
							;
						} // try
						catch (e)
						{
							doCatch(e);
						} // catch
					}
				;

				// Define GET method.
				var _get = 
					// Last modification:
					function(url, onSuccess, onError, doFinally, doCatch)
					{
						try
						{
							$http
								// Get the APR (type)(s) from the API...
								.get(url)
								// ...using the provided handlers.
								.then(onSuccess, onError)
								.finally(doFinally)
							;
						} // try
						catch (e)
						{
							doCatch(e);
						} // catch
					}
				;

				// Define POST method.
				var _post = 
					// Last modification:
					function(url, onSuccess, onError, doFinally, doCatch, item)
					{
						try
						{
							$http
								// Post the APR (type) to the API...
								.post(url, item)
								// ...using the provided handlers.
								.then(onSuccess, onError)
								.finally(doFinally)
							;
						} // try
						catch (e)
						{
							doCatch(e);
						} // catch
					}
				;

				this.delete = _delete;
				this.get = _get;
				this.post = _post;
			}
		;

		// Define the service dependenc(y/ies).
		var dependency =
			[
				"$http"
				,
				APIService
			]
		;

		// Create the service module.
		// Last modification:
		angular.module("service").service("apiService", dependency);
	}
)();
