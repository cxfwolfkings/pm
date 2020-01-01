﻿using Microsoft.AspNetCore.Builder;

namespace LeadChina.PM.AppMetrics
{
    public static class AppMetricsApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseAppMetrics(this IApplicationBuilder app)
        {
            app.UseMetricsAllMiddleware();
            // Or to cherry-pick the tracking of interest
            app.UseMetricsActiveRequestMiddleware();
            app.UseMetricsErrorTrackingMiddleware();
            app.UseMetricsPostAndPutSizeTrackingMiddleware();
            app.UseMetricsRequestTrackingMiddleware();
            app.UseMetricsOAuth2TrackingMiddleware();
            app.UseMetricsApdexTrackingMiddleware();

            app.UseMetricsAllEndpoints();
            // Or to cherry-pick endpoint of interest
            app.UseMetricsEndpoint();
            app.UseMetricsTextEndpoint();
            app.UseEnvInfoEndpoint();

            return app;
        }
    }
}