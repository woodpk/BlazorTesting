#pragma checksum "C:\Users\Patrick\Desktop\Coding\BlazorTesting\PhoenixCharts\PhoenixCharts.Client\Pages\ConsumerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3eee6987a41d2f89c430ce4af4c750ddb41583"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PhoenixCharts.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using PhoenixCharts.Client;
    using PhoenixCharts.Client.Shared;
    using PhoenixCharts.Shared.Models;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Components.RouteAttribute("/consumer")]
    public class ConsumerIndex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 41 "C:\Users\Patrick\Desktop\Coding\BlazorTesting\PhoenixCharts\PhoenixCharts.Client\Pages\ConsumerIndex.cshtml"
            
    Consumer[] csrList;
    protected override async Task OnInitAsync()
    {
        csrList = await Http.GetJsonAsync<Consumer[]>("/api/consumer/Index");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
