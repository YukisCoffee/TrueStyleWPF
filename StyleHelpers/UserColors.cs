using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukisCoffee.TrueStyleWPF.StyleHelpers;

/// <summary>
///     Stores all USER colour settings at creation time.
/// </summary>
internal class UserColors
{
    public readonly Color ActiveBorder;

    public UserColors()
    {
        this.ActiveBorder = SystemColors.ActiveBorder;
    }
}