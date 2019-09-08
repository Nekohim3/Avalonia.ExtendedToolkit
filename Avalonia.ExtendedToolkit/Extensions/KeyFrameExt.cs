﻿using Avalonia.Animation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalonia.ExtendedToolkit.Extensions
{
    public class KeyFrameExt: KeyFrame
    {
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }


        public static readonly AvaloniaProperty NameProperty =
            AvaloniaProperty.Register<KeyFrameExt, string>(nameof(Name));





    }
}
