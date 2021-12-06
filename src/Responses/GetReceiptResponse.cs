﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThePeer
{
	public class GetReceiptResponse
	{

		public Receipt receipt { get; set; }

		public class Receipt
		{
			public string id { get; set; }
			public int amount { get; set; }
			public User user { get; set; }
			public Peer peer { get; set; }
			public Meta meta { get; set; }
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
			public User user { get; set; }
			public Business business { get; set; }
		}

		public class Business
		{
			public string id { get; set; }
			public string name { get; set; }
			public string email { get; set; }
			public object logo { get; set; }
			public string identifier_type { get; set; }
		}

		public class Meta
		{
			public string city { get; set; }
			public string state { get; set; }
		}

	}
}
