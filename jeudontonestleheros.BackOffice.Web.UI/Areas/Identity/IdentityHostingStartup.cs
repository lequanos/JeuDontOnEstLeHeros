using System;
using jeudontonestleheros.BackOffice.Web.UI.Areas.Identity.Data;
using jeudontonestleheros.BackOffice.Web.UI.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(jeudontonestleheros.BackOffice.Web.UI.Areas.Identity.IdentityHostingStartup))]
namespace jeudontonestleheros.BackOffice.Web.UI.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<jeudontonestleherosBackOfficeWebUIContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("jeudontonestleherosBackOfficeWebUIContextConnection")));

                services.AddDefaultIdentity<jeudontonestleherosBackOfficeWebUIUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<jeudontonestleherosBackOfficeWebUIContext>();
            });
        }
    }
}