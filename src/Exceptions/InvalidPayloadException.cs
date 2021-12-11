using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeerHQ
{
	public class InvalidPayloadException : Exception
	{
		public InvalidPayloadException()
		{

		}

		public InvalidPayloadException(string message) : base(message)
		{

		}
	}
}
