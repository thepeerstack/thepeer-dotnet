using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeerHQ
{
	public class ChargeLinkResponse
	{

		public Transaction transaction { get; set; }
		public class Transaction
		{
			public string id { get; set; }
			public string remark { get; set; }
			public int amount { get; set; }
			public string type { get; set; }
			public string status { get; set; }
			public User user { get; set; }
			public string mode { get; set; }
			public string reference { get; set; }
			public Peer peer { get; set; }
			public DateTime created_at { get; set; }
			public DateTime updated_at { get; set; }
		}

		public class User
		{
			public string name { get; set; }
			public string identifier { get; set; }
			public string identifier_type { get; set; }
			public string email { get; set; }
			public string reference { get; set; }
		}

		public class Peer
		{
			public User1 user { get; set; }
			public Business business { get; set; }
		}

		public class User1
		{
			public string name { get; set; }
			public string identifier { get; set; }
			public string identifier_type { get; set; }
			public string email { get; set; }
			public string reference { get; set; }
		}

		public class Business
		{
			public string id { get; set; }
			public string name { get; set; }
			public string email { get; set; }
			public string logo { get; set; }
			public string identifier_type { get; set; }
		}

	}
}
