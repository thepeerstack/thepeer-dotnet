using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThePeerHQ
{
	public interface IThePeerHQInterface
	{
		bool ValidateSignature(object payload, string signature);
		Task<GetReceiptResponse> GetSendReceipt(string receipt);
		Task<ProcessReceiptResponse> ProcessSendReceipt(string receipt, string @event);
		Task<IndexUserResponse> IndexUser(string name, string identifier, string email);
		Task<IndexUserResponse> GetUser(string reference);
		Task<UpdateUserResponse> UpdateUser(string reference, string identifier);
		Task<DefaultResponse> DeleteUser(string reference);
		Task<LinkIdResponse> GetLink(string linkId);
		Task<ChargeLinkResponse> ChargeLink(string linkId, int amount, string remark);
		Task<AuthorizeChargeResponse> AuthorizeDirectCharge(string reference, string @event);
	}
}
