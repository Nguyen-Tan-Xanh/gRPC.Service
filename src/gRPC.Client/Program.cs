using Grpc.Net.Client;
using gRPC.Server;
using System;

namespace gRPC.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grpcChannel = GrpcChannel.ForAddress("https://localhost:5001");
            var greeterClient = new Greeter.GreeterClient(grpcChannel);
            var greeterReply = greeterClient.SayHello(new HelloRequest
            {
                Name = "Nguyen Tan Xanh",
            });
            Console.WriteLine(greeterReply.ToString());

            var provinceClient = new ProvinceRPC.ProvinceRPCClient(grpcChannel);
            var provinceDetail = provinceClient.GetProvinceDetail(new GetProvinceRequest
            {
                Id = "01",
            });
            Console.WriteLine(provinceDetail.ToString());
            Console.ReadKey();
        }
    }
}
