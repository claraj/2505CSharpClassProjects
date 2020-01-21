using System;

public class APODResponse
{
	public String copyright { get; set; } = "Image credit: NASA";  // default property value
	public String date { get; set; }
	public String explanation { get; set; }
	String hdurl;
	public String media_type { get; set; }
	String service_version;
	public String title { get; set; }
	public String url { get; set; }
	public string fileSavePath { get; set; } 

	public override string ToString()
	{
		return $"TITLE: {title} \nDATE: {date} \nEXPLANATION: {explanation} \nCREDIT: {copyright}";
	}

}
