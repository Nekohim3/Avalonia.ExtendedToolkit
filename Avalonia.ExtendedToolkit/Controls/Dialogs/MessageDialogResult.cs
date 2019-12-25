﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Avalonia.ExtendedToolkit.Controls.Dialogs
{
    /// <summary>
    /// An enum representing the result of a Message Dialog.
    /// </summary>
    public enum MessageDialogResult
    {
        Canceled = -1,
        Negative = 0,
        Affirmative = 1,
        FirstAuxiliary,
        SecondAuxiliary
    }
}
