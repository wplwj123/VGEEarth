using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace Control
    {
        class VGEControlPanel
        {
            public VGEControlPanel();
            public ~VGEControlPanel();

            private bool fadeOut;   //set, get
            private int maxOpaque;   //set, get
            private int minOpaque;   //set, get
            private bool visible;    //set, get
            private GeoData.Color highlightColor;  //set, get
        };

        class VGEHudControl
        {
            public VGEHudControl();
            public ~VGEHudControl();

            public void AjustRect();
            public void SetOffset(double dX, double dY);

            private Enum.Align align;    //set, get
            private Enum.Align textAlign;    //set, get
            private bool fadeOut;       //set, get
            private GeoData.Color highlightRectColor;   //set, get
            private GeoData.Color rectColor;    //set, get
            private GeoData.Color rectOutlineColor;    //set, get
            private GeoData.VGETextStyle textStyle;    //set, get
            private GeoData.VGETextStyle highlightTextStyle;    //set, get
            private bool isRectVisible;              //set, get
            private float maxOpaque;    //set, get
            private float minOpaque;    //set, get
            private string name;    //set, get
            private GeoData.VGEPoint2D offset;    //set, get
            private GeoData.VGEPoint2D textOffset;    //set, get
            private bool offsetFixed;    //set, get
            private string Text;    //set, get
            private bool visible;    //set, get
        };

        class VGEStatusBar
        {
            public VGEStatusBar();
            public ~VGEStatusBar();

            public void SetProject(string strProject);
            public bool GetTextVisible(Enum.StatusBarText A_0);
            public void SetTextVisible(Enum.StatusBarText type, bool bVisible);

            private int lonlatShowMode;            //set, get
            private int pixelsBetweenTextItem;           //set, get
            private GeoData.VGETextStyle textStyle;           //set, get
            private int textToEndPixels;           //set, get
            private int textToStartPixels;           //set, get
            private bool visible;           //set, get
        };
    }
}
