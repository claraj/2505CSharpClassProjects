using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace APOD
{
    class APOD
    {
        public static APODResponse fetchAPOD(out string errorMessage, DateTime? forDate = null, string imageSavePath = null)
        {
            WebClient client = new WebClient();
            using (client)
            {
                string url = "https://api.nasa.gov/planetary/apod?api_key=6RVB2VqVPHzfyI9TQ0d4XeQEiAopapJf3RmvapIk";

                try
                {
                    if (forDate != null)
                    {
                        string isoDate = $"{forDate:yyyy-MM-dd}";
                        url += $"&date={isoDate}";
                    }

                    Debug.WriteLine("Using URL " + url);
                    var responseString = client.DownloadString(url);

                    var serializerOptions = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };

                    APODResponse response = JsonSerializer.Deserialize<APODResponse>(responseString, serializerOptions);

                    if (imageSavePath == null)
                    {
                        imageSavePath = Path.Combine(Path.GetTempPath(), "apod.jpg");
                    }
                    client.DownloadFile(response.ImageUrl, imageSavePath);
                    response.FileSavePath = imageSavePath;

                    Debug.WriteLine(response);

                    errorMessage = null;
                    return response;

                } catch (WebException we)
                {
                    errorMessage = "Error fetching data from NASA because " + we.Message;
                }
                catch (IOException ioe)
                {
                    errorMessage = "Error saving image file because " + ioe.Message;
                }
                catch (Exception ex)
                {
                    errorMessage = "Unexpected Exception with message " + ex.Message;
                }
                return null;
            }
        }

    }
}
