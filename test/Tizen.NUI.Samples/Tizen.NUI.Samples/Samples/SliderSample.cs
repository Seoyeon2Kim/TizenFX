using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace Tizen.NUI.Samples
{
    public class SliderSample : IExample
    {
        private const float MIN_VALUE = 0;
        private const float MAX_VALUE = 100;

        private View root;
        private View top_parent, bottom_parent, ver_slider_parent, hori_slider_parent;
        private Slider[] slider_null_style = new Slider[4];
        private Slider[] slider_style = new Slider[4];

        public void Activate()
        {
            Window window = NUIApplication.GetDefaultWindow();

            root = new View()
            {
                Size = new Size(720, 1280),
                BackgroundColor = new Color(0.7f, 0.9f, 0.8f, 1.0f),
            };
            root.Layout = new LinearLayout() { LinearOrientation = LinearLayout.Orientation.Vertical };
            window.Add(root);



            Slider test = new Slider();
            test.TrackThickness = 4;
            test.ThumbSize = new Size(60, 60);
            test.BgTrackColor = new Color(0, 0, 0, 0.1f);
            test.SlidedTrackColor = new Color(0.05f, 0.63f, 0.9f, 1);
            test.Direction = Slider.DirectionType.Horizontal;
            test.Focusable = true;
            test.MinValue = MIN_VALUE;
            test.MaxValue = MAX_VALUE;
            test.StateChangedEvent += OnStateChanged;
            test.ValueChanged += OnValueChanged;
            test.SlidingStarted += OnSlidingStarted;
            test.SlidingFinished += OnSlidingFinished;
            test.Size = new Size(200, 50);
            test.CurrentValue = 20;

            // new properties
            test.IsValueShown = true;
            test.ValueIndicatorText = "Hello";
            test.ValueIndicatorImage = new ImageView(CommonResource.GetFHResourcePath() + "9. Controller/controller_switch_bg_on.png")
            {
                Size = new Size(100, 50),
                
            };

            root.Add(test);
        }

        private void InitSliders()
        {
            // Null style construction
            slider_null_style[0] = CreateByProperty(800, 50, 20, Slider.DirectionType.Horizontal);
            slider_null_style[1] = CreateByProperty(800, 50, 30, Slider.DirectionType.Horizontal);
            slider_null_style[1].LowIndicatorTextContent = "SubText";
            slider_null_style[1].LowIndicatorSize = new Size(100, 40);
            slider_null_style[2] = CreateByProperty(50, 400, 20, Slider.DirectionType.Vertical);
            slider_null_style[3] = CreateByProperty(50, 400, 30, Slider.DirectionType.Vertical);
            slider_null_style[3].LowIndicatorTextContent = "SubText";
            slider_null_style[3].LowIndicatorSize = new Size(100, 40);

            // Style construction
            SliderStyle st = new SliderStyle
            {
                TrackThickness = 4,
                Track = new ImageViewStyle
                {
                    BackgroundColor = new Selector<Color>
                    {
                        All = new Color(0, 0, 0, 0.1f),
                    }
                },

                Progress = new ImageViewStyle
                {
                    BackgroundColor = new Selector<Color>
                    {
                        All = new Color(0.05f, 0.63f, 0.9f, 1),
                    }
                },

                Thumb = new ImageViewStyle
                {
                    Size = new Size(60, 60),
                    ResourceUrl = new Selector<string>
                    {
                        Normal = CommonResource.GetFHResourcePath() + "9. Controller/controller_btn_slide_handler_normal.png",
                        Pressed = CommonResource.GetFHResourcePath() + "9. Controller/controller_btn_slide_handler_press.png",
                    },
                    BackgroundImage = new Selector<string>
                    {
                        Normal = "",
                        Pressed = CommonResource.GetFHResourcePath() + "9. Controller/controller_btn_slide_handler_effect.png",
                    }
                }
            };
            slider_style[0] = CreateByStyle(st, 800, 50, 20, Slider.DirectionType.Horizontal);
            slider_style[1] = CreateByStyle(st, 800, 50, 30, Slider.DirectionType.Horizontal);
            slider_style[1].LowIndicatorTextContent = "SubText";
            slider_style[1].LowIndicatorSize = new Size(100, 40);
            slider_style[2] = CreateByStyle(st, 50, 400, 20, Slider.DirectionType.Vertical);
            slider_style[3] = CreateByStyle(st, 50, 400, 30, Slider.DirectionType.Vertical);
            slider_style[3].LowIndicatorTextContent = "SubText";
            slider_style[3].LowIndicatorSize = new Size(100, 40);
        }


        public void Deactivate()
        {
            if (root != null)
            {
                NUIApplication.GetDefaultWindow().Remove(root);

                root.Dispose();
                root = null;
            }
        }

        private Slider CreateByProperty(int w, int h, int curValue, Slider.DirectionType dir)
        {
            // Setting the property of selector is not supported now, so add these in style first.
            SliderStyle st = new SliderStyle
            {
                Thumb = new ImageViewStyle()
                {
                    ResourceUrl = new Selector<string>
                    {
                        Normal = CommonResource.GetFHResourcePath() + "9. Controller/controller_btn_slide_handler_normal.png",
                        Pressed = CommonResource.GetFHResourcePath() + "9. Controller/controller_btn_slide_handler_press.png",
                    },
                    BackgroundImage = new Selector<string>
                    {
                        Normal = "",
                        Pressed = CommonResource.GetFHResourcePath() + "9. Controller/controller_btn_slide_handler_effect.png",
                    }
                }
            };
            Slider source = new Slider(st);
            source.TrackThickness = 4;
            source.ThumbSize = new Size(60, 60);
            source.BgTrackColor = new Color(0, 0, 0, 0.1f);
            source.SlidedTrackColor = new Color(0.05f, 0.63f, 0.9f, 1);
            source.Direction = dir;
            source.Focusable = true;
            source.MinValue = MIN_VALUE;
            source.MaxValue = MAX_VALUE;
            source.StateChangedEvent += OnStateChanged;
            source.ValueChanged += OnValueChanged;
            source.SlidingStarted += OnSlidingStarted;
            source.SlidingFinished += OnSlidingFinished;
            source.Size = new Size(w, h);
            source.CurrentValue = curValue;
            return source;
        }

        private Slider CreateByStyle(SliderStyle st, int w, int h, int curValue, Slider.DirectionType dir)
        {
            // input style in construction
            Slider source = new Slider(st);
            source.Direction = dir;
            //root.Add(source);
            source.Focusable = true;
            source.MinValue = MIN_VALUE;
            source.MaxValue = MAX_VALUE;
            source.StateChangedEvent += OnStateChanged;
            source.ValueChanged += OnValueChanged;
            source.SlidingStarted += OnSlidingStarted;
            source.SlidingFinished += OnSlidingFinished;
            source.Size = new Size(w, h);
            source.CurrentValue = curValue;
            return source;
        }

        private void OnValueChanged(object sender, SliderValueChangedEventArgs args)
        {
            Slider source = sender as Slider;
            if (source != null)
            {
                {
                    Tizen.Log.Error("Seoyeon","Value Changed : currentValue = " + args.CurrentValue + "\n");
                }
            }
        }

        private void OnSlidingStarted(object sender, SliderSlidingStartedEventArgs args)
        {
            Slider source = sender as Slider;
            if (source != null)
            {
                {
                    Tizen.Log.Error("Seoyeon","Started currentValue = " + args.CurrentValue + "\n");
                }
            }
        }

        private void OnSlidingFinished(object sender, SliderSlidingFinishedEventArgs args)
        {
            Slider source = sender as Slider;
            if (source != null)
            {
                {
                    Tizen.Log.Error("Seoyeon","Finished currentValue = " + args.CurrentValue + "\n");
                }
            }
        }

        private void OnStateChanged(object sender, Slider.StateChangedArgs args)
        {
            if (sender is Tizen.NUI.Components.Slider)
            {
                Tizen.NUI.Components.Slider slider = sender as Tizen.NUI.Components.Slider;
                if (slider != null)
                {
                    // Do something
                    Tizen.Log.Error("Seoyeon","OnStateChanged .\n");
                }
            }
        }
    }
}
