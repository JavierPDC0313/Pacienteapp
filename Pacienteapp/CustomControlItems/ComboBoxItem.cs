using System;
using System.Collections.Generic;
using System.Text;

namespace Pacienteapp.CustomControlItems
{
    public class ComboBoxItem
    {

        public string Text { get; set; }

        public Object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}
