﻿namespace NynaeveLib.Enumerations.Converters
{
  using System;
  using System.Windows;
  using System.Windows.Data;

  public class BoolToVisCollapsedVisibilityConverter : IValueConverter
  {
    public BoolToVisCollapsedVisibilityConverter()
    {
      this.Inverted = false;
    }

    public bool Inverted
    {
      get;
      set;
    }

    public object Convert(
      object value,
      Type targetType,
      object parameter,
      System.Globalization.CultureInfo culture)
    {
      if (this.Inverted)
      {
        return (bool)value ? Visibility.Collapsed : Visibility.Visible;
      }

      return (bool)value ? Visibility.Visible : Visibility.Collapsed;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
