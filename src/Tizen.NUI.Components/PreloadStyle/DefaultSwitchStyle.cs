/*
 * Copyright(c) 2020 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System.ComponentModel;
using Tizen.NUI.BaseComponents;

namespace Tizen.NUI.Components
{
    /// <summary>
    /// The default Switch style
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class DefaultSwitchStyle : StyleBase
    {
        /// <summary>
        /// Return default Switch style
        /// </summary>
        internal protected override ViewStyle GetAttributes()
        {
            SwitchStyle style = new SwitchStyle
            {
                Size = new Size(96, 60),
                Track = new ImageViewStyle
                {
                    ResourceUrl = new Selector<string>
                    {
                        Normal = DefaultStyle.GetResourcePath("nui_component_default_switch_track_n.png"),
                        Selected = DefaultStyle.GetResourcePath("nui_component_default_switch_track_s.png"),
                        Disabled = DefaultStyle.GetResourcePath("nui_component_default_switch_track_d.png"),
                        DisabledSelected = DefaultStyle.GetResourcePath("nui_component_default_switch_track_ds.png"),
                    }
                },
                Thumb = new ImageViewStyle
                {
                    WidthResizePolicy = ResizePolicyType.DimensionDependency,
                    HeightResizePolicy = ResizePolicyType.SizeRelativeToParent,
                    SizeModeFactor = new Vector3(1, 1, 1),
                    ResourceUrl = new Selector<string>
                    {
                        Normal = DefaultStyle.GetResourcePath("nui_component_default_switch_thumb_n.png"),
                        Selected = DefaultStyle.GetResourcePath("nui_component_default_switch_thumb_n.png"),
                        Disabled = DefaultStyle.GetResourcePath("nui_component_default_switch_thumb_d.png"),
                        DisabledSelected = DefaultStyle.GetResourcePath("nui_component_default_switch_thumb_d.png"),
                    },
                },
                Text = new TextLabelStyle
                {
                    PointSize = new Selector<float?> { All = DefaultStyle.PointSizeNormal },
                    WidthResizePolicy = ResizePolicyType.FillToParent,
                    HeightResizePolicy = ResizePolicyType.FillToParent,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
                    TextColor = new Selector<Color>
                    {
                        Normal = new Color(0.22f, 0.22f, 0.22f, 1),
                        Pressed = new Color(0.11f, 0.11f, 0.11f, 1),
                        Disabled = new Color(0.66f, 0.66f, 0.66f, 1)
                    }
                },
            };
            return style;
        }
    }
}
