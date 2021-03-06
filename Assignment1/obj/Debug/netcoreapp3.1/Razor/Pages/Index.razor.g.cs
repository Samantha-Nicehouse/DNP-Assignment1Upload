#pragma checksum "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "448ffea38006961848f566d10ecdd2d5467de99b"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DNP\DNP-Assignment1\Assignment1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h4>Adults:</h4>\r\n");
#nullable restore
#line 8 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
 if (adults == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
}
else if (!adults.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p><em>No adult items exist. Please add some.</em></p>\r\n");
#nullable restore
#line 15 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
}
else
{
    DisplaySearch();
    DisplayList();


#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "style", "color:red");
            __builder.AddContent(8, 
#nullable restore
#line 21 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                            errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 22 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 57 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
  
    void DisplayAdults(IList<Adult> adultsToDisplay)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.AddMarkupContent(15, @"<thead>
                <tr>
                    <th>Id</th>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Hair Color</th>
                    <th>Eye Color</th>
                    <th>Age</th>
                    <th>Height</th>
                    <th>Weight</th>
                    <th>Sex</th>
                    <th>Job</th>

                </tr>
            </thead>
            ");
            __builder.OpenElement(16, "tbody");
            __builder.AddMarkupContent(17, "\r\n             \r\n");
#nullable restore
#line 78 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                 foreach (var item in adultsToDisplay)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, "                    ");
            __builder.OpenElement(19, "tr");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 81 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 82 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 83 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 84 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 85 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 86 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 87 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 88 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 89 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 90 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                             item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 92 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "style", "color:red");
            __builder.AddContent(57, 
#nullable restore
#line 95 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                                errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 96 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
    }

    async Task DisplaySearch()
    {
        errorMessage = "";
        bool selectionMade = false;
        try
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.AddMarkupContent(63, "<label>Search</label>\r\n                ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "text");
            __builder.AddAttribute(66, "placeholder", "");
            __builder.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 106 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                                                               searchinput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => searchinput = __value, searchinput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n            ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group");
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "select");
            __builder.AddAttribute(75, "class", "form-control selectpicker");
            __builder.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 109 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                                                                 filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => filter = __value, filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 110 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                     foreach (var item in filters)
                    {
                        if (!selectionMade)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "                            ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", 
#nullable restore
#line 114 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                                            item.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(82, "selected", true);
            __builder.AddContent(83, 
#nullable restore
#line 114 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                                                                       item.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 115 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                            selectionMade = true;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(85, "                            ");
            __builder.OpenElement(86, "option");
            __builder.AddAttribute(87, "value", 
#nullable restore
#line 119 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                                            item.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(88, 
#nullable restore
#line 119 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                                                              item.ToString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n");
#nullable restore
#line 120 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
                        }
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 124 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    async Task DisplayList()
    {
        errorMessage = "";
        try
        {
            IList
            <Adult>
                adultsToDisplay = new List<Adult>
                    ();
            if (!filter.Equals("--Select Filter--"))
            {
                foreach (var item in adults)
                {
                    switch (filter)
                    {
                        case "First Name":
                            if (item.FirstName.ToLower().Contains(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2 || item.FirstName.ToLower().Equals(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2) adultsToDisplay.Add(item);
                            break;
                        case "Last Name":
                            if (item.LastName.ToLower().Contains(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2 || item.LastName.ToLower().Equals(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2) adultsToDisplay.Add(item);
                            break;
                        case "Hair Color":
                            if (item.HairColor.ToLower().Contains(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2 || item.HairColor.ToLower().Equals(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2) adultsToDisplay.Add(item);
                            break;
                        case "Eye Color":
                            if (item.EyeColor.ToLower().Contains(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2 || item.EyeColor.ToLower().Equals(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2) adultsToDisplay.Add(item);
                            break;
                        case "Age Max":
                            if (item.Age <= Int32.Parse(searchinput) && !searchinput.Equals("")) adultsToDisplay.Add(item);
                            break;
                        case "Height Max":
                            if (item.Height <= Int32.Parse(searchinput) && !searchinput.Equals("")) adultsToDisplay.Add(item);
                            break;
                        case "Weight Max":
                            if (item.Weight <= Int32.Parse(searchinput) && !searchinput.Equals("")) adultsToDisplay.Add(item);
                            break;
                        case "Age Min":
                            if (item.Age >= Int32.Parse(searchinput) && !searchinput.Equals("")) adultsToDisplay.Add(item);
                            break;
                        case "Height Min":
                            if (item.Height >= Int32.Parse(searchinput) && !searchinput.Equals("")) adultsToDisplay.Add(item);
                            break;
                        case "Weight Min":
                            if (item.Weight >= Int32.Parse(searchinput) && !searchinput.Equals("")) adultsToDisplay.Add(item);
                            break;
                        case "Male":
                            if (item.Sex.Equals("M")) adultsToDisplay.Add(item);
                            break;
                        case "Female":
                            if (item.Sex.Equals("F")) adultsToDisplay.Add(item);
                            break;
                        case "Job":
                            if (item.JobTitle.ToLower().Contains(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2 || item.JobTitle.ToLower().Equals(searchinput.ToLower()) && !searchinput.Equals("") && searchinput.Length >= 2) adultsToDisplay.Add(item);
                            break;
                        default:
                            break;
                    }
                }
                DisplayAdults(adultsToDisplay);
            }
            else
            {
                DisplayAdults(adults);
            }
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "D:\DNP\DNP-Assignment1\Assignment1\Pages\Index.razor"
       
    private IList<Adult> adults;
    private String searchinput = "";
    private String errorMessage;
    [ValidFilter]
    private String filter = "--Select Filter--";
    private static List<string> filters = new[] {"--Select Filter--", "First Name", "Last Name", "Hair Color", "Eye Color",
            "Age Min", "Age Max", "Height Min", "Height Max","Weight Min", "Weight Max", "Male", "Female", "Job"}.ToList();

    protected override async Task OnInitializedAsync()
    {
        await Task.Run(() => adults = AdultService.GetAdults());

    }

    public class ValidFilter : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (filters == null || filters.Contains(value.ToString().ToLower()))
            {
                return ValidationResult.Success;
            }
            string validString = "";
            foreach (var item in filters)
            {
                validString += " " + item.ToString();

            }
            return new ValidationResult("Valid search filters are:" + validString + ".");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
