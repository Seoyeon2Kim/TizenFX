
using System;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Accessibility;


namespace Tizen.NUI.Samples
{
    
    public class AccessibilityManagerSample : IExample
    {
        Size2D windowSize;

        public void Activate()
        {
            Window window = NUIApplication.GetDefaultWindow();
            window.BackgroundColor = Color.White;
            windowSize = window.Size;

            View pageView = new View()
            {
                BackgroundColor = Color.Blue,
                PositionUsesPivotPoint = true,
                ParentOrigin = ParentOrigin.Center,
                PivotPoint = PivotPoint.Center,
                Size = new Size(500,500),
                AccessibilityHighlightable = true,
                AccessibilityRole = Role.PushButton,
            };
            window.GetDefaultLayer().Add(pageView);

            View deleteButtonView = new View()
            {
                PositionUsesPivotPoint = true,
                ParentOrigin = NUI.ParentOrigin.TopCenter,
                PivotPoint = NUI.PivotPoint.TopCenter,
                PositionY = -42 - 2 - 37.5f - 93,
                Size = new Size(93, 93),
                BackgroundImage = CommonResource.GetFHResourcePath() + "6. List/list_ic_dropdown.png",

                AccessibilityHighlightable = true,
                AccessibilityRole = Role.PushButton,
                AccessibilityName = "Delete"
            };
            pageView.Add(deleteButtonView);

        }


        private void OnNameRequested(object sender, GetNameEventArgs e)
        {
            e.Name = "DeleteButton";
        }

        private void OnActivated(object sender, EventArgs e)
        {
            Tizen.Log.Error("Seoyeon", "Activated is called !!!!!!!!");
        }


        public void Deactivate()
        {
        }
    }
}
