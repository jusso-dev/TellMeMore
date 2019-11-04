using System.Threading.Tasks;
using TellMeMore.Models;

namespace TellMeMore.Interfaces
{
	public interface IDnsDumpsterService
	{
		Task<DnsDumpsterModel> GetAsync(string hostUrl);
	}
}
