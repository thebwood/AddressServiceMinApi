namespace AddressServiceMinApi.Api.Endpoints
{
    public static class AddressEndpoints
    {
        public static void MapAddressEndpoints(this IEndpointRouteBuilder endpoints)
        {
            endpoints.MapGet("/address", async (HttpContext context) =>
            {
                await context.Response.WriteAsJsonAsync(new { Address = "123 Main St" });
            });

            endpoints.MapGet("/address/{id}", async (HttpContext context) =>
            {
                await context.Response.WriteAsJsonAsync(new { Address = "123 Main St" });
            });

            endpoints.MapPost("/address", async (HttpContext context) =>
            {
                await context.Response.WriteAsJsonAsync(new { Address = "123 Main St" });
            });

            endpoints.MapPut("/address/{id}", async (HttpContext context) =>
            {
                await context.Response.WriteAsJsonAsync(new { Address = "123 Main St" });
            });


            endpoints.MapDelete("/address/{id}", async (HttpContext context) =>
            {
                await context.Response.WriteAsJsonAsync(new { Address = "123 Main St" });
            });

        }   
    }
}
