using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SslLabsLib.Objects;
using TellMeMore.Models.DnsDumpster;

namespace TellMeMore.Models
{
	public class CombindedModel
	{
		public Models.BuiltWithModel.BuiltWithModel builtWithModel { get; set; }
		public DnsDumpsterModel dnsDumpsterModel { get; set; }

		public urlScanIo urlScanIo { get; set; }

		public Analysis analysis { get; set; }
	}
}
