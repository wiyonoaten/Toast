using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.ComponentModel;

namespace ScalessecToastBindingLib
{
	/*
	 * TODO: why can't get this partial to work??
	public static partial class Toast_UIView_2
	{
		public static void MakeToast(this UIView view, string message, double interval, ToastPosition position)
		{
			view.MakeToast(message, interval, (NSObject)TypeDescriptor.GetConverter(typeof(ToastPosition)).ConvertTo(position, typeof(NSObject)));
		}
	}*/

	public static class ToastPositionExtensions
	{
		public static NSString ToNSString(this ToastPosition position)
		{
			return (NSString)TypeDescriptor.GetConverter(typeof(ToastPosition)).ConvertTo(position, typeof(NSString));
		}

		public static ToastPosition ToPosition(this NSString str)
		{
			return (ToastPosition)TypeDescriptor.GetConverter(typeof(NSString)).ConvertTo(str, typeof(ToastPosition));
		}
	}
}

