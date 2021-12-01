﻿using System.Threading.Tasks;
using ExpensesApp.Interfaces;
using Foundation;
using UIKit;

namespace ExpensesApp.iOS
{
    public class Share : IShare
    {
        public async Task Show(string title, string message, string filePath)
        {
            var viewController = GetVisibleViewController();
            var items = new NSObject[] {NSObject.FromObject(title), NSUrl.FromFilename(filePath)};
            var activityController = new UIActivityViewController(items, null);
            if (activityController.PopoverPresentationController != null)
                activityController.PopoverPresentationController.SourceView = viewController.View;
            await viewController.PresentViewControllerAsync(activityController, true);
        }

        private UIViewController GetVisibleViewController()
        {
            var rootViewController = UIApplication.SharedApplication.KeyWindow.RootViewController;
            if (rootViewController.PresentedViewController == null)
                return rootViewController;
            if (rootViewController.PresentedViewController is UINavigationController)
                return ((UINavigationController) rootViewController.PresentedViewController).TopViewController;
            if (rootViewController.PresentedViewController is UITabBarController)
                return ((UITabBarController) rootViewController.PresentedViewController).SelectedViewController;
            return rootViewController.PresentedViewController;
        }
    }
}