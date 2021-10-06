using Microsoft.AspNetCore.Components;

namespace Radzen.Blazor
{
    public partial class RadzenColumnOptions : RadzenChartComponentBase
    {
        [Parameter]
        public double Radius { get; set; }

        [Parameter]
        public double Margin { get; set; } = 10;

        protected override void Initialize()
        {
            Chart.ColumnOptions = this;
        }

        protected override bool ShouldRefreshChart(ParameterView parameters)
        {
            return DidParameterChange(parameters, nameof(Radius), Radius) || DidParameterChange(parameters, nameof(Margin), Margin);
        }
    }
}