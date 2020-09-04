using Microsoft.AspNetCore.Builder;

namespace Get_images_from_db_by_url.Middleware
{
    public static class DynamicImageMiddleware
    {
        public static IApplicationBuilder UseDynamicImageMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DynamicImageProvider>();
        }
    }
}
