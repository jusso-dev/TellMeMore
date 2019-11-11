using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TellMeMore.Models;

namespace TellMeMore.Interfaces
{
	public interface IUrlScanIoService
	{
		Task<urlScanIoNewScanResponse> PostAsync(string hostName);
		Task<urlScanIo> GetStatusAsync(string uuid);
	}
}
