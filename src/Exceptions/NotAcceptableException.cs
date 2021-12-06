using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeer
{
	public class NotAcceptableException : Exception
	{
		public NotAcceptableException()
		{

		}

		public NotAcceptableException(string message) : base(message)
		{

		}
	}
}
