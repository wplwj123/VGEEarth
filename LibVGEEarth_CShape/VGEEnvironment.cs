using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace Globe
    {
        class VGEAtmosphere
        {
            public VGEAtmosphere();
            public ~VGEAtmosphere();

            private bool shaderUsing;  // set, get
            private bool visible;      //set, get
        };

        class VGEClouds
        {
            public VGEClouds();
            public ~VGEClouds();

            private bool visible;   //set, get
        };

        class VGERain
        {
            public VGERain();
            public ~VGERain();

            private float directionFix;        //set, get
            private float directionRnd;        //set, get
            private float emitPerSec;        //set, get
            private float emitterXZAngleFix;        //set, get
            private int maxCount;        //set, get
            private GeoData.VGEPoint2D sizeFix;        //set, get
            private GeoData.VGEPoint2D sizeRnd;        //set, get
            private bool visible;        //set, get
        };

        class VGELight
        {
            public VGELight();
            public ~VGELight();

            private GeoData.Color ambient;            //set, get
            private GeoData.Color diffuse;            //set, get
            private GeoData.Color specular;            //set, get
            private Enum.LightMode lightMode;            //set, get
            private bool lightOn;            //set, get
            private Enum.LightType lightType;            //set, get
            private GeoData.VGEPoint3D Position;            //set, get
        };

        class VGESkyBox
        {
            public VGESkyBox();
            public ~VGESkyBox();

            private string bkImage;   //set
            private string dnImage;   //set
            private string frImage;   //set
            private string lfImage;   //set
            private string rtImage;   //set
            private string upImage;   //set
            private bool visible;   //set, get
        };

        class VGESnow
        {
            public VGESnow();
            public ~VGESnow();

            private float directionFix;          //set, get
            private float directionRnd;          //set, get
            private float emitPerSec;          //set, get
            private float emitterXZAngleFix;          //set, get
            private int maxCount;          //set, get
            private GeoData.VGEPoint2D sizeFix;          //set, get
            private GeoData.VGEPoint2D sizeRnd;          //set, get
            private bool visible;          //set, get
        };

        class VGESun
        {
            public VGESun();
            public ~VGESun();

            public int* GetPositionTime();
            public void SetPosition(int x, int y, int z);
            public void SetPositionByTime(int nYear, int nMonth, int nDate, int nHour, int nMinitus, int nSeconds);

            private double distanceToEarth;        //set, get
            private bool isRealTimePos;        //set, get
            private double radius;        //set, get
            private bool visible;        //set, get
        };

        class VGEOcean
        {
            public VGEOcean();
            public ~VGEOcean();

            public bool AddRotorWash(string strName, GeoData.VGEPoint3D pos, double dVelocity, int nRotorWashSize);
            public bool AddShipWake(string strName, GeoData.VGEPoint3D pos, bool bSprayEffect, double dBowSprayOffset, double dBowWaveOffset, double dBeamWidth, double dLength);
            public void RemoveAllRotorWash();
            public void RemoveAllShipWake();
            public bool RemoveRotorWash(string strName);
            public bool RemoveShipWake(string strName);
            public void SimulateSeaState(double dBeaufortScale, double dWindDirection);
            public void UpdateRotorWash(string strName, GeoData.VGEPoint3D pos, double dVelocity);
            public void UpdateShipWake(string strName, GeoData.VGEPoint3D pos);

            private double seaLevel;       //set, get
            private bool visible;              //set, get
        };

        class VGEUnderGroundFloor
        {
            public VGEUnderGroundFloor();
            public ~VGEUnderGroundFloor();

            private double altitude;           //set, get
            private string floorImage;    //set
            private int gridRowNum;        //set, get
            private bool isVisibleAboveGroud;        //set, get
            private int meshGridRowNum;        //set, get
            private double oneGridLen;        //set, get
            private bool visible;        //set, get
        };

        class VGELatLonGrid
        {
            public VGELatLonGrid();
            public ~VGELatLonGrid();

            private bool lineVisible;      //set, get
            private bool textVisible;      //set, get
            private bool visible;      //set, get
        };
    }
}
