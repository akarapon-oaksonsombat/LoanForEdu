#pragma checksum "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\PaymentSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f13b8cb932323db17ed8637f16334209aabde7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LoanForEdu.Pages.Pages_PaymentSuccess), @"mvc.1.0.razor-page", @"/Pages/PaymentSuccess.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f13b8cb932323db17ed8637f16334209aabde7f", @"/Pages/PaymentSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0138450901148e1c40b4d50574a9132e05300df3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PaymentSuccess : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""col mx-3 shadow-sm mt-5"" style=""background-color: #FFFFFF; border-radius: 5px; min-width:300px;"">
    <div class=""p-3"">
        <h1 class=""pt-5 px-5 text-left"" style=""color: #1877f2;"">ชำระเงินสำเร็จ</h1>
        <h5 class=""pt-2 px-5"">ท่านได้ชำระเงินจำนวน ");
#nullable restore
#line 8 "C:\Users\6010110514\Documents\GitHub\LoanForEdu\Pages\PaymentSuccess.cshtml"
                                              Write(Model.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" บาท</h3>
            <h6 class=""pt-2 px-5"">ตรวจสอบยอดเงินคงเหลือได้ที่หน้า สถานะสัญญา</h3>
                <div class=""pt-2"">
                    <a type=""button"" class=""btn mt-2 mb-2"" href=""/Contract""
                        style=""display: block; background-color:#1877f2; color:#FFFFFF;"">
                        สถานะสัญญา
                    </a>
                </div>
                <div class=""pt-2"">
                    <a type=""button"" class=""btn mt-2 mb-2"" href=""/Home""
                        style=""display: block; background-color:#1877f2; color:#FFFFFF;"">
                        กลับไปหน้าแรก
                    </a>
                </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyApp.Namespace.PaymentSuccessModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.PaymentSuccessModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyApp.Namespace.PaymentSuccessModel>)PageContext?.ViewData;
        public MyApp.Namespace.PaymentSuccessModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591