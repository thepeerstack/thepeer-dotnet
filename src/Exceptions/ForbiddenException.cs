using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeerHQ

{
	public class ForbiddenException : Exception
	{
		public ForbiddenException()
		{

		}

		public ForbiddenException(string message) : base(message)
		{

		}
	}
}
