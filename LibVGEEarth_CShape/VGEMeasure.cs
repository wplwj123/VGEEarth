using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace Measure
    {
        class VGEAreaRuler
        {
            public VGEAreaRuler();
            public ~VGEAreaRuler();

            public void Clear();

            private Enum.AreaMeasureMode measureMode;   //set, get
            private double groundArea;    //get
            private double spaceArea;    //get
            private double sphereArea;    //get
            private bool spaceMeasure;   //set, get
        };

        class VGEDistanceRuler
        {
            public VGEDistanceRuler();
            public ~VGEDistanceRuler();

            public void Clear();

            private Enum.DistanceMeasureMode measureMode;    //set, get
            private double currentGroundLength;    //get
            private double currentSpaceLength;    //get
            private double currentSphereLength;    //get
            private double horiLength;             //get
            private double totalGroundLength;    //get
            private double totalSpaceLength;    //get
            private double totalSphereLength;    //get
            private double vertiLength;           //get
            private bool spaceMeasure;           //set, get
        };

        class VGEHeightRuler
        {
            public VGEHeightRuler();
            public ~VGEHeightRuler();

            public void Clear();

            private double heightAboveGround;    //get
            private double heightAboveSea;     //get
            private double spaceHeight;       //get
            private bool spaceMeasure;        //set, get
        };
    }
}
