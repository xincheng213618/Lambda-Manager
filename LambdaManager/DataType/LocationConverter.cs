using System;
using LambdaManager.Core;

namespace LambdaManager.DataType;

internal class LocationConverter
{
	internal Location Location { get; set; } = new Location();


	internal string? Key { get; set; }

	internal Converter? Converter { get; set; } = new Converter(Convert.ToString);


	internal bool IsGetAddress { get; set; }
}
