using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace gRPC.Server.Services
{
    public class ProvinceService : ProvinceRPC.ProvinceRPCBase
    {
        private readonly ILogger<ProvinceService> _logger;
        public ProvinceService(ILogger<ProvinceService> logger)
        {
            _logger = logger;
        }

        public override Task<GetProvinceReply> GetProvinceDetail(GetProvinceRequest request, ServerCallContext context)
        {
            var districts = new List<District>()
            {
                new District {Id = "1", Name = "Ben Luc", Level = "Huyen"},
                new District {Id = "2", Name = "Tan An", Level = "Thanh Pho"},
            };
            return Task.FromResult(new GetProvinceReply
            {
                Id = request.Id,
                Name = "Long An",
                Level = "Tinh",
                Districts = { districts }
            });
        }
    }
}
