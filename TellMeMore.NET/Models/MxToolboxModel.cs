using System;
using Newtonsoft.Json;

namespace TellMeMore.Models
{

	public class MxToolboxModel
	{
		public Question[] question { get; set; }
		public object answer { get; set; }
		public Authority[] authority { get; set; }
	}

	public class Question
	{
		public string name { get; set; }
		public string type { get; set; }
		public string _class { get; set; }
	}

	public class Authority
	{
		public string name { get; set; }
		public string type { get; set; }
		[JsonProperty("class")]
		public string _class { get; set; }
		public int ttl { get; set; }
		public int rdlength { get; set; }
		public string rdata { get; set; }
	}
}
