#pragma checksum "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\Contract.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71ef2222f2b47c39f3fe3c0838f5dbc3e3abeaf8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LoanForEdu.Pages.Pages_Contract), @"mvc.1.0.razor-page", @"/Pages/Contract.cshtml")]
namespace LoanForEdu.Pages
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
#line 1 "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\_ViewImports.cshtml"
using LoanForEdu;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71ef2222f2b47c39f3fe3c0838f5dbc3e3abeaf8", @"/Pages/Contract.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0138450901148e1c40b4d50574a9132e05300df3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contract : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col mx-3 shadow-sm mt-5"" style=""background-color: #FFFFFF; border-radius: 5px; min-width:300px;"">
    <div class=""p-3"" style=""text-align: left;"">
        <a type=""button"" class=""btn"" href=""/Home"" style=""display: block; background-color:#E4E6E9; color:#000000;"">
            กลับไปหน้าแรก
        </a>
    </div>
</div>
<div class=""col mx-3 shadow-sm mt-3"" style=""background-color: #FFFFFF; border-radius: 5px; min-width:300px;"">
    <div class=""pt-4"">
        <div class=""mx-3 pt-3 pb-2""
            style=""text-align: center; color:#1877f2; background-color: #FAFAFA; border-radius: 5px;"">
            <h4>สถานะสัญญา</h4>
        </div>
    </div>
    <div class=""p-3 pt-3 px-4"" style=""text-align: left;"">
        <h6>เงินต้น ");
#nullable restore
#line 20 "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\Contract.cshtml"
               Write(Model.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" บาท</h6>\r\n        <h6>ระยะสัญญา ");
#nullable restore
#line 21 "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\Contract.cshtml"
                 Write(Model.periods);

#line default
#line hidden
#nullable disable
            WriteLiteral(" เดือน</h6>\r\n        <h6>ผ่อนชำระงวดละ ");
#nullable restore
#line 22 "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\Contract.cshtml"
                     Write(Model.payamount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" บาท</h6>\r\n        <div class=\"mt-3\"></div>\r\n        <h6>งวดที่เหลือ ");
#nullable restore
#line 24 "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\Contract.cshtml"
                   Write(Model.remain_periods);

#line default
#line hidden
#nullable disable
            WriteLiteral(" งวด</h6>\r\n        <h6>เงินต้นคงเหลือ ");
#nullable restore
#line 25 "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\Contract.cshtml"
                      Write(Model.remain_amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" บาท</h6>\r\n    </div>\r\n    <div class=\"p-3 pt-3 px-4 mb-5\">\r\n        <a type=\"button\" class=\"btn mt-2 mb-2\" href=\"/Pay\"\r\n            style=\"display: block; background-color:#1877f2; color:#FFFFFF;\">\r\n            ชำระเงิน\r\n        </a>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.ContractModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ContractModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.ContractModel>)PageContext?.ViewData;
        public MyApp.Namespace.ContractModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
