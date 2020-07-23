using OneOf;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace AntDesign.Charts
{
    public class FunnelConfig : IFunnelViewConfig, IPlotConfig
    {
        [JsonPropertyName("funnelStyle")]
        public object FunnelStyle { get; set; }
        [JsonPropertyName("percentage")]
        public object Percentage { get; set; }
        [JsonPropertyName("transpose")]
        public bool? Transpose { get; set; }
        [JsonPropertyName("dynamicHeight")]
        public bool? DynamicHeight { get; set; }
        [JsonPropertyName("compareField")]
        public string CompareField { get; set; }
        [JsonPropertyName("compareText")]
        public object CompareText { get; set; }
        [JsonPropertyName("renderer")]
        public string Renderer { get; set; }
        [JsonPropertyName("data")]
        public object Data { get; set; }
        [JsonPropertyName("meta")]
        public object Meta { get; set; }
        [JsonIgnore]
        public OneOf<int?, string, int[]> Padding { get; set; }
        [JsonPropertyName("padding")]
        public object PaddingMapping => Padding.Value;
        [JsonPropertyName("xField")]
        public string XField { get; set; }
        [JsonPropertyName("yField")]
        public string YField { get; set; }
        [JsonPropertyName("color")]
        public string[] Color { get; set; }
        [JsonPropertyName("xAxis")]
        public Axis XAxis { get; set; }
        [JsonPropertyName("yAxis")]
        public Axis YAxis { get; set; }
        [JsonPropertyName("label")]
        public Label Label { get; set; }
        [JsonPropertyName("tooltip")]
        public Tooltip Tooltip { get; set; }
        [JsonPropertyName("legend")]
        public Legend Legend { get; set; }
        [JsonPropertyName("animation")]
        public object Animation { get; set; }
        [JsonIgnore]
        public OneOf<string, object> Theme { get; set; }
        [JsonPropertyName("theme")]
        public object themeMapping => Theme.Value;
        [JsonPropertyName("responsiveTheme")]
        public object ResponsiveTheme { get; set; }
        [JsonPropertyName("interactions")]
        public Interaction[] Interactions { get; set; }
        [JsonPropertyName("responsive")]
        public bool? Responsive { get; set; }
        [JsonPropertyName("title")]
        public Title Title { get; set; }
        [JsonPropertyName("description")]
        public Description Description { get; set; }
        [JsonPropertyName("guideLine")]
        public GuideLineConfig[] GuideLine { get; set; }
        [JsonPropertyName("defaultState")]
        public ViewConfigDefaultState DefaultState { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("forceFit")]
        public bool? ForceFit { get; set; }
        [JsonPropertyName("width")]
        public int? Width { get; set; }
        [JsonPropertyName("height")]
        public int? Height { get; set; }
        [JsonPropertyName("pixelRatio")]
        public int? PixelRatio { get; set; }
        [JsonPropertyName("localRefresh")]
        public bool? LocalRefresh { get; set; }
    }

    public interface IFunnelViewConfig : IViewConfig
    {
        [JsonPropertyName("funnelStyle")]
        public object FunnelStyle { get; set; }//export interface FunnelStyle { [k: string]: any; }
        [JsonPropertyName("percentage")]
        public object Percentage { get; set; }
        /*
           percentage?: Partial<{
                visible: boolean;
                line: Partial<{
                  visible: boolean;
                  style: LineStyle;
                }>;
                text: Partial<{
                  visible: boolean;
                  content: string;
                  style: TextStyle;
                }>;
                value: Partial<{
                  visible: boolean;
                  style: TextStyle;
                  formatter: (yValueUpper: any, yValueLower: any) => string;
                }>;
                offsetX: number;
                offsetY: number;
                spacing: number;
              }>;
        */
        [JsonPropertyName("transpose")]
        public bool? Transpose { get; set; }
        [JsonPropertyName("dynamicHeight")]
        public bool? DynamicHeight { get; set; }
        [JsonPropertyName("compareField")]
        public string CompareField { get; set; }
        [JsonPropertyName("compareText")]
        public object CompareText { get; set; }
        /*
           compareText?: Partial<{
                visible: boolean;
                offsetX: number;
                offsetY: number;
                style: TextStyle;
              }>;
        */
    }


}
