using System.Threading.Tasks;
using TellMeMoreBlazor.Models.urlscanio;

namespace TellMeMoreBlazor.Interfaces
{
	public interface IUrlScanIoService
	{
		Task<urlScanIoNewScanResponse> PostAsync(string hostName);
		Task<urlScanIo> GetStatusAsync(string uuid);
	}
}
