using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaxWebApp.Areas.Identity.Data;
using TaxWebApp.Models;

[assembly: HostingStartup(typeof(TaxWebApp.Areas.Identity.IdentityHostingStartup))]
namespace TaxWebApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TaxWebAppContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TaxWebAppContextConnection")));

                services.AddDefaultIdentity<TaxWebAppUser>()
                    .AddEntityFrameworkStores<TaxWebAppContext>();
            });
        }
    }
}