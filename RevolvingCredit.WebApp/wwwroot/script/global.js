// /script/global.js

"use strict";

// Debug.
var debug = 
	// Last modification:
	// Qualify alert method.
	function (value, valueName = "", separator = "\n", showAlert = false)
	{
		value = toString(value, valueName, separator);

		console.log(value);

		if (showAlert)
		{
			if ($window)
			{
				if ($window.alert)
				{
					$window.alert(value);
				} // if
			} // if

			if (window)
			{
				if (window.alert)
				{
					window.alert(value);
				} // if
			} // if
		} // if
	}
;

var isNullOrUndefinedOrEmpty =
	// @summary 
	// @param {} object 
	// @returns {} 
	// Last modification:
	function(object)
	{
		return _.isNull(object) 
			|| 
			_.isUndefined(object) 
			|| 
			_.isEmpty(object)
		;
	}
;

// Convert (the object) to a string representation.
var toString = 
	// Last modification:
	// (Re-)implement using underscore library.
	function (object, objectName = "", separator = "\n")
	{
		var empty = _.isEmpty(objectName);
		var value = empty ? objectName : "[" + objectName + "=";

		switch (typeof object)
		{
			case "string":
				value += object;
				break;

			default:
				for (var propertyName in object)
				{
					if (!object.hasOwnProperty(propertyName))
					{
						continue;
					} // if

					if (!_.isEmpty(value))
					{
						value += separator;
					} // if

					value += "[." + propertyName + "=" + object[propertyName] + "]";
				} // for

				break;
		} // switch

		if (!empty)
		{
			value += "]";
		} // if

		return value;
	}
;
