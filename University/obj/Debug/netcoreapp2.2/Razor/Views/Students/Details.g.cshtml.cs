#pragma checksum "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ceca0e743dc0107f61eeba56b9b7d1badf27e82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ceca0e743dc0107f61eeba56b9b7d1badf27e82", @"/Views/Students/Details.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<University.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(63, 36, true);
            WriteLiteral("\n<h2>Student Details</h2>\n<hr/>\n<h3>");
            EndContext();
            BeginContext(100, 40, false);
#line 9 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(140, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(143, 36, false);
#line 9 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(179, 36, true);
            WriteLiteral("</h3>\n<hr/>\n<h3>Date of enrollment: ");
            EndContext();
            BeginContext(216, 44, false);
#line 11 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
                   Write(Html.DisplayFor(model => model.DateOfEnroll));

#line default
#line hidden
            EndContext();
            BeginContext(260, 14, true);
            WriteLiteral("</h3>\n<hr />\n\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
 if (Model.Courses.Count == 0)
{

#line default
#line hidden
            BeginContext(307, 56, true);
            WriteLiteral("    <p>This student is not enrolled in any courses.</p>\n");
            EndContext();
#line 17 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(372, 58, true);
            WriteLiteral("    <h4>Courses the student is enrolled in:</h4>\n    <ul>\n");
            EndContext();
#line 22 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
         foreach(var join in Model.Courses)
        {

#line default
#line hidden
            BeginContext(484, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(501, 16, false);
#line 24 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
           Write(join.Course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(517, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 25 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
        }

#line default
#line hidden
            BeginContext(533, 10, true);
            WriteLiteral("    </ul>\n");
            EndContext();
#line 27 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
}

#line default
#line hidden
            BeginContext(545, 4, true);
            WriteLiteral("\n<p>");
            EndContext();
            BeginContext(550, 72, false);
#line 29 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
Write(Html.ActionLink("Add a course", "AddCourse", new {id = Model.StudentId}));

#line default
#line hidden
            EndContext();
            BeginContext(622, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(631, 51, false);
#line 30 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
Write(Html.ActionLink("Go back to home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(682, 8, true);
            WriteLiteral("</p>\n<p>");
            EndContext();
            BeginContext(691, 55, false);
#line 31 "/Users/Guest/Desktop/UniversityRegistrar.Solution/University/Views/Students/Details.cshtml"
Write(Html.ActionLink("Go back to list of students", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(746, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<University.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
