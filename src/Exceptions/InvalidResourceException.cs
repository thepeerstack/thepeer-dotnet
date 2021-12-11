using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeerHQ
{
	public class InvalidResourceException : Exception
	{
		public InvalidResourceException()
		{

		}

		public InvalidResourceException(string message) : base(message)
		{

		}
	}
}
