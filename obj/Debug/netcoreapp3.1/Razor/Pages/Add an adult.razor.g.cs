#pragma checksum "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1c78f216708d09a5f9e2904a842df7631257cc0"
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
#line 1 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jambo\RiderProjects\DNPAssignement1\_Imports.razor"
using Assignment1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
using Assignment1.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Add_an_adult")]
    public partial class Add_an_adult : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.AddMarkupContent(2, "<h3 class=\"ownHeader\">Register someone</h3>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                      newAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                                addNew

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group");
                __builder2.AddMarkupContent(13, "\r\n            Id: <br>\r\n            ");
                __Blazor.Assignment1.Pages.Add_an_adult.TypeInference.CreateInputNumber_0(__builder2, 14, 15, 
#nullable restore
#line 14 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                      newAdult.Id

#line default
#line hidden
#nullable disable
                , 16, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Id = __value, newAdult.Id)), 17, () => newAdult.Id);
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddMarkupContent(21, "\r\n            First name:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(22);
                __builder2.AddAttribute(23, "rows", "1");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                                 newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddMarkupContent(30, "\r\n            Last name:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(31);
                __builder2.AddAttribute(32, "rows", "1");
                __builder2.AddAttribute(33, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                                 newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                __builder2.AddAttribute(35, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.OpenElement(38, "div");
                __builder2.AddMarkupContent(39, "\r\n            Hair color:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(40);
                __builder2.AddAttribute(41, "rows", "1");
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                                 newAdult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.HairColor = __value, newAdult.HairColor))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.HairColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddMarkupContent(48, "\r\n            Eye color:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(49);
                __builder2.AddAttribute(50, "rows", "1");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                                 newAdult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.EyeColor = __value, newAdult.EyeColor))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.EyeColor));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.AddMarkupContent(58, "\r\n            Weight: <br>\r\n            ");
                __Blazor.Assignment1.Pages.Add_an_adult.TypeInference.CreateInputNumber_1(__builder2, 59, 60, 
#nullable restore
#line 34 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                      newAdult.Weight

#line default
#line hidden
#nullable disable
                , 61, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Weight = __value, newAdult.Weight)), 62, () => newAdult.Weight);
                __builder2.AddMarkupContent(63, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n            Height: <br>\r\n            ");
                __Blazor.Assignment1.Pages.Add_an_adult.TypeInference.CreateInputNumber_2(__builder2, 68, 69, 
#nullable restore
#line 38 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                      newAdult.Height

#line default
#line hidden
#nullable disable
                , 70, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Height = __value, newAdult.Height)), 71, () => newAdult.Height);
                __builder2.AddMarkupContent(72, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "form-group");
                __builder2.AddMarkupContent(76, "\r\n            Age: <br>\r\n            ");
                __Blazor.Assignment1.Pages.Add_an_adult.TypeInference.CreateInputNumber_3(__builder2, 77, 78, 
#nullable restore
#line 42 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                      newAdult.Age

#line default
#line hidden
#nullable disable
                , 79, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Age = __value, newAdult.Age)), 80, () => newAdult.Age);
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n        ");
                __builder2.OpenElement(83, "div");
                __builder2.AddMarkupContent(84, "\r\n            Sex:<br>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(85);
                __builder2.AddAttribute(86, "rows", "1");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
                                                 newAdult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.Sex = __value, newAdult.Sex))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.Sex));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\r\n\r\n        ");
                __builder2.AddMarkupContent(92, "<p class=\"actions\">\r\n            <button class=\"btn btn-outline-success\" type=\"submit\">Add</button>\r\n        </p>\r\n\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\jambo\RiderProjects\DNPAssignement1\Pages\Add an adult.razor"
       
    private Adult newAdult = new Adult();

    private void addNew()
    {
        AdultService.AddAdult(newAdult);
        NavigationManager.NavigateTo("/AdultsOverview");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
namespace __Blazor.Assignment1.Pages.Add_an_adult
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
