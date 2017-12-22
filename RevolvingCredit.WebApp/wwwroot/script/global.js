// /script/global.js

"use strict";

function debug(value, valueName = "", separator = "\n", showAlert = false)
{
	value = toString(value, valueName, separator);

	console.log(value);

	if (showAlert)
	{
		alert(value);
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

function toString(object, objectName = "", separator = "\n")
{
	var empty = isEmpty(objectName);
	var value = empty ? objectName : "[" + objectName + "=";

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

	if (!empty)
	{
		value += "]";
	} // if

	return value;
}
