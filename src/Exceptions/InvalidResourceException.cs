using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeer
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
