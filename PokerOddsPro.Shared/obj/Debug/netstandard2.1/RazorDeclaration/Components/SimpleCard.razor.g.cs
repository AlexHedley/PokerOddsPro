#pragma checksum "C:\Users\dyh12\source\repos\PokerOddsPro\PokerOddsPro.Shared\Components\SimpleCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7022d5376459f56ae59396e9ae08813faf0c4a04"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PokerOddsPro.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\dyh12\source\repos\PokerOddsPro\PokerOddsPro.Shared\Components\SimpleCard.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dyh12\source\repos\PokerOddsPro\PokerOddsPro.Shared\Components\SimpleCard.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dyh12\source\repos\PokerOddsPro\PokerOddsPro.Shared\Components\SimpleCard.razor"
using PokerOddsPro.Shared.Dto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dyh12\source\repos\PokerOddsPro\PokerOddsPro.Shared\Components\SimpleCard.razor"
using PokerOddsPro.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dyh12\source\repos\PokerOddsPro\PokerOddsPro.Shared\Components\SimpleCard.razor"
using static PokerOddsPro.Shared.Helpers.Helper;

#line default
#line hidden
#nullable disable
    public partial class SimpleCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\dyh12\source\repos\PokerOddsPro\PokerOddsPro.Shared\Components\SimpleCard.razor"
       
    [Parameter]
    public Card card { get; set; }

    [Parameter]
    public EventCallback<Card> SetSelectedCard { get; set; }

    [Parameter]
    public DisplayDirectionEnum displayDirection { get; set; }

    protected override async Task OnInitializedAsync()
    {
        card.IsAvailableUpdated += (s, e) =>
        {
            StateHasChanged();
        };
    }

    //todo CARD IS ACTIVE STATUS  NOT UPDATING CORRECNTLY
    public string activeState => card.IsAvailable ? "active" : "disabled";

    public async Task SelectCardTask()
    {
        if (card.IsAvailable)
        {
            await SetSelectedCard.InvokeAsync(card);
            StateHasChanged();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
