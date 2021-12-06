using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeer
{
	public class ServerUnAvailableException : Exception
	{
		public ServerUnAvailableException()
		{

		}

		public ServerUnAvailableException(string message) : base(message)
		{

		}
	}
}
