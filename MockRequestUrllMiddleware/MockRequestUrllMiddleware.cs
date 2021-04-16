using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace MockRequestUrllMiddleware
{
    public class MockRequestUrllMiddleware
    {
        private readonly RequestDelegate next;
        private readonly MockRequestUrlOptions options;

        public MockRequestUrllMiddleware(
          RequestDelegate next,
          MockRequestUrlOptions options)
        {
            this.next = next;
            this.options = options;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var host = context.Request.Host;

            context.Request.Host = new HostString(options.MockUrl);
            await next(context);
            context.Request.Host = host;
        }
    }
}
