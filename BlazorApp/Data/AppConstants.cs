using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public static class AppConstants
    {
        public enum QuestionType
        {
            Textbox,
            RadioButton,
            DropDown,
            SingleCheckBox,
            MultiCheckBox
        }
    }
}
