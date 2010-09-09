using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Constructor.Compilers
{

    class TidyHtml
    {
        private string html;

        public TidyHtml(string html)
        {
            this.html = html;
        }

        public string tidy()
        {
            ZetaHtmlTidy.HtmlTidy tidy = new ZetaHtmlTidy.HtmlTidy();
            string result = tidy.CleanHtml(this.html);

            return result;
        }

    }
}
