#pragma checksum "/Users/mansiboriya/Downloads/BlazorBricks/BlazorBricks/Shared/Brick.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cecd781ac77edf6514fd1ff4cfa2935780baef50"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBricks.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using BlazorBricks;
    using BlazorBricks.Shared;
    public class Brick : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "span");
            builder.AddAttribute(1, "class", "colorChip" + " shapecolor-" + Color);
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
        }
        #pragma warning restore 1998
        
    public string Color { get; set; }
    }
}
#pragma warning restore 1591