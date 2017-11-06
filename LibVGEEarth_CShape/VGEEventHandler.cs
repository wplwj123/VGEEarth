using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VGEEarth
{
    namespace EventHandler
    {
        public class FeatureMouseClickEventArgs : System.EventArgs
        {
            public FeatureMouseClickEventArgs(GeoData.VGEFeature feature, GeoData.VGEPoint2D mousePos);

            private GeoData.VGEFeature feature;         //get
            private GeoData.VGEPoint2D mousePos;           //get

        }

        public delegate void FeatureMouseClickEventHandler(object sender, FeatureMouseClickEventArgs e);

        public class SteppedEventArgs : System.EventArgs
        {
            public SteppedEventArgs(double percent, string message);

            private bool cancel;   //set, get
            private string message;   //get
            private double percent;    //get
        }

        public delegate void SteppedEventHandler(object sender, SteppedEventArgs e);
    }
}
