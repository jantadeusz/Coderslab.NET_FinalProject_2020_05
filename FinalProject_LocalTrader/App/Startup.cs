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
g��wnie backend i rozbudowane relacje
Front minimalny: bootstrap i JS (min, minimorum).

Spis funkcjonalno�ci
"1. Model: 
"
- produkty
- klienci (IdentityUsers)
- zam�wienia (+ pola: wys�ane)
- p�atno�ci (+ kolumna: srodki wplynely)
- Magazyn z produktami (klucz obcy: idProduktu, ilo��, adres produktu w magazynie)
- Wiadomo�ci (od, do, powiadomienia mailowe)
...

2. Edycja modelu:
- dodawanie + edycja + usuwanie wierszy w modelu za pomoc� formularzy
- form kontakt: wyb�r z listy tematu korespondencji (np. brak produktu, czy wyslane itp)
...

"3. Przestrze� sklepu dost�pna bez logowania:
"
- wyswietlanie produktow na liscie ze zdjeciami miniaturkami
- ilosc towarow na stronie (10,20,50)
- wybor kategorii/podkategorii produktow do wyswietlania
- miejsce na reklamy
...

"4. Przestrze� klienta dost�pna po zalogowaniu (rola Client):
"
- mozliwosc zlozenia zamowienia
- historia oplaconych zamowie�
- lista nieoplaconych zamowien
     */
/*
Uwagi moje bie��ce do aplikacji:

- Strona powitalna z list� produkt�w z uwzgl�dnieniem dostawcy tzn n mleka od producent�w 1-n.
- bez logowania mozliwe tylko przegladanie produkt�w.Opcja koszyk + kup dost�pna po zalogowaniu.
- po zarejestrowaniu jako klient jest link "chc� by� producentem" gdzie dodawane s� produkty
- nast�pnie taki producent czeka na weryfikacj� Admina po czym staje sie producentem 
i ma produkty w puli
- Producer i Products po�czone relacj� wiele do wielu

*/
