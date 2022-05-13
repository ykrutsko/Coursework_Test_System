using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace TextBoxHintLib
{
    public static class TextBoxHint
    {
        private static readonly FieldInfo _field;
        private static readonly PropertyInfo _prop;

        static TextBoxHint()
        {
            Type type = typeof(Control);
            _field = type.GetField("text", BindingFlags.Instance | BindingFlags.NonPublic);
            _prop = type.GetProperty("WindowText", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        // using textbox.SetValue("...") to change text and the TextChanged event will not be fired.
        public static void InitHint(this TextBox box, string hint)
        {
            box.ForeColor = Color.Gray;
            _field.SetValue(box, hint);
            _prop.SetValue(box, hint, null);
            box.GotFocus += (source, ex) =>
            {
                TextBox t = (TextBox)source;
                if (t.Text == hint && t.ForeColor == Color.Gray)
                {
                    _field.SetValue(box, string.Empty);
                    _prop.SetValue(box, string.Empty, null);
                    t.ForeColor = Color.Black;
                }
            };

            box.LostFocus += (source, ex) =>
            {
                TextBox t = (TextBox)source;
                if(!t.Text.Any())
                {
                    t.ForeColor = Color.Gray;
                    _field.SetValue(box, hint);
                    _prop.SetValue(box, hint, null);
                }
            };

            box.TextChanged += (source, ex) =>
            {
                TextBox t = (TextBox)source;
                if (!t.Text.Any() && !t.Focused)
                {
                    t.ForeColor = Color.Gray;
                    _field.SetValue(box, hint);
                    _prop.SetValue(box, hint, null);
                }
            };
        }
    }
}

