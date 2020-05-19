﻿/*
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
using Tizen.NUI.Binding;
using Tizen.NUI.Components;

namespace Tizen.NUI.Wearable
{
    /// <summary>
    /// CircularProgressStyle is a class which saves CircularProgress's ux data.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class CircularProgressStyle : ControlStyle
    {
        /// <summary>Bindable property of Thickness</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ThicknessProperty = BindableProperty.Create(nameof(Thickness), typeof(float?), typeof(CircularProgressStyle), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).thickness = (float?)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).thickness;
        });

        /// <summary>Bindable property of MaxValue</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty MaxValueProperty = BindableProperty.Create(nameof(MaxValue), typeof(float), typeof(CircularProgressStyle), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).maxValue = (float)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).maxValue;
        });

        /// <summary>Bindable property of MinValue</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty MinValueProperty = BindableProperty.Create(nameof(MinValue), typeof(float), typeof(CircularProgressStyle), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).minValue = (float)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).minValue;
        });

        /// <summary>Bindable property of CurrentValue</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty CurrentValueProperty = BindableProperty.Create("currentValue", typeof(float), typeof(CircularProgressStyle), default(float), propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).currentValue = (float)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).currentValue;
        });

        /// <summary>Bindable property of BufferValue</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty BufferValueProperty = BindableProperty.Create("bufferValue", typeof(float?), typeof(CircularProgressStyle), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).bufferValue = (float?)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).bufferValue;
        });

        /// <summary>Bindable property of ProgressState</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ProgressStateProperty = BindableProperty.Create("state", typeof(ProgressStatusType), typeof(CircularProgressStyle), ProgressStatusType.Indeterminate, propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).state = (ProgressStatusType)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).state;
        });

        /// <summary>Bindable property of TrackColor</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty TrackColorProperty = BindableProperty.Create("trackColor", typeof(Color), typeof(CircularProgressStyle), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).trackColor = (Color)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).trackColor;
        });

        /// <summary>Bindable property of ProgressColor</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty ProgressColorProperty = BindableProperty.Create("progressColor", typeof(Color), typeof(CircularProgressStyle), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).progressColor = (Color)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).progressColor;
        });

        /// <summary>Bindable property of BufferColor</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty BufferColorProperty = BindableProperty.Create("bufferColor", typeof(Color), typeof(CircularProgressStyle), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).bufferColor = (Color)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).bufferColor;
        });

        /// <summary>Bindable property of IsEnabled</summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public static readonly BindableProperty IsEnabledProperty = BindableProperty.Create(nameof(IsEnabled), typeof(bool?), typeof(CircularProgressStyle), null, propertyChanged: (bindable, oldValue, newValue) =>
        {
            ((CircularProgressStyle)bindable).isEnabled = (bool?)newValue;
        },
        defaultValueCreator: (bindable) =>
        {
            return ((CircularProgressStyle)bindable).isEnabled;
        });

        private ProgressStatusType state;
        private float? thickness;
        private float maxValue;
        private float minValue;
        private float currentValue;
        private float? bufferValue;
        private Color trackColor;
        private Color progressColor;
        private Color bufferColor;
        private bool? isEnabled;

        /// <summary>
        /// The status type of the Progress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public enum ProgressStatusType
        {
            /// <summary>
            /// Show BufferImage
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            Buffering,

            /// <summary>
            /// Show ProgressImage and BufferImage
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            Determinate,

            /// <summary>
            /// Show TrackImage
            /// </summary>
            [EditorBrowsable(EditorBrowsableState.Never)]
            Indeterminate
        }

        static CircularProgressStyle() { }

        /// <summary>
        /// Creates a new instance of a CircularProgressStyle.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CircularProgressStyle() : base()
        {
            Initialize();
        }

        /// <summary>
        /// Creates a new instance of a CircularProgressStyle with style.
        /// </summary>
        /// <param name="style">Create CircularProgressStyle by style customized by user.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CircularProgressStyle(CircularProgressStyle style) : base(style)
        {
            if (null == style) return;
            this.CopyFrom(style);
        }

        /// <summary>
        /// The thickness of the track and progress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? Thickness
        {
            get
            {
                return (float?)GetValue(ThicknessProperty);
            }
            set
            {
                SetValue(ThicknessProperty, value);
            }
        }

        /// <summary>
        /// The property to get/set the maximum value of the CircularProgress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float MaxValue
        {
            get
            {
                return (float)GetValue(MaxValueProperty);
            }
            set
            {
                SetValue(MaxValueProperty, value);
            }
        }

        /// <summary>
        /// The property to get/set the minim value of the CircularProgress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float MinValue
        {
            get
            {
                return (float)GetValue(MinValueProperty);
            }
            set
            {
                SetValue(MinValueProperty, value);
            }
        }

        /// <summary>
        /// The property to get/set the current value of the CircularProgress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float CurrentValue
        {
            get
            {
                return (float)GetValue(CurrentValueProperty);
            }
            set
            {
                SetValue(CurrentValueProperty, value);
            }
        }

        /// <summary>
        /// The property to get/set the buffer value of the CircularProgress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public float? BufferValue
        {
            get
            {
                return (float?)GetValue(BufferValueProperty);
            }
            set
            {
                SetValue(BufferValueProperty, value);
            }
        }

        /// <summary>
        /// Gets or sets state of progress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ProgressStatusType ProgressState
        {
            get
            {
                return (ProgressStatusType)GetValue(ProgressStateProperty);
            }
            set
            {
                SetValue(ProgressStateProperty, value);
            }
        }

        /// <summary>
        /// The property to get/set Track object color of the CircularProgress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color TrackColor
        {
            get
            {
                return (Color)GetValue(TrackColorProperty);
            }
            set
            {
                SetValue(TrackColorProperty, value);
            }
        }

        /// <summary>
        /// The property to get/set Progress object color of the CircularProgress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color ProgressColor
        {
            get
            {
                return (Color)GetValue(ProgressColorProperty);
            }
            set
            {
                SetValue(ProgressColorProperty, value);
            }
        }

        /// <summary>
        /// The property to get/set Buffer object color of the CircularProgress.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Color BufferColor
        {
            get
            {
                return (Color)GetValue(BufferColorProperty);
            }
            set
            {
                SetValue(BufferColorProperty, value);
            }
        }

        /// <summary>
        /// Flag to be enabled or disabled in CircularProgress.
        /// </summary>
        /// <since_tizen> 8 </since_tizen>
        public bool? IsEnabled
        {
            get
            {
                return (bool?)GetValue(IsEnabledProperty);
            }
            set
            {
                SetValue(IsEnabledProperty, value);
            }
        }

        /// <summary>
        /// Style's clone function.
        /// </summary>
        /// <param name="bindableObject">The style that need to copy.</param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override void CopyFrom(BindableObject bindableObject)
        {
            base.CopyFrom(bindableObject);

            CircularProgressStyle progressStyle = bindableObject as CircularProgressStyle;

            if (null != progressStyle)
            {
                isEnabled = progressStyle.isEnabled;
                state = progressStyle.state;
                thickness = progressStyle.Thickness;
                maxValue = progressStyle.maxValue;
                minValue = progressStyle.minValue;
                currentValue = progressStyle.currentValue;
                bufferValue = progressStyle.bufferValue;
                trackColor = progressStyle.trackColor;
                progressColor = progressStyle.progressColor;
                bufferColor = progressStyle.bufferColor;
            }
        }

        private void Initialize()
        {
            isEnabled = true;
            state = ProgressStatusType.Determinate;
            thickness = 6.0f;
            maxValue = 100.0f;
            minValue = 0.0f;
            currentValue = 0.0f;
            trackColor = new Color(0.0f, 0.16f, 0.30f, 1.0f);
            progressColor = new Color(0.0f, 0.55f, 1.0f, 1.0f);
        }
    }
}
