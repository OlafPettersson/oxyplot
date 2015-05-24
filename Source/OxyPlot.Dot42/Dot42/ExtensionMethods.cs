// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionMethods.cs" company="OxyPlot">
//   Copyright (c) 2014 OxyPlot contributors
// </copyright>
// <summary>
//   Provides extension methods that converts between Android types and OxyPlot types.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace OxyPlot.Dot42
{
    using System;

    using Android.Graphics;
    using Android.Views;

    /// <summary>
    /// Provides extension methods that converts between Android types and OxyPlot types.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Converts an <see cref="OxyColor" /> to a <see cref="Color" />.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted color.</returns>
        public static int ToColor(this OxyColor color)
        {
            return color.IsInvisible() ? Color.TRANSPARENT : Color.Argb(color.A, color.R, color.G, color.B);
        }

        /// <summary>
        /// Converts an <see cref="LineJoin" /> to a <see cref="Paint.Join" />.
        /// </summary>
        /// <param name="join">The join value to convert.</param>
        /// <returns>The converted join value.</returns>
        public static Paint.Join Convert(this LineJoin join)
        {
            switch (join)
            {
                case LineJoin.Bevel:
                    return Paint.Join.BEVEL;
                case LineJoin.Miter:
                    return Paint.Join.MITER;
                case LineJoin.Round:
                    return Paint.Join.ROUND;
                default:
                    throw new InvalidOperationException("Invalid join type.");
            }
        }

        /// <summary>
        /// Converts an <see cref="MotionEvent" /> to a <see cref="OxyTouchEventArgs" />.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        /// <param name = "scale">The resolution scale factor.</param>
        /// <returns>The converted event arguments.</returns>
        public static OxyTouchEventArgs ToTouchEventArgs(this MotionEvent e, double scale)
        {
            return new OxyTouchEventArgs
            {
                Position = new ScreenPoint(e.GetX(e.ActionIndex) / scale, e.GetY(e.ActionIndex) / scale),
                DeltaTranslation = new ScreenVector(0, 0),
                DeltaScale = new ScreenVector(1, 1)
            };
        }

        /// <summary>
        /// Gets the touch points from the specified <see cref="MotionEvent" /> argument.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        /// <param name = "scale">The resolution scale factor.</param>
        /// <returns>The touch points.</returns>
        public static ScreenPoint[] GetTouchPoints(this MotionEvent e, double scale)
        {
            var result = new ScreenPoint[e.PointerCount];
            for (int i = 0; i < e.PointerCount; i++)
            {
                result[i] = new ScreenPoint(e.GetX(i) / scale, e.GetY(i) / scale);
            }

            return result;
        }

        /// <summary>
        /// Converts an <see cref="Keycode" /> to a <see cref="OxyKey" />.
        /// </summary>
        /// <param name="keyCode">The key code.</param>
        /// <returns>The converted key.</returns>
        public static OxyKey Convert(this int keyCode)
        {
            switch (keyCode)
            {
                case KeyEvent.KEYCODE_A:
                    return OxyKey.A;
                case KeyEvent.KEYCODE_PLUS:
                    return OxyKey.Add;
                case KeyEvent.KEYCODE_B:
                    return OxyKey.B;
                case KeyEvent.KEYCODE_BACK:
                    return OxyKey.Backspace;
                case KeyEvent.KEYCODE_C:
                    return OxyKey.C;
                case KeyEvent.KEYCODE_D:
                    return OxyKey.D;
#if !DOT42
                case KeyEvent.KEYCODE_NUMPAD_0:
                    return OxyKey.D0;
                case KeyEvent.KEYCODE_NUMPAD_1:
                    return OxyKey.D1;
                case KeyEvent.KEYCODE_NUMPAD_2:
                    return OxyKey.D2;
                case KeyEvent.KEYCODE_NUMPAD_3:
                    return OxyKey.D3;
                case KeyEvent.KEYCODE_NUMPAD_4:
                    return OxyKey.D4;
                case KeyEvent.KEYCODE_NUMPAD_5:
                    return OxyKey.D5;
                case KeyEvent.KEYCODE_NUMPAD_6:
                    return OxyKey.D6;
                case KeyEvent.KEYCODE_NUMPAD_7:
                    return OxyKey.D7;
                case KeyEvent.KEYCODE_NUMPAD_8:
                    return OxyKey.D8;
                case KeyEvent.KEYCODE_NUMPAD_9:
                    return OxyKey.D9;
#endif
                case KeyEvent.KEYCODE_COMMA:
                    return OxyKey.Decimal;
                case KeyEvent.KEYCODE_DEL:
                    return OxyKey.Delete;
                case KeyEvent.KEYCODE_SLASH:
                    return OxyKey.Divide;
                case KeyEvent.KEYCODE_DPAD_DOWN:
                    return OxyKey.Down;
                case KeyEvent.KEYCODE_E:
                    return OxyKey.E;
                case KeyEvent.KEYCODE_ENTER:
                    return OxyKey.Enter;
                case KeyEvent.KEYCODE_F:
                    return OxyKey.F;

                case KeyEvent.KEYCODE_G:
                    return OxyKey.G;
                case KeyEvent.KEYCODE_H:
                    return OxyKey.H;
                case KeyEvent.KEYCODE_HOME:
                    return OxyKey.Home;
                case KeyEvent.KEYCODE_I:
                    return OxyKey.I;
                case KeyEvent.KEYCODE_J:
                    return OxyKey.J;
                case KeyEvent.KEYCODE_K:
                    return OxyKey.K;
                case KeyEvent.KEYCODE_L:
                    return OxyKey.L;
                case KeyEvent.KEYCODE_DPAD_LEFT:
                    return OxyKey.Left;
                case KeyEvent.KEYCODE_M:
                    return OxyKey.M;
                case KeyEvent.KEYCODE_STAR:
                    return OxyKey.Multiply;
                case KeyEvent.KEYCODE_N:
                    return OxyKey.N;
                case KeyEvent.KEYCODE_O:
                    return OxyKey.O;
                case KeyEvent.KEYCODE_P:
                    return OxyKey.P;
                case KeyEvent.KEYCODE_Q:
                    return OxyKey.Q;
                case KeyEvent.KEYCODE_R:
                    return OxyKey.R;
                case KeyEvent.KEYCODE_DPAD_RIGHT:
                    return OxyKey.Right;
                case KeyEvent.KEYCODE_S:
                    return OxyKey.S;
                case KeyEvent.KEYCODE_SPACE:
                    return OxyKey.Space;
                case KeyEvent.KEYCODE_MINUS:
                    return OxyKey.Subtract;
                case KeyEvent.KEYCODE_T:
                    return OxyKey.T;
                case KeyEvent.KEYCODE_TAB:
                    return OxyKey.Tab;
                case KeyEvent.KEYCODE_U:
                    return OxyKey.U;
                case KeyEvent.KEYCODE_DPAD_UP:
                    return OxyKey.Up;
                case KeyEvent.KEYCODE_V:
                    return OxyKey.V;
                case KeyEvent.KEYCODE_W:
                    return OxyKey.W;
                case KeyEvent.KEYCODE_X:
                    return OxyKey.X;
                case KeyEvent.KEYCODE_Y:
                    return OxyKey.Y;
                case KeyEvent.KEYCODE_Z:
                    return OxyKey.Z;
                default:
                    return OxyKey.Unknown;
            }
        }

        /// <summary>
        /// Gets the <see cref="OxyModifierKeys" /> from a <see cref="KeyEvent" /> .
        /// </summary>
        /// <param name="e">The key event arguments.</param>
        /// <returns>The converted modifier keys.</returns>
        public static OxyModifierKeys GetModifierKeys(this KeyEvent e)
        {
            var result = OxyModifierKeys.None;

            if (e.IsAltPressed)
            {
                result |= OxyModifierKeys.Alt;
            }

            if (e.IsShiftPressed)
            {
                result |= OxyModifierKeys.Shift;
            }

            if (e.IsSymPressed)
            {
                // The SYM meta key is pressed. Can we use this as control?
                result |= OxyModifierKeys.Control;
            }

            return result;
        }

        /// <summary>
        /// Converts an <see cref="KeyEvent" /> to a <see cref="OxyKeyEventArgs" />.
        /// </summary>
        /// <param name="e">The event arguments.</param>
        /// <returns>The converted event arguments.</returns>
        /// <remarks>See also <a href="http://developer.android.com/reference/android/view/KeyEvent.html">KeyEvent</a> reference.</remarks>
        public static OxyKeyEventArgs ToKeyEventArgs(this KeyEvent e)
        {
            return new OxyKeyEventArgs
            {
                Key = e.KeyCode.Convert(),
                ModifierKeys = e.GetModifierKeys()
            };
        }
    }
}