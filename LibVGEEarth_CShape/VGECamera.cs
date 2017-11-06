using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace Globe
    {
        /// <summary>
        /// ViewPort Camera look at
        /// </summary>
        class VGECameraLookAt
        {
            public VGECameraLookAt();
            public ~VGECameraLookAt();

            private GeoData.VGEPoint3D direction;    //set, get
            private GeoData.VGEPoint3D position;    //set, get
            private GeoData.VGEPoint3D upDir;       //set, get
        };


        /// <summary>
        /// Camera State
        /// </summary>
        class VGECameraState
        {
            public VGECameraState();
            public ~VGECameraState();

            private Enum.AltitudeMode altitudeMode;    //set, get
            private double altitude;          //set, get
            private double distance;          //set, get
            private double heading;           //set, get
            private double latitude;          //set, get
            private double longtitude;        //set, get
            private double tilt;              //set, get
        };
    }
}
