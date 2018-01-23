// /script/global.js

"use strict";

// Debug.
// Last modification:
// Qualify alert method.
function debug(value, valueName = "", separator = "\n", showAlert = false)
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

function isEmpty(value)
{
	return "" === value;
}

function isNullOrUndefined(object)
{
	return object === null || object === undefined;
}

// Convert (the object) to a string representation.
// Last modification:
// Enhance object string representation.
function toString(object, objectName = "", separator = "\n")
{
	var empty = isEmpty(objectName);
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

				if (!isEmpty(value))
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
