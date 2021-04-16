using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace MockRequestUrllMiddleware
{
    public static class ExtensionMethods
    {
        public static IApplicationBuilder UseMockRequestUrlMidlware(this IApplicationBuilder app, MockRequestUrlOptions options)
        {
            app.UseMiddleware<MockRequestUrllMiddleware>(options);
            return app;
        }
    }
}
