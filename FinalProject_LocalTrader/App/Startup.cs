using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Context;
using App.Models;
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
            services.AddIdentity<ConsumerModel, IdentityRole>().AddEntityFrameworkStores<EFContext>();
            services.AddScoped<CategoryService>();
            services.AddScoped<OrderService>();
            services.AddScoped<ProductService>();
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
 Proponowany temat
Sklep internetowy z produktami

Opis projetku
Typowy projekt e-commerce.
Entity framework do granic
g³ównie backend i rozbudowane relacje
Front minimalny: bootstrap i JS (min, minimorum).

Spis funkcjonalnoœci
"1. Model: 
"
- produkty
- klienci (IdentityUsers)
- zamówienia (+ pola: wys³ane)
- p³atnoœci (+ kolumna: srodki wplynely)
- Magazyn z produktami (klucz obcy: idProduktu, iloœæ, adres produktu w magazynie)
- Wiadomoœci (od, do, powiadomienia mailowe)
...

2. Edycja modelu:
- dodawanie + edycja + usuwanie wierszy w modelu za pomoc¹ formularzy
- form kontakt: wybór z listy tematu korespondencji (np. brak produktu, czy wyslane itp)
...

"3. Przestrzeñ sklepu dostêpna bez logowania:
"
- wyswietlanie produktow na liscie ze zdjeciami miniaturkami
- ilosc towarow na stronie (10,20,50)
- wybor kategorii/podkategorii produktow do wyswietlania
- miejsce na reklamy
...

"4. Przestrzeñ klienta dostêpna po zalogowaniu (rola Client):
"
- mozliwosc zlozenia zamowienia
- historia oplaconych zamowieñ
- lista nieoplaconych zamowien
     */
/*
Uwagi moje bie¿¹ce do aplikacji:

- Strona powitalna z list¹ produktów z uwzglêdnieniem dostawcy tzn n mleka od producentów 1-n.
- bez logowania mozliwe tylko przegladanie produktów.Opcja koszyk + kup dostêpna po zalogowaniu.
- po zarejestrowaniu jako klient jest link "chcê byæ producentem" gdzie dodawane s¹ produkty
- nastêpnie taki producent czeka na weryfikacjê Admina po czym staje sie producentem 
i ma produkty w puli
- Producer i Products po¹czone relacj¹ wiele do wielu

*/
