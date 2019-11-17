using System.Threading.Tasks;

namespace TellMeMoreBlazor.Shared.Interfaces
{
	public interface ITellMeMoreLogger
	{
		Task<string> ReadConfiguration(string keyName);
	}
}
