using System.Threading;
using System.Threading.Tasks;
using HorsebackRiding.DAL.DataObjects;

namespace HorsebackRiding.DAL.DataServices {
	public interface IMainDataService {
		Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx);
	}
}

