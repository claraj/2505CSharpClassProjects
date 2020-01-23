using System;
using System.Text.Json.Serialization;

public class APODResponse
{
	public String Copyright { get; set; } = "Image credit: NASA";  // default property value
	
	public String Date { get; set; }

	public String Explanation { get; set; }
	
	public String Hdurl { get; set; } 

	[JsonPropertyName("media_type")]
	public String MediaType { get; set; }

	[JsonPropertyName("service_version")]
	public String ServiceVersion { get; set; }

	public String Title { get; set; }

	[JsonPropertyName("url")]
	public String ImageUrl { get; set; }

	public string FileSavePath { get; set; }

	public override string ToString()
	{
		return $"TITLE: {Title} \nDATE: {Date} \nEXPLANATION: {Explanation} \nCREDIT: {Copyright}";
	}

}
