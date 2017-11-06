using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace GeoData
    {
        struct Color
        {
            int r, g, b, o;
        };
        
        struct VGEPoint2D { };

        struct VGEPoint3D { };

        class VGEPoint3Ds { };

        abstract class VGEGeometry { };

        class VGEGeoPit : VGEGeometry { };

        class VGEGeoEntity : VGEGeometry { };

        class VGEGeoModel : VGEGeoEntity { };

        class VGEGeoPolyline3D : VGEGeometry { };

        class VGEGeoPolygon3D : VGEGeometry { };

        struct VGERect2D { };

        class VGEFeature { };

        class VGEFeatures { };

        class VGEFieldAttr { };

        class VGEPowerLineTemplate { };


        //Style
        abstract class VGEStyle { };

        class VGEStyle3D : VGEStyle { };

        class VGELineStyle3D : VGEStyle3D { };

        class VGEPipeLineStyle3D : VGELineStyle3D { };

        class VGEElecLineStyle3D : VGEPipeLineStyle3D { };

        class VGEEntityStyle3D : VGEStyle3D { };

        class VGEPointStyle3D : VGEStyle3D { };

        class VGEIconPointStyle3D : VGEPointStyle3D { };

        class VGEMarkerStyle3D : VGEIconPointStyle3D { };

        class VGEExtrudeStyle { };

        class VGETextStyle { };
    }
}
