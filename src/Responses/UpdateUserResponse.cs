using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeer
{
	public class UpdateUserResponse
	{

		public Indexed_User indexed_user { get; set; }

		public class Indexed_User
		{
			public string name { get; set; }
			public string identifier { get; set; }
			public string identifier_type { get; set; }
			public string email { get; set; }
			public string reference { get; set; }
		}

	}
}
