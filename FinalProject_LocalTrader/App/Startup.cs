using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Context;
using App.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace App
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddXmlFile("appSettings.xml");
            Configuration = configurationBuilder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EFContext>(builder =>
            {
                builder.UseSqlServer(Configuration["ConnectionString"]);
            });
            services.AddMvc();
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<EFContext>();
            services.AddScoped<ProductService>();
            services.AddScoped<OrderService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) { app.UseDeveloperExceptionPage(); }
            else { app.UseExceptionHandler("/Home/Error"); }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Product}/{action=Index}/{id?}/{id1?}");
            });
        }
    }
}
/*
Uwagi moje bie��ce do aplikacji:

- Strona powitalna z list� produkt�w z uwzgl�dnieniem dostawcy tzn n mleka od producent�w 1-n.
- bez logowania mozliwe tylko przegladanie produkt�w.Opcja koszyk + kup dost�pna po zalogowaniu.
- po zarejestrowaniu jako klient jest link "chc� by� producentem" gdzie dodawane s� produkty
- nast�pnie taki producent czeka na weryfikacj� Admina po czym staje sie producentem 
i ma produkty w puli
- Producer i Products po�czone relacj� wiele do wielu

*/
