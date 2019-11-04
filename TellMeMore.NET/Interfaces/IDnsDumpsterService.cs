using System.Threading.Tasks;
using TellMeMore.Models.DnsDumpster;

namespace TellMeMore.Interfaces
{
	public interface IDnsDumpsterService
	{
		Task<DnsDumpsterModel> GetAsync(string hostUrl);
	}
}
