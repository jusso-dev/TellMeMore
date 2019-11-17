using SslLabsLib.Objects;
using TellMeMoreBlazor.Models.urlscanio;

namespace TellMeMoreBlazor.Models
{
	public class CombinedModel
	{
		public Models.BuiltWithModel builtWithModel { get; set; }
		public DnsDumpsterModel dnsDumpsterModel { get; set; }

		public urlScanIo urlScanIo { get; set; }

		public Analysis analysis { get; set; }
	}
}
