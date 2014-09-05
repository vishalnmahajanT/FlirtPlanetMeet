//--------------------------------------------------------------------------------
//
// Core.Webservice.cs - 
//
// Copyright 2013 Game Refuge Inc
//
//--------------------------------------------------------------------------------

using System;
using System.IO;
using System.Net;
using System.Text;

using Core.Constants;

//--------------------------------------------------------------------------------
using flirtplanet;

namespace Core
{
	public class WebService
	{
		//----------------------------------------
		// POST a string

		public static string CallWebservice(string data)
		{
			try
			{
				//Stream datastream;
				var request = HttpWebRequest.Create(kBaseURL.Webservice);
				request.ContentType = "application/x-www-form-urlencoded";
				request.Method = "POST";

				// Make Post Data
				byte[] byteArray = Encoding.UTF8.GetBytes(data);
				request.ContentLength = byteArray.Length;
				using(var datastream = request.GetRequestStream())
				{
					datastream.Write(byteArray, 0, byteArray.Length);
					byteArray = null;
					datastream.Close();
				}

				using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
				{
					if (response.StatusCode != HttpStatusCode.OK)
					{
						Logger.ReportException("Error fetching data. Server returned status code: " + response.StatusCode);
						return null;
					}

					using (StreamReader reader = new StreamReader(response.GetResponseStream()))
					{
						var content = reader.ReadToEnd();
						if (string.IsNullOrWhiteSpace(content))
						{
							Logger.ReportException("Response contained empty body...");
							return null;
						}
						else
						{
							return content;
						}
					}
				}
			}
			catch (WebException e)
			{
				Logger.ReportException(e.Message);
				return null;
			}
		}

		//----------------------------------------

	} // End Class: WebService

} // End Namespace: Core

//--------------------------------------------------------------------------------
// EOF




