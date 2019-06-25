using System.Threading;
using System.Threading.Tasks;
using HorsebackRiding.DAL.DataObjects;

namespace HorsebackRiding.DAL.DataServices.Mock {
	class MockMainDataService: BaseMockDataService, IMainDataService {
		public Task<RequestResult<SampleDataObject>> GetSampleDataObject(CancellationToken ctx) {
			return GetMockData<SampleDataObject>("HorsebackRiding.DAL.Resources.Mock.Main.SampleDataObject.json");
		}
	}
}

