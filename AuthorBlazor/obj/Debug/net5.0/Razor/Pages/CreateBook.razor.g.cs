#pragma checksum "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00d3f512bd49480a781c69667adce2089ab2b172"
// <auto-generated/>
#pragma warning disable 1591
namespace AuthorBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using AuthorBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\_Imports.razor"
using AuthorBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
using AuthorBlazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
using AuthorBlazor.Data.BookData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
using AuthorBlazor.Data.AuthorData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateBook")]
    public partial class CreateBook : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Register new book</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                  newBook

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                           AddBook

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "<label class=\"col-sm-2 col-form-label\">ISBN:</label>\r\n        ");
                __Blazor.AuthorBlazor.Pages.CreateBook.TypeInference.CreateInputNumber_0(__builder2, 12, 13, "col-sm-6 form-control", 14, 
#nullable restore
#line 15 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                                                 newBook.ISBN

#line default
#line hidden
#nullable disable
                , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBook.ISBN = __value, newBook.ISBN)), 16, () => newBook.ISBN);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group row");
                __builder2.AddMarkupContent(20, "<label class=\"col-sm-2 col-form-label\">Title:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "class", "col-sm-6 form-control");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                                               newBook.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBook.Title = __value, newBook.Title))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newBook.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group row");
                __builder2.AddMarkupContent(29, "<label class=\"col-sm-2 col-form-label\">Publication Year:</label>\r\n        ");
                __Blazor.AuthorBlazor.Pages.CreateBook.TypeInference.CreateInputNumber_1(__builder2, 30, 31, "col-sm-6 form-control", 32, 
#nullable restore
#line 23 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                                                 newBook.PublicationYear

#line default
#line hidden
#nullable disable
                , 33, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBook.PublicationYear = __value, newBook.PublicationYear)), 34, () => newBook.PublicationYear);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group row");
                __builder2.AddMarkupContent(38, "<label class=\"col-sm-2 col-form-label\">Number of Pages:</label>\r\n        ");
                __Blazor.AuthorBlazor.Pages.CreateBook.TypeInference.CreateInputNumber_2(__builder2, 39, 40, "col-sm-6 form-control", 41, 
#nullable restore
#line 27 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                                                 newBook.NumOfPages

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBook.NumOfPages = __value, newBook.NumOfPages)), 43, () => newBook.NumOfPages);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row");
                __builder2.AddMarkupContent(47, "<label class=\"col-sm-2 col-form-label\">Genre:</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "class", "col-sm-6 form-control");
                __builder2.AddAttribute(50, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 31 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                                               newBook.Genre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBook.Genre = __value, newBook.Genre))));
                __builder2.AddAttribute(52, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newBook.Genre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.OpenElement(55, "select");
                __builder2.AddAttribute(56, "class", "custom-select");
                __builder2.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                                  SelectedAuthor

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(58, "option");
                __builder2.AddAttribute(59, "value", "Select");
                __builder2.AddContent(60, "Choose Author");
                __builder2.CloseElement();
#nullable restore
#line 35 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
         foreach (var author in Authors)  
        {  

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(61, "option");
                __builder2.AddAttribute(62, "value", 
#nullable restore
#line 37 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                            author.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(63, 
#nullable restore
#line 37 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                                         author.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 38 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
        }  

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "style", "color:red");
                __builder2.AddContent(67, 
#nullable restore
#line 41 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                            Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "disabled", 
#nullable restore
#line 42 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
                       Loading

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(71, "class", "btn btn-light");
                __builder2.AddMarkupContent(72, "Register\r\n");
#nullable restore
#line 43 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
         if (Loading) 
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(73, "<span class=\"spinner-border spinner-border-sm mr-1\"></span>");
#nullable restore
#line 46 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\CreateBook.razor"
       
    private Book newBook = new();
    private string Message { get; set; }
    private bool Loading { get; set; }
    private int AuthorId { get; set; }
    private IList<Author> Authors { get; set; }

    protected async override Task OnInitializedAsync()
    {
        Authors = await AuthorService.GetAuthorsAsync();
    }

    private async Task AddBook()
    {
        Loading = true;
        string message = await BookService.AddBookAsync(newBook, AuthorId);
    }
    
    private void SelectedAuthor(ChangeEventArgs e) {  
        AuthorId = (int)e.Value;
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService AuthorService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService BookService { get; set; }
    }
}
namespace __Blazor.AuthorBlazor.Pages.CreateBook
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591