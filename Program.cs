using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;

var builder = WebApplication.CreateBuilder(args);

// Add authentication services
builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("AzureAd"));

// Add authorization
builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = options.DefaultPolicy;
});

// Add controllers with views and Razor Pages if you're using them
builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI();

// ... rest of your Program.cs configuration ...

var app = builder.Build();

// ... other middleware ...

app.UseAuthentication();
app.UseAuthorization();

// ... rest of your middleware configuration ... 