#pragma checksum "C:\Users\TAUSHIQAWAIS\Desktop\Dot Net Core\Projects\BookStoreApp\BookStoreApp\BookStoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fec0d11f2be7c39036f8dda0d49a5409b4c6e2b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\TAUSHIQAWAIS\Desktop\Dot Net Core\Projects\BookStoreApp\BookStoreApp\BookStoreApp\Views\_ViewImports.cshtml"
using BookStoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fec0d11f2be7c39036f8dda0d49a5409b4c6e2b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ebbf933125c2e9628d41d91b16ae8b336fd57a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Production, Staging", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\TAUSHIQAWAIS\Desktop\Dot Net Core\Projects\BookStoreApp\BookStoreApp\BookStoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        <h1>Welcome to Book Store</h1>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec0d11f2be7c39036f8dda0d49a5409b4c6e2b83946", async() => {
                WriteLiteral("\r\n            Development\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fec0d11f2be7c39036f8dda0d49a5409b4c6e2b85171", async() => {
                WriteLiteral("\r\n            Production\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <p class=""lead text-muted"">
            Lorem ipsum dolor sit amet,  Lorem ipsum dolor sit amet,  Lorem ipsum dolor sit amet,  Lorem ipsum dolor sit amet,  Lorem ipsum dolor sit amet,
            Lorem ipsum dolor sit amet,  Lorem ipsum dolor sit amet,  Lorem ipsum dolor sit amet,
        </p>
        <p>
            <a href=""#"" class=""btn btn-primary my-2"">Search Books</a>
        </p>

    </div>

</section>

<section class=""py-5 bg-light"">
    <div class=""container"">
        <h3 class=""h3"">Top Books</h3>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <img class=""card-img-top"" width=""30"" height=""225"" src=""data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxERExYTERMWFxYWEBEQGREYEREYFhARFhYXFxYSFhYZHiohGRsmHxYWIjMiJistMDAwGCA1OjUuOSovMC0BCgoKDw4PGBERHC8mIB4vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLS8vLy8vLy8vLy8vLy8vLy8vLy8vL//AABEIAL4BCgMBIgACEQEDEQH/xAAcAAEAAQUBAQAAAAAAAAAAAAAABgIDBAUHAQj/");
            WriteLiteral(@"xABHEAABAwIBBwcIBggGAwAAAAABAAIDBBEFBhIhMUFRkRMyYXGBobEHIkJScpLB0RQjM2KCskNTg5OiwvDxFRZUc9LhFzRE/8QAGgEBAAMBAQEAAAAAAAAAAAAAAAECAwQFBv/EADURAAIBAgIGCAUEAwEAAAAAAAABAgMRBDESIUFRkaEFEzJhcbHR8BRCUoHBFSLh8bLC4gb/2gAMAwEAAhEDEQA/AO4oiIAiIgCIiAIiIAiIgCIiAIiIAix5qyJnPkY32ngeJWrqcrsPj51VD1CRrjwbdRdEXRvEUSl8oeHjmPfJ0MglPiAsKbyjM/R0lQ72msjHeVGmhdE6RRbBcs4JwOUaYnEkWcQWg7i4au3QpM1wIuDcHTfZZTGSeQTuVoiKSQiIgCIiAIiIAiIgCIiAIiIAiIgCIiAIiIAiIgNPjuN/RbEwTyAjnRMa5reh5Lhm9Z0LQSZczH7Oheel88Te5ucplPGHNc06i0jiFqKTC2t1hZzbRZRvtI67KvEncynhZ7T5XnuAVh+JYvJ+lij9mnB73uKmgpmjUBwXvJgbO4LPSZOhHvIM6jxOTn1kv4OTj/K1WnZJSyfazzv9qomPgQp7b+rq1U1EcQvI9jBve9rRxJCrmToQ3EKiyCg9JjT7Wn8xK2FPkhC3U1o6mgeAWRW5cYbDzqmMnczOk/ICFg03lGoZHENEth6fIgNPVc3KuoTeS5EaVNbjaxZPRDZ4rMjweEDmjgFiQZWUThflwOhzZAfy6exYFdl7hzbtFQCRsDX3HEKs012rkqpHeiNY7G2Koka3QCQ6264V7CMemgP1b/N2xnS09mzsso9ieMsnmc9huCQBs0DoVEdQuZ30ro4pP9zaOs4TlbDNZsn1b+k+YT0O2dtu1SMLhkdQt5g+Uc0Fgx12/q3XLeza3sW8MR9ReNXedYRR/BsqYaizT9XIdGY46HHc12o9RsVIF1KSaujVO4REUkhERAEREAREQBERAEREAREQBERAFiVeIwQ6ZZY4/bkY3xKy");
            WriteLiteral(@"1AcvZcIaX/SBT/SbMNzG10pGi2dYEkZu9CGVZUeUumpgOQdFUE6Cxk3nA9jS0j8QUc/8pVsn2VE0dYld4WHetN/mKhiHmAn2IgB32WLLlzCDaOB7j0uA7gCqtX2C19vBEh/zljEnNhiZ0lrR4uce5UPxbGX66mOP2IWkjuC0tJlJUzfZwNA6nvPG4aOK2sVPXTCxe2IH1Wgv4gWHFU1bEvM3jR+p+/DPiUTUVbL9tX1LvutkLGnsCsx5I0986RpcfWkkeb8TZbB9UY/q3OJLfMJOt1tp61q8Sp4ZmkOY25HOAs4HocNKy+IeR6a6KvFOMl74mfHR0cPpQM/FED81o8osTg81sL2uOdckagLar9vcopW4NmOIBJGw3Kxv8OdsJW0KkU0zgqYOrZxdjfMrelY9XCyXSQL71qm0EmxxV5lHUbD3Lo+Ji8zm/T6uxGRHh42OcOolbKmjcP0hPWAfCy18NFUnUAeIWyp8Gqnawwdbz8lRzoPMfAYl5QZksc71geI+ayGTPGzgQrQwGp2Oj953/FVf4PVj0Wnqkb8bLNww8snYS6OxS+R+fkZkdWRvB4WO9dzo5C+Njjrcxjj1kArgQoasa4j2PjPg5bWjxrEoua6YAbD54HYbhTTpQi3ozWv3vKKjWh2qcuD9Dt6Lk9P5Qa2LTNGHNGsujcxxHQ4WA4LqkUgc0OGogOHURdaONiU9drW8S4iIqkhERAEREAREQBERAEREAREQBUSRtcLOAI3EAryUGxzSAbaCRcA7yLi/FQ/Eq3Eo3lnKw7CHNpnaQR96QqG7At5dZLxzMaWiNjScxzW08Gc4m5zhIWlzdVtCgkeAQQuzQwEg6zp07wDoHYphPFiUotJUG172bDC3TwKwjkpK83fI8338mPBqxlK5rFytaxbw/kYxnSPYwD1nNHirk2WOHRapQ7oYL95sFU3Ihu3OP7R4/LZJMkIm64wek5x8Sqounb5ef8fkgVdjbZZHvB0Oke4C17AnQNHQrArHO1Di5re4m66HFk/G");
            WriteLiteral(@"DoiYP2bfktpBgQGoW7AFVwW86fjq1rKy4v8AJymSne/d/GfytKux4FMQHNMZBF+c8HqIc0WK7CzJ5hGnxUNxiEQTOYNWgjt/ss5rRV0c9bGVorSuuBDzhk7dbL9Tmn4r0CRuuJ/uOPgpFyycqstNlI9LVVmlz9TQtrw3WLdYI8VkR4mDqtxW35RW5IY3c5jT1taVOmtx0x6bks4c/wCDDbifSqxih3qxWYPG7S3zD91xA4alpKnCp2c2VxHZ8lZOLOiPTcHmnyJKMUKuNxZQktqR6fFoW4wOnMhPLufstmFjT/E1ys4LebLpmntuSJmIB/mEZwd5hb6wOi3bddpAtoC5PhFJQQyMkd9JeWODwHPgLc4G4JDWtJ02OtdIwnGYqkO5Mm7bXa4WIvqPcVtR0VdXRwY7HQxDjo7LmyREXScIREQBERAEREAREQBERAEREAWvroA54PQBq6Ss5wuNBto17ulaOowmqOqtfe2gchANPWGqsiU7M2QA/oBef1sXOcc/xeF+b9IaLjOBs11xcjTZrdOhak1eMHXWN7IrfFY69xOk9x12/WsedgP91yoOxU663gCE+j4iddbL2G38qjXuCk9x0tsAGzvVcbBdc2hw+r9Oqnd0cqAO6O/es+jpniRnKueWFwDvrpw6x0XBDgN2xUlKSWXkX0nu98DoEkoaNneuW5U1gdUvsdWa3uv8VTlFhlTG8mKomMZNw0vBLPu3I0hR84VUE3MjiTpJIbpPBZOrGaMal5KxmCoXv0hYzMDqD6Z91vyV+LJqoP6T+EKl47zHqZFwVK9FSsiDI+c65QPwBbGnyHcefUcIx81Rzgto6mRp/pCpdKCpSzIaLbPL2CMfBeOyGh2Ty8Iv+Kr1sCOqkQ6RrSqobNOhSt2Qsf8AqJPdj+SNyGZ/qH+4xSq0d5bqZGiZUqWeTqcuqHgauQcT2PZbxKxmZA55AjqbHTzob8LOClWSOS/0HPLpOUe/NGcGZoa0X80C51k6+gLpw8dJqSyIjTaZJkRF3m4R");
            WriteLiteral(@"EQBERAEREAREQBERAEREAVLjYb/iqkQHPctcYGe0OjLCGXzXvha4i584Nz720W7CoicoY76Q4fhJHELsGMUjJY7PaDYgi4GjZ8VqocApyNMLD+ELNpLO/L0LK9v79TnceUFOOc9rfae1viVnU2P0Z/8Aoh/fw/8AJTSXJmlI+wZ7oWkrcmYW6oYyP9tvyWTV8nyXqW/d3cymlxiiP6aL97EfByv1lbAWXY9p6itPLgUG2CP90z5LHOA0/wCoi/ds+SaF12uX/Qbl3e/sZM1e12sjitdPikLNBc2+64WTFk3TOP2EfuN+S29PknSW+xaOoWWCwkF8z4L1K2l7/ojgx+L1grrMo49jlJMQyOp2xOdE0teGlzSDtAuFCBNcX7V2Yfo6lWT/AHPV3L1MK1WVO11mbluUrd54K63KVu8+6fktAZF5yi6f0Wl9TMPi5biRnKRg0l9uvR4qwcroBrnZ77Voi9Y01Ox2sDgqS6Fp7JPkSsU9qJJ/nGn/AF7PeCuxZUxO5sgPVcqDy4czYFcpIczUs10RC9m3yL/EatSOt5JPfM8S2PJgO8/Y53NzQNe08FMlBvJbOTFMzY2Rj+17bfyBTlSqCotwjvNoS0kmERFJYIiIAiIgCIiAIiIAiIgCIiAIiIC3O27SFixxWGziFRiP0m45EQlttIkdI053QWg6OxaOqxyqhcWPpmOItpjnNjcX0Z0Y3qHG5KZIDF0KzNTX2FRo5agGz6WUdT4nfEKsZc0/pRTN/ZB35SVTq37a9Syl7s/QzqrD+g9617qHT/dHZdYfqdOWdDmuHwV2PKehfzahh7SPFR1c9z4E9ZHeuJXT0tlmMZ0+CphxandzZ4j+0j+ay45Wu5paeotPgqNNZl01sK5L5h6lxdzrEjcSO9djxOqEcTnG1g0ngFw8zbT1rvwD7T8DjxnyrxMvlF4ZFhuqANqx34iwekOK9B1EsziUG9htOUVJlWp/xIHmhx6mn4q7GZXeiGjpOngFlLEQW00VCT2Gc6RWjMArRpHH");
            WriteLiteral(@"XJwaPiSqRhrPSc8/it4LGWLhsNI4eR1byTQnkZZdj5gwdIY3SR2vI7Cp6uEYbjM9OwRwzyNY29mZ5zRc3NgeklTbIDKaaeZ0U0meDEXtJDbtc0gEXAF7h23cuOdTSk2dUYaKsdBREQBERAEREAREQBERAEREAREQBEVmcOLTmEB1jmkgkB2wkAi46LhAVvdYE7hfQCTwGtQvE8oaV0hvJmEgANlZJEdAA1SAKzjVdiLXlnKNAFtLAACCL3F2k96ieLUlVMCJnyyDXmukLm335rjbuWEqncz0KWCi9fWw4teaRscRkaXZzSCDtBBHELFY4FReXJdwN2GRh3tD/grkVNWRapiRukbr6ydKzdRHR8DU+W0vCS9SXRwB2zu0K63JeCXnQxE7zGy/Gy0NDj1RH9pA1/TG8DuKk2HZaUosJRJEfvxm3YR8lKmnkzCthqlNXnFrxTtxyIvllkvHTta5rQ0OJbcXBBtcWOzUVBH8rGfNlf0HOJ8V0zyi43DNFGIntd9YXaDqAaRpGzWucVFU3eFqpyWTZwuMZPZyKxi9XmlpneWkWLSdBG5WM6Q63njbwVrl9wPAq4wvOph7lZ1ZbW+JpDDN9mPIqbTA69PWVkxU7QqI4JTsA7VlRYbK7bwafmsnUS2nVDAV5ZRZdjc0K79JVcWAn0nnu+SzIcFhGvOd1ud8Cs3Xijqh0LiJZ2Xi/S5rjVKh1YN63EmGQH0B/EsKXDWN1BQq63Gkug6kVfSXBmPG57ua1x6QDbiuk+TLJyoildUVEeY3kcxgLmEvzy051mk2ADdvrKDUkmboHDf0LvGFxFkMTHa2wxsPW1oB8FrSm5N6sjix2Dhh4Qak23flYzERF0HmhERAEREAREQBERAEREAREQBEVqcEtIac0kEB1gbHYbbUBh4hSB7gSNNgO9UfQ2areCwZ4a6JpcJ4pbAmz4C0ntY5al+UdSzS+GM+w8j8y55PXkzsVG+qM4v72/yUTfvwuM629wWM/A4jsHetZFljH6UMrfZs7wss");
            WriteLiteral(@"uHKykOuQt6HMd/KCqaaXcX+ErPKOl4Wl5XKZcmInbB3fFYcuSUZ1Ae6Pgt9Fi1O7VNH77Qe9ZMcrXaQQekFTdS23M7VaT1px4ogM2QUBP2TeBHcTZWXZENHNAH4WDxauin+tK8Fv6COKeaNKeLrQ7M2vuzmkuRltTB7oPhZYdRku9gvyYPEfNdYDR0Kidjc3Uq9XHd5my6SxH1cVF/g442Bg9H/oq5dZGMgMmeBqzvHStY+oXJLNo+uozTpxm9Wkk+KuZRcrT5wFrqmuDdZ7NvBYvLOf90b9v/S2p4ec8kceL6Uw+H7Ute7N8PXUZ9TXBo0my1U9e9/Maes/JXmwsGki53nSVcz7al6FPARXadz5nFf+gqVNVNWW9636eZewCvnpn8oGRPdcEGWPODCNRaLix6danVL5TJh9rBG7fmOezxzlz0yKkyLqVKC1WPFqYmpN3k9Z9GUlQ2VjJGaWvY14O9rgCPFX1ochnl1DTk/qQOwEgdwC3y5mrM6E7oIiISEREAREQBERAEREAREQHhKpc5elWZUBZrZRmkbwQoxXNGbbrVGU8VYXh9NM1oaLck5ozXHTcl1idRta2zYo1PlPPDoq6YgafrY7FvXrIHa4dSOLZKklmZEkelUchdU02M085+rkFz6J813A6+xbOKK6xbsa2TNPNhEb9bLHe0uaeLSFiHAJ2m8NTKzoOY4cSM7vUygpws+GkG5VdnmkbQrVYK0ZyXg2vyQE1eKRc2YuHtOPc5wCrZlvXRaJGtNvWuCeoWHip/JhrHf2UE8oeGiJrHj1yziCf5VenCEnZrg2v45FamLrJaV07b4xfNrS5ntP5W2A2miLT1OHhnLZM8olJKLA2J9keNj3LlVVCHLFENlo8MtjfJlIdIReuVKP2cl/s1yJJjOMsdI4tN7uLhbdqGlal9VI/wC6OjXxWOxivgq9PCwjrzff7sMR0tXqLRi9FLVZbvHPy8CqCEDT3q/nrH5RW3TDeurUeW1cyzIqTIqaOjnn+xie/wC8G+b7");
            WriteLiteral(@"x0d639BkNUP0yvZGNwu93wA4lUc0iyptkfMqphLpHZsbS93qtBJ7tXWuj4dkHTMsXh0h3vdo91thxupTQ4VHGA1jGtG5rQBwCo6u40VHebDJxohp4Yb/AGcLGE73ADOPG63DJFraenss6NqxNzIDl7dUNCqCAqReL1AEREAREQBERAEREB4VSWqteWQGJPSNdrC1VVgMbuhSCypLEBzzFPJ/BJc5oB9Zvmm+87D2grTnJfEKb/1589o/Rv3bhe44Zq6wY1bdApvsIscwhyplgIbW0z49Qz2jzSei5sexxUowrG6ee3JStLvVvmv902KkEtC1wIIBB0WI0FRzE8g6WXSxhidvjIA9wgt7r9KroRfcTpTXebxr1BvKjIOQZ/vN/K9ZLsFxWl+xlFQwfo36HW2AB58HjqURyxxCpnDIn00rXh5cRychB0WBF26tJ2kdKtGFpJ31ETneLViLOcrDnLdUeSdZLraIx943Put+YW7o8gNsme/o5reA0962c0c6pyIRyuwa9g2lbGjwSqm5sRaPWf5g4HT3Lo9Bk0IuZEG9TbE9Z2rb0+Fv9U8FR1HsNFSW0gNBkMTpmmPsxtt/E69+AUowzJOmisWwgn1n3eb7wXXt2KUU+Gkaws+Oj6FRybNFFLI1EVEsuKjW0ZSq82FQSYEdIsmOnWUI1UGIC02NXAxV2XtkB4AvUsvUAREQBERAEREAREQBERAEREAREQBERAF5ZeogPLJZeogKOTbuHAL3MG5VIgPM0JmheogPM0JZeogPLL1EQBERAEREAREQBERAEREB/9k="" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <p class=""card-text"">This section will be used to display the ");
            WriteLiteral(@"description of the book</p>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary""> View Details</a>
                            </div>
                            <small class=""text-muted"">Author Name</small>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <img class=""card-img-top"" width=""30"" height=""225"" src=""https://specials-images.forbesimg.com/imageserve/5f85be4ed0acaafe77436710/960x0.jpg?fit=scale"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <p class=""card-text"">This section will be used to display the description of the book</p>
                        <div c");
            WriteLiteral(@"lass=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary""> View Details</a>
                            </div>
                            <small class=""text-muted"">Author Name</small>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <img class=""card-img-top"" width=""30"" height=""225"" src=""https://specials-images.forbesimg.com/imageserve/5f85be4ed0acaafe77436710/960x0.jpg?fit=scale"" alt=""Card image cap"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <p class=""card-text"">This section will be used to display the description of the book</p>
                        <div class=""d-flex justify-content-between align-items-center"">
");
            WriteLiteral(@"                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary""> View Details</a>
                            </div>
                            <small class=""text-muted"">Author Name</small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>




");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
