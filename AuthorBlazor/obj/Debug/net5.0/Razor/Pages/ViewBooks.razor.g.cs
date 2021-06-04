#pragma checksum "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e76ced3cdb7c2f0ab723292332bfb4aacd5f996"
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
#line 2 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
using AuthorBlazor.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
using AuthorBlazor.Data.BookData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
using AuthorBlazor.Data.AuthorData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ViewBooks")]
    public partial class ViewBooks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Book list</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by Author\'s First Name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
                                                                  (arg) => FilterByAuthorsName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "p");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
                                  (arg) => FilterByBookTitle(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "style", "width:50px");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
 if (filteredBooks == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<p><em>Loading...</em></p>");
#nullable restore
#line 24 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
}
else if (!filteredBooks.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "<p><em>Please register some books first.</em></p>");
#nullable restore
#line 30 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table");
            __builder.AddMarkupContent(17, "<thead><tr><th>Title</th>\r\n            <th>PubYear</th>\r\n            <th>NumOfPages</th>\r\n            <th>AuthorFirstName</th>\r\n            <th>AuthorLastName</th>\r\n            <th>Delete</th></tr></thead>\r\n        \r\n        ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 46 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
         foreach (var book in filteredBooks)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 49 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
                         book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 50 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
                         book.PublicationYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 51 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
                         book.NumOfPages

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    <td></td>\r\n                    <td></td>\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
                                            () => RemoveBook(book.ISBN)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(32, "<i class=\"oi-trash\" style=\"color: red\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\HP\RiderProjects\ExamA20-299543\AuthorBlazor\Pages\ViewBooks.razor"
       
    private IList<Author> Authors;
    private IList<Book> allBooks;
    private IList<Book> filteredBooks;

    private string? filterByAuthorsName;
    private string? filterByBookTitle;

    protected override async Task OnInitializedAsync()
    {
        Authors = await AuthorService.GetAuthorsAsync();
        foreach (Author auth in Authors)
        {
            foreach (Book book in auth.Books)
            {
                allBooks.Add(book);
            }
        }
        filteredBooks = allBooks;
    }

    private void RemoveBook(int ISBN)
    {
        Book book = allBooks.FirstOrDefault(b => b.ISBN == ISBN);
        BookService.DeleteBookAsync(ISBN);
        allBooks.Remove(book);
        filteredBooks.Remove(book);
    }

    private void FilterByAuthorsName(ChangeEventArgs evt)
    {
        string? filterbyauthorname = null;
        try
        {
            filterbyauthorname = evt.Value.ToString();
        }
        catch (Exception e){}
        if (filterbyauthorname != null)
        {
            Author author = Authors.FirstOrDefault(t => t.FirstName.Equals(filterbyauthorname));
            filteredBooks = author.Books;
        }
        else
        {
            filteredBooks = allBooks;
        }
    }

    private void FilterByBookTitle(ChangeEventArgs evt)
    {
        filterByBookTitle = null;
        try
        {
            filterByBookTitle = evt.Value.ToString();
        }
        catch(Exception e){}
        if (filterByBookTitle != null)
        {
            filteredBooks = allBooks.Where(t => t.Title.Equals(filterByBookTitle)).ToList();
        }
        else
        {
            filteredBooks = allBooks;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService BookService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorService AuthorService { get; set; }
    }
}
#pragma warning restore 1591
