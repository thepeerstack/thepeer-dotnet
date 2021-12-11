using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeerHQ
{
	public class ServerErrorException : Exception
	{
		public ServerErrorException()
		{

		}

		public ServerErrorException(string message)	: base(message)
		{

		}
	}
}
