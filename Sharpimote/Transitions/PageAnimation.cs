using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Sharpimote.Transitions
{
    internal class PageAnimation : IPageAnimator
    {
        Window mainWin = MainWindow.Instance;
        public PageAnimation() { }
        public void NavigateWithSlideAnimation(Frame renderFrame,Page pageToNavigate)
        {
            var sb = new Storyboard();
            var slideAnimation = new ThicknessAnimation
            {
                Duration = TimeSpan.FromSeconds(0.5),
                From = new Thickness(0, 0, 0, 0),
                To = new Thickness(-renderFrame.ActualWidth, 0, renderFrame.ActualWidth, 0),
                DecelerationRatio = 0.9
            };
            Storyboard.SetTargetProperty(slideAnimation, new PropertyPath("Margin"));
            sb.Children.Add(slideAnimation);
            sb.Completed += (sender, args) =>
            {
                renderFrame.Navigate(pageToNavigate);
                var reverseAnimation = new ThicknessAnimation
                {
                    Duration = TimeSpan.FromSeconds(0),
                    From = new Thickness(renderFrame.ActualWidth, 0, -renderFrame.ActualWidth, 0),
                    To = new Thickness(0, 0, 0, 0)
                };
                Storyboard.SetTargetProperty(reverseAnimation, new PropertyPath("Margin"));
                var reverseSb = new Storyboard();
                reverseSb.Children.Add(reverseAnimation);
                reverseSb.Begin(renderFrame);
            };
            sb.Begin(renderFrame);
            MakeWindowSizeAnim(pageToNavigate);
        }
        public void MakeWindowSizeAnim(Page pageToFit)
        {
            Storyboard sb = new Storyboard();
            const float MARGIN = 50;
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = mainWin.Width;
            widthAnimation.To = pageToFit.Width + MARGIN; // New width after resizing
            widthAnimation.Duration = new Duration(TimeSpan.FromSeconds(0.4));
            Storyboard.SetTargetProperty(widthAnimation, new PropertyPath("Width"));

            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.From = mainWin.Height;
            heightAnimation.To = pageToFit.Height + MARGIN; // New height after resizing
            Storyboard.SetTargetProperty(heightAnimation, new PropertyPath("Height"));
            sb.Children.Add(widthAnimation);
            sb.Children.Add(heightAnimation);
            sb.Begin(mainWin);
        }
    }
}
