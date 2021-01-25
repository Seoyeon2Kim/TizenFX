
using System;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Accessibility;
using Tizen.NUI.Components;

///////////////////////////////////////////////////////////////////////////////////////////////
///                      How to turn on and test Accessibility                              ///
/// There are two ways to turn on screen reader (TTS) in the target                         ///
///  1) Settings > Accessibility > Screen reader > On                                       ///
///  2) Open Terminal and use command :                                                     ///
///      # vconftool set -f -t bool db/setting/accessibility/tts 1                          ///
///    If you turn off screen reader, type and execute text based command below :           ///
///      # vconftool set -f -t bool db/setting/accessibility/tts 0                          ///
///////////////////////////////////////////////////////////////////////////////////////////////

namespace Tizen.NUI.Samples
{
    public class AccessibilityManagerSample : IExample
    {
        Button textButton;
        Button iconButton;

        Button iconTextButton;
        ImageView highlight;

        Size2D windowSize;

        public void Activate()
        {
            Window window = NUIApplication.GetDefaultWindow();
            window.BackgroundColor = Color.White;
            windowSize = window.Size;

            window.KeyEvent += Window_KeyEvent;

            // Only show a text button.
            textButton = new Button();
            textButton.BackgroundImage = "/home/seoyeon/mywork/github/TizenFX/test/Tizen.NUI.Samples/Tizen.NUI.Samples/res/images/FH3/9. Controller/controller_switch_bg_on.png";
            textButton.BackgroundImageBorder = new Rectangle(4, 4, 5, 5);
            textButton.Position = new Position(20, 20);
            textButton.Size = new Size(90, 90);
            textButton.TextLabel.Text = "Button";
            textButton.Icon.ResourceUrl = "/home/seoyeon/mywork/github/TizenFX/test/Tizen.NUI.Samples/Tizen.NUI.Samples/res/images/FH3/10. Drop Down/dropdown_checkbox_on.png";
            window.Add(textButton);

            highlight = new ImageView();
            highlight.ResourceUrl = "/home/seoyeon/mywork/github/TizenFX/test/Tizen.NUI.Samples/Tizen.NUI.Samples/res/images/FH3/9. Controller/picker_date_scheduling_bg_01.png";
            highlight.WidthResizePolicy = ResizePolicyType.FillToParent;
            highlight.HeightResizePolicy = ResizePolicyType.FillToParent;
            highlight.ParentOrigin = ParentOrigin.Center;
            highlight.PivotPoint = PivotPoint.Center;
            highlight.PositionUsesPivotPoint = true;
            highlight.Position = new Position(0, 0);
            textButton.Add(highlight);

            Tizen.Log.Error("Seoyeon","### highlight size : "+highlight.Size.Width+", Height : "+highlight.Size.Height+"\n");

            //Only show an icon button.
           /* iconButton = new Button();
            iconButton.Text = "";
            iconButton.Name = "IconButton";
            iconButton.BackgroundImage = CommonResource.GetTVResourcePath() + "component/c_buttonbasic/c_basic_button_white_bg_normal_9patch.png";
            iconButton.BackgroundImageBorder = new Rectangle(4, 4, 5, 5);
            iconButton.Size = new Size(80, 80);
            iconButton.Icon.ResourceUrl = CommonResource.GetTVResourcePath() + "component/c_radiobutton/c_radiobutton_white_check.png";
            //window.Add(iconButton);
            iconButton.Clicked += (ojb, e) => {
                var btn = iconButton.Icon.GetParent() as Button;
                string name = btn.Name;
            };

            //Show a button with icon and text.
            iconTextButton = new Button();
            iconTextButton.Text = "IconTextButton";
            iconTextButton.BackgroundImage = CommonResource.GetTVResourcePath() + "component/c_buttonbasic/c_basic_button_white_bg_normal_9patch.png";
            iconTextButton.BackgroundImageBorder = new Rectangle(4, 4, 5, 5);
            iconTextButton.IconRelativeOrientation = Button.IconOrientation.Left;
            iconTextButton.Icon.ResourceUrl = CommonResource.GetTVResourcePath() + "component/c_radiobutton/c_radiobutton_white_check.png";
            iconTextButton.IconPadding = new Extents(20, 20, 20, 20);
            iconTextButton.TextPadding = new Extents(20, 50, 20, 20);
            iconTextButton.Size = new Size(500, 300);
           // window.Add(iconTextButton);*/
        }

        private void Window_KeyEvent(object sender, Window.KeyEventArgs e)
        {
            if(e.Key.State == Key.StateType.Up)
            {
                switch(e.Key.KeyPressedName)
                {
                    case "1":
                        //iconTextButton.IconRelativeOrientation = Button.IconOrientation.Right;
                        Tizen.Log.Error("Seoyeon","@@@ highlight size : "+highlight.Size.Width+", Height : "+highlight.Size.Height+"\n");
                        break;
                    case "2":
                       // iconTextButton.IconRelativeOrientation = Button.IconOrientation.Top;
                        break;

                }
            }
        }

        public void Deactivate()
        {
            textButton.Dispose();
            textButton = null;

            iconTextButton.Dispose();
            iconTextButton = null;
        }
    }
}