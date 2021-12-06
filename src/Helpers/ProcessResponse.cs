using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeer
{
	public static class ProcessResponse
	{
		public static string Process(IRestResponse response)
		{
			int statusCode = (int)response.StatusCode;
			ErrorResponse error = new ErrorResponse();
			MultiErrorResponse multiError = new MultiErrorResponse();
			switch (statusCode)
			{
				case 200:
				case 201:
					return response.Content;
				case 401:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new UnAuthorizedException(error.Message);
				case 403:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new ForbiddenException(error.Message);
				case 404:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new InvalidResourceException(error.Message);
				case 406:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new NotAcceptableException(error.Message);
				case 422:
					multiError = JsonConvert.DeserializeObject<MultiErrorResponse>(response.Content);
					foreach (var newError in multiError.errors)
					{
						throw new InvalidPayloadException(newError.error[0]);
					}
					return null;
				case 503:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new ServerUnAvailableException(error.Message);
				default:
					error = JsonConvert.DeserializeObject<ErrorResponse>(response.Content);
					throw new ServerErrorException(error.Message);
			}
		}
	}
}
