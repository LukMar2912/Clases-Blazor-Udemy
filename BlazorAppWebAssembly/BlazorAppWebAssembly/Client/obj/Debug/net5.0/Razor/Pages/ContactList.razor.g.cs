#pragma checksum "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "496a55d1f4bafb81c7e8e25b9f2fac4bbf568b0f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppWebAssembly.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using BlazorAppWebAssembly.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using BlazorAppWebAssembly.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using BlazorAppWebAssembly.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\_Imports.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class ContactList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Contacts</h3>\r\n");
#nullable restore
#line 7 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
__builder.AddContent(1, Message);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, "<table class=\"table\"><tbody><tr><td colspan=\"2\"><a href=\"/contactdetails\">Add New</a></td></tr></tbody></table>");
#nullable restore
#line 16 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
 if (contacts==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p><em>Loading...</em></p>");
#nullable restore
#line 19 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "<thead><tr><th>Name</th>\r\n                <th>Phone</th>\r\n                <th>Address</th>\r\n                <th></th>\r\n                <th></th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
#nullable restore
#line 33 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
             foreach (var contact in contacts)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "tr");
            __builder.OpenElement(10, "td");
#nullable restore
#line 36 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
__builder.AddContent(11, contact.FullName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 37 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
__builder.AddContent(14, contact.Phone);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 38 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
__builder.AddContent(17, contact.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/contactdetails/" + (
#nullable restore
#line 39 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
                                                  contact.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "href", "/contactdelete/" + (
#nullable restore
#line 40 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
                                                 contact.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(27, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Renzo\Desktop\GitLukMar\Clases-Blazor-Udemy\BlazorAppWebAssembly\BlazorAppWebAssembly\Client\Pages\ContactList.razor"
       
    IEnumerable<Contact> contacts;
    public string Message { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            contacts = await ContactServices.GetAll();
        }
        catch(Exception e)
        {
            Message = "Error... " + e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactServices { get; set; }
    }
}
#pragma warning restore 1591