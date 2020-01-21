using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;

namespace BlazorAppPrint.Shared
{
    public class Person
    {
        public string P0 { get; set; }
        public MarkupString P0_2
        {
            get => (MarkupString)P0.Replace("\n", "<br/>");
        }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string P4 { get; set; }
        public string P5 { get; set; }

        public MarkupString P5_2
        {
            get => (MarkupString)P5.Replace("\n", "<br/>");
        }

        private string sectionStyle;
        private string nameStyle;

        public string GetSectionStyle()
        {
            SetStyle();
            return sectionStyle;

        }

        public string GetNameStyle()
        {
            SetStyle();
            return nameStyle;
        }

        private void SetStyle()
        {
            var ml = P0.Where(p => p == '\n').Count();

            if (ml == 0)
            {
                sectionStyle = "font-size:8.5pt;top:14.6mm";
                nameStyle = "top:21.0mm";
            }
            else if (ml == 1)
            {
                sectionStyle = "font-size:8.5pt;top:13.6mm";
                nameStyle = "top:22.0mm";
            }
            else
            {
                sectionStyle = "font-size:8pt;top:12.9mm";
                nameStyle = "top:22.8mm";
            }
        }
    }
}
