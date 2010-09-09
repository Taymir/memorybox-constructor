using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor.DataClasses
{
    class exportCSS
    {
        private string source =
@"Application {
	color: #000000;
	border-style: none;
	background-gradient-colors: #FFFFFF, #FFFFFF;
	background-gradient-alphas: 1.0, 1.0;
}

.popup {
	background-alpha: 1.0;
	background-color: #FFFFFF;
}

VideoDisplay {
	background-color: #FFFFFF;
	background-alpha: 0;
}

List {
	color: #000000;
	borderColor: #ffffff;
	border-style: none;
	selectionColor: %HIGHLIGHT_COLOR%;
	borderColor: #000000;
	fontColor: #000000;
	rollOverColor: #efefef;
}

.ListSelected
{
	color: #FFFFFF;
}
.ListUnselected
{
	color: %HIGHLIGHT_COLOR%;
}

ScrollBar
{
	cornerRadius: 0;
	upArrowUpSkin: Embed(source=""assets/scrollbarStyles/up_arrow.png"");
	downArrowUpSkin: Embed(source=""assets/scrollbarStyles/down_arrow.png"");
	trackSkin: Embed(source=""assets/scrollbarStyles/track.png"");
	thumbUpSkin: Embed(source=""assets/scrollbarStyles/icon2.png"");
	thumbIcon: Embed(source=""assets/scrollbarStyles/icon2.png"");
	thumbOverSkin: Embed(source=""assets/scrollbarStyles/icon2.png"");
	thumbDownSkin: Embed(source=""assets/scrollbarStyles/icon2.png"");
	downArrowOverSkin: Embed(source=""assets/scrollbarStyles/down_arrow.png"");
	downArrowDownSkin: Embed(source=""assets/scrollbarStyles/down_arrow.png"");
	downArrowDisabledSkin: Embed(source=""assets/scrollbarStyles/down_arrow.png"");
	upArrowOverSkin: Embed(source=""assets/scrollbarStyles/up_arrow.png"");
	upArrowDownSkin: Embed(source=""assets/scrollbarStyles/up_arrow.png"");
	upArrowDisabledSkin: Embed(source=""assets/scrollbarStyles/up_arrow.png"");
}

.MySlider {
	thumbSkin: Embed(source=""assets/scrollbarStyles/icon.png"");
	trackSkin: Embed(source=""assets/scrollbarStyles/progress_bar.png"");
}


Text.dynamicSectionHeading
{
	color: %NORMAL_COLOR%;
	fontFamily: Arial;
	fontSize: 16;
	fontWeight: bold;
}
.StaticText
{
	color: %HIGHLIGHT_COLOR%;
	fontFamily: Verdana;
	fontWeight: bold;
}
.dynamicText
{
	color: %NORMAL_COLOR%;
	fontFamily: Verdana;
}

.submenuLink
{
	color: %SUBMENU_COLOR%;
	padding-left: -5;
	padding-right: -5;
}

.pictureBorder
{
	border-color: %HIGHLIGHT_COLOR%;
	border-thickness: 1;
	border-style: solid;
}
";
        private DataRegistry registry;

        public exportCSS(DataRegistry registry)
        {
            this.registry = registry;
        }

        public string export()
        {
            source = source.Replace("%HIGHLIGHT_COLOR%", registry.css_color_highlight);
            source = source.Replace("%NORMAL_COLOR%", registry.css_color_normal);
            source = source.Replace("%SUBMENU_COLOR%", registry.css_color_submenu);

            return source;
        }
    }
}
