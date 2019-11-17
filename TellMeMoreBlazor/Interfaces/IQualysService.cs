using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SslLabsLib.Objects;

namespace TellMeMoreBlazor.Interfaces
{
	public interface IQualysService
	{
		Task<Analysis> QualysReport(string domainUrl);
	}
}
