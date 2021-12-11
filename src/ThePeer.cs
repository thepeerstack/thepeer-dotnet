using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ThePeerHQ
{
	public class ThePeer : IThePeerHQInterface
	{
		private readonly string secretKey;
		private readonly RestClient client = new RestClient();

		public ThePeer(string secretKey)
		{
			this.secretKey = secretKey;
			client.BaseUrl = new Uri("https://api.thepeer.co");
			client.AddDefaultHeaders(new Dictionary<string, string>()
			{
				{"x-api-key", secretKey},
				{"Content-Type", "application/json"},
				{"Accept", "application/json"}
			});
		}

		public bool ValidateSignature(object payload, string signature)
		{
			var encoding = new System.Text.UTF8Encoding();
			var keyBytes = encoding.GetBytes(this.secretKey);
			var encodedPayload = JsonConvert.SerializeObject(payload);
			var payloadBytes = encoding.GetBytes(encodedPayload);
			using (var hmacsha1 = new HMACSHA1(keyBytes))
			{
				var hashMessage = hmacsha1.ComputeHash(payloadBytes);
				return Convert.ToBase64String(hashMessage) == signature ? true : false;
			}
		}

		public async Task<AuthorizeChargeResponse> AuthorizeDirectCharge(string reference, string @event)
		{
			try
			{
				var httpRequest = new RestRequest("/debit/" + reference, Method.POST);
				var requestObject = new
				{
					@event = @event
				};
				var requestBody = JsonConvert.SerializeObject(requestObject);
				httpRequest.AddJsonBody(requestBody);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<AuthorizeChargeResponse>(ProcessResponse.Process(response));
			}
			catch (Exception ex)
			{
				throw new ServerErrorException(ex.Message);
			}
		}

		public async Task<ChargeLinkResponse> ChargeLink(string linkId, int amount, string remark)
		{
			try
			{
				var httpRequest = new RestRequest("/link/" + linkId + "/charge", Method.POST);
				var requestObject = new
				{
					amount = amount,
					remark = remark
				};
				var requestBody = JsonConvert.SerializeObject(requestObject);
				httpRequest.AddJsonBody(requestBody);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<ChargeLinkResponse>(ProcessResponse.Process(response));
			}
			catch (Exception ex)
			{
				throw new ServerErrorException(ex.Message);
			}
		}

		public async Task<DefaultResponse> DeleteUser(string reference)
		{

			try
			{
				var httpRequest = new RestRequest("/users/" + reference, Method.DELETE);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<DefaultResponse>(ProcessResponse.Process(response));
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		public async Task<LinkIdResponse> GetLink(string linkId)
		{
			try
			{
				var httpRequest = new RestRequest("/link/" + linkId, Method.GET);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<LinkIdResponse>(ProcessResponse.Process(response));
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}





		public async Task<IndexUserResponse> IndexUser(string name, string identifier, string email)
		{
			try {
				var httpRequest = new RestRequest("/users", Method.POST);
				var requestObject = new
				{
					name = name,
					identifier = identifier,
					email = email
				};
				var requestBody = JsonConvert.SerializeObject(requestObject);
				httpRequest.AddJsonBody(requestBody);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<IndexUserResponse>(ProcessResponse.Process(response));
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		public async Task<IndexUserResponse> GetUser(string reference)
		{
			try
			{
				var httpRequest = new RestRequest("/users/" + reference, Method.GET);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<IndexUserResponse>(ProcessResponse.Process(response));
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		public async Task<UpdateUserResponse> UpdateUser(string reference, string identifier)
		{
			try
			{
				var httpRequest = new RestRequest("/users/" + reference, Method.PUT);
				var requestObject = new
				{
					identifier = identifier,
				};
				var requestBody = JsonConvert.SerializeObject(requestObject);
				httpRequest.AddJsonBody(requestBody);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<UpdateUserResponse>(ProcessResponse.Process(response));
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		public async Task<ProcessReceiptResponse> ProcessSendReceipt(string receipt, string @event)
		{
			try
			{
				var httpRequest = new RestRequest("/send/" + receipt, Method.POST);
				var requestObject = new
				{
					@event = @event
				};
				var requestBody = JsonConvert.SerializeObject(requestObject);
				httpRequest.AddJsonBody(requestBody);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<ProcessReceiptResponse>(ProcessResponse.Process(response));
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}

		public async Task<GetReceiptResponse> GetSendReceipt(string receipt)
		{
			try
			{
				var httpRequest = new RestRequest("/send/" + receipt, Method.GET);
				IRestResponse response = await client.ExecuteAsync(httpRequest);
				return JsonConvert.DeserializeObject<GetReceiptResponse>(ProcessResponse.Process(response));
			}
			catch (Exception exception)
			{
				throw exception;
			}
		}




	}
}
