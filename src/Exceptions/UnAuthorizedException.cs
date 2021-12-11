using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeerHQ
{
	public class UnAuthorizedException : Exception
	{
		public UnAuthorizedException()
		{

		}

		public UnAuthorizedException(string message) : base(message)
		{

		}
	}
}
