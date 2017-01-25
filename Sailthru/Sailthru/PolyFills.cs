#if NETSTANDARD
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sailthru
{
    public static class PolyFills
    {
        public static Stream GetRequestStream(this WebRequest request)
        {
            return request.GetRequestStreamAsync().Result;
        }

        public static WebResponse GetResponse(this WebRequest request)
        {
            return request.GetResponseAsync().Result;
        }
    }
}
#endif
