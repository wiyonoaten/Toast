using System;
using System.ComponentModel;
using System.Globalization;
using MonoTouch.Foundation;

namespace ScalessecToastBindingLib
{
	[TypeConverter(typeof(ToastPositionTypeConverter))]
	public enum ToastPosition
	{
		Top,
		Bottom,
		Center,
	}

	internal class ToastPositionTypeConverter : TypeConverter
	{
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return (sourceType == typeof(NSString) || base.CanConvertFrom(context, sourceType));
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is NSString)
			{
				switch ((value as NSString).ToString())
				{
					case "top": return ToastPosition.Top;
					case "bottom": return ToastPosition.Bottom;
					case "center": return ToastPosition.Center;
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return (destinationType == typeof(NSString) || base.CanConvertTo(context, destinationType));
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(NSString))
			{
				var position = (ToastPosition)value;
				switch (position)
				{
					case ToastPosition.Top: return new NSString("top");
					case ToastPosition.Bottom: return new NSString("bottom");
					case ToastPosition.Center: return new NSString("center");
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

	}
}
