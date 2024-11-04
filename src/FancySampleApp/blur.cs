using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUIEx;

namespace FancySampleApp;
public partial class BlurredBackdrop : CompositionBrushBackdrop
{
    protected override Windows.UI.Composition.CompositionBrush CreateBrush(Windows.UI.Composition.Compositor compositor)
        => compositor.CreateHostBackdropBrush();
}

public class MyClass
{
    public MyClass()
    {
        var x = new TransparentTintBackdrop();
    }
}