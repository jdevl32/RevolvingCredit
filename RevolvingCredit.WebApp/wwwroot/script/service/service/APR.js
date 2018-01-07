// /script/service/service/APR.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// APR service object.
		// Last modification:
		function APRService($http)
		{
			// Define DELETE method.
			// Last modification:
			this.delete = 
				function(url, onSuccess, onError, doFinally, doCatch, config = null)
				{
					try
					{
						$http
							// Delete the APR (type)(s) from the API...
							.delete(url, config)
							// ...using the provided handlers.
							.then(onSuccess, onError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						doCatch(e);
					} // catch
				}
				;

			// Define GET method.
			// Last modification:
			this.get = 
				function(url, onSuccess, onError, doFinally, doCatch)
				{
					try
					{
						$http
							// Get the APR (type)(s) from the API...
							.get(url)
							// ...using the provided handlers.
							.then(onSuccess, onError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						doCatch(e);
					} // catch
				}
				;

			// Define POST method.
			// Last modification:
			this.post = 
				function(url, onSuccess, onError, doFinally, doCatch, item)
				{
					try
					{
						$http
							// Post the APR (type) to the API...
							.post(url, item)
							// ...using the provided handlers.
							.then(onSuccess, onError)
							.finally(doFinally);
					} // try
					catch (e)
					{
						doCatch(e);
					} // catch
				}
				;
		}

		// Create the service module.
		// Last modification:
		angular
			.module("service")
			.service
				(
					"aprService"
					,
					[
						"$http"
						,
						APRService
					]
				)
			;
	}
)();
