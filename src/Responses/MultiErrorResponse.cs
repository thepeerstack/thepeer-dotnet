using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeer
{
	public class MultiErrorResponse
	{
		public string message { get; set; }
		public List<Errors> errors { get; set; }

		public class Errors
		{
			public List<string> error { get; set; }
		}
	}



	
}
