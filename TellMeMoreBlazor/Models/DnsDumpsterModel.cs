using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TellMeMoreBlazor.Models
{
	public class DnsRecord
	{
		public string dns { get; set; }
	}

	public class MxRecord
	{
		public string mx { get; set; }
	}

	public class HostRecord
	{
		public string host { get; set; }
	}

	public class TechFound
	{
		public string tech { get; set; }
	}

	public class TxtRecord
	{
		public string txt { get; set; }
	}
	public class DnsDumpsterModel
	{
		public IList<DnsRecord> dnsRecords { get; set; }
		public IList<MxRecord> mxRecords { get; set; }
		public IList<HostRecord> hostRecords { get; set; }
		public IList<TechFound> techFound { get; set; }
		public IList<TxtRecord> txtRecords { get; set; }
	}
}
