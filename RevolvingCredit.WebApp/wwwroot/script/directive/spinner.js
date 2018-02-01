// /script/directive/spinner.js

// Exclude from global scope...
(
	function ()
	{
		"use strict";

		// Define the directive.
		var spinner = 
			// Last modification:
			function ()
			{
				return {
					// Restrict to element only.
					restrict: "E"
					,
					scope:
					{
						while: "="
					}
					,
					// Include the contents (inner-html) of the element.
					transclude: true
					,
					templateUrl: "/directive/spinner.html"
				}
				;
			}
		;

		// Define the module dependenc(y/ies).
		var dependency =
			[
			]
		;

		// Create the module and directive.
		angular.module("spinner", dependency).directive("spinner", spinner);
	}
)();
