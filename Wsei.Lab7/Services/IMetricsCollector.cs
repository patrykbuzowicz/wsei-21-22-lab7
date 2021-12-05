using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wsei.Lab7.Services
{
    public interface IMetricsCollector
    {
        void Collect(string httpMethod, string path, int responseCode);

        IEnumerable<EndpointStats> GetEndpointStats();
    }
}
