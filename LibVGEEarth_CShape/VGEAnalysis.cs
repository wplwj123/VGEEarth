using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace Analysis
    {
        /// <summary>
        /// 3D Analysis
        /// </summary>
        class VGE3DAnalysis
        {
            public VGE3DAnalysis();
            public ~VGE3DAnalysis();

            /// <summary>
            /// Build surface Triangulate
            /// </summary>
            /// <param name="points">the points of build surface</param>
            /// <returns></returns>
            public static GeoData.VGEGeoModel BuildTriangulate(GeoData.VGEPoint3Ds points);

            /// <summary>
            /// Compute Horizon Distance
            /// </summary>
            /// <param name="line1"></param>
            /// <param name="line2"></param>
            /// <param name="pntIntersect1"></param>
            /// <param name="pntIntersect2"></param>
            /// <param name="pntProIntersect1"></param>
            /// <param name="pntProIntersect2"></param>
            /// <param name="bIgnoreTerrain"></param>
            /// <returns></returns>
            public double ComputeHorizonDistance(GeoData.VGEGeoPolyline3D line1, GeoData.VGEGeoPolyline3D line2, out GeoData.VGEPoint3D pntIntersect1, 
                out GeoData.VGEPoint3D pntIntersect2, out GeoData.VGEPoint3D pntProIntersect1, out GeoData.VGEPoint3D pntProIntersect2, bool bIgnoreTerrain);

            /// <summary>
            /// Compute Two GeoPolyline Distance
            /// </summary>
            /// <param name="line1"></param>
            /// <param name="line2"></param>
            /// <param name="pntIntersect1"></param>
            /// <param name="pntIntersect2"></param>
            /// <param name="dHonLen"></param>
            /// <param name="dVerLen"></param>
            /// <param name="bIgnoreTerrain"></param>
            /// <param name="bCalNoIntersetLines"></param>
            /// <param name="dNoIntersetStartRatio"></param>
            /// <returns></returns>
            public double ComputeTwoGeoPolylineDistance(GeoData.VGEGeoPolyline3D line1, GeoData.VGEGeoPolyline3D line2, out GeoData.VGEPoint3D pntIntersect1, 
                out GeoData.VGEPoint3D pntIntersect2, out double dHonLen, out double dVerLen, bool bIgnoreTerrain, bool bCalNoIntersetLines, double dNoIntersetStartRatio);
            
            /// <summary>
            /// Compute Vertical Distance
            /// </summary>
            /// <param name="line1"></param>
            /// <param name="line2"></param>
            /// <param name="pntIntersect1"></param>
            /// <param name="pntIntersect2"></param>
            /// <param name="pntProIntersect1"></param>
            /// <param name="pntProIntersect2"></param>
            /// <param name="bIgnoreTerrain"></param>
            /// <returns></returns>
            public double ComputeVerticalDistance(GeoData.VGEGeoPolyline3D line1, GeoData.VGEGeoPolyline3D line2, out GeoData.VGEPoint3D pntIntersect1, 
                out GeoData.VGEPoint3D pntIntersect2, out GeoData.VGEPoint3D pntProIntersect1, out GeoData.VGEPoint3D pntProIntersect2, bool bIgnoreTerrain);
            
            /// <summary>
            /// Dig Fill Analyse
            /// </summary>
            /// <param name="geoPolygon"></param>
            /// <param name="dDestAlt"></param>
            /// <param name="dDigVolume"></param>
            /// <param name="dFillVolume"></param>
            /// <param name="dDigArea"></param>
            /// <param name="dFillArea"></param>
            /// <param name="dTotalArea"></param>
            /// <param name="pntMaxAlt"></param>
            /// <param name="pntMinAlt"></param>
            /// <param name="bUseSampleGap"></param>
            /// <param name="dDSampleGap"></param>
            /// <returns></returns>
            public bool DigFillAnalyse(GeoData.VGEGeoPolygon3D geoPolygon, double dDestAlt, out double dDigVolume, out double dFillVolume, 
                out double dDigArea, out double dFillArea, out double dTotalArea, out GeoData.VGEPoint3D pntMaxAlt, out GeoData.VGEPoint3D pntMinAlt, bool bUseSampleGap, double dDSampleGap);
            
            /// <summary>
            /// Dig Fill Analyse With Model
            /// </summary>
            /// <param name="geoPolygon"></param>
            /// <param name="dDestAlt"></param>
            /// <param name="dDigVolume"></param>
            /// <param name="dFillVolume"></param>
            /// <param name="dDigArea"></param>
            /// <param name="dFillArea"></param>
            /// <param name="dTotalArea"></param>
            /// <param name="dDSampleGap"></param>
            /// <param name="geoPolyline3DDig"></param>
            /// <param name="geoPolyline3DFill"></param>
            /// <returns></returns>
            public bool DigFillAnalyseWithModel(GeoData.VGEGeoPolygon3D geoPolygon, double dDestAlt, out double dDigVolume, out double dFillVolume, 
                out double dDigArea, out double dFillArea, out double dTotalArea, double dDSampleGap, GeoData.VGEGeoPolyline3D geoPolyline3DDig, GeoData.VGEGeoPolyline3D geoPolyline3DFill);
            
            /// <summary>
            /// Fetch Dig Fill Analyse Result
            /// </summary>
            /// <param name="dDestAlt"></param>
            /// <param name="dDigVolume"></param>
            /// <param name="dFillVolume"></param>
            /// <param name="dDigArea"></param>
            /// <param name="dFillArea"></param>
            /// <param name="dTotalArea"></param>
            /// <param name="pntMaxAlt"></param>
            /// <param name="pntMinAlt"></param>
            /// <returns></returns>
            public bool FetchDigFillAnalyseResult(double dDestAlt, out double dDigVolume, out double dFillVolume, out double dDigArea, out double dFillArea, 
                out double dTotalArea, out GeoData.VGEPoint3D pntMaxAlt, out GeoData.VGEPoint3D pntMinAlt);
            
            /// <summary>
            /// Fetch Dig Fill Analyse With Model Result
            /// </summary>
            /// <param name="dDestAlt"></param>
            /// <param name="dDigVolume"></param>
            /// <param name="dFillVolume"></param>
            /// <param name="dDigArea"></param>
            /// <param name="dFillArea"></param>
            /// <param name="dTotalArea"></param>
            /// <param name="geoPolyline3DDig"></param>
            /// <param name="geoPolyline3DFill"></param>
            /// <returns></returns>
            public bool FetchDigFillAnalyseWithModelResult(double dDestAlt, out double dDigVolume, out double dFillVolume, out double dDigArea, 
                out double dFillArea, out double dTotalArea, GeoData.VGEGeoPolyline3D geoPolyline3DDig, GeoData.VGEGeoPolyline3D geoPolyline3DFill);
            
            /// <summary>
            /// Fetch No Source Flood Analyse Result
            /// </summary>
            /// <param name="dDestAlt"></param>
            /// <param name="dFloodArea"></param>
            /// <param name="dTotalArea"></param>
            /// <param name="pntMaxAlt"></param>
            /// <param name="pntMinAlt"></param>
            /// <returns></returns>
            public bool FetchNoSourceFloodAnalyseResult(double dDestAlt, out double dFloodArea, out double dTotalArea, out GeoData.VGEPoint3D pntMaxAlt, 
                out GeoData.VGEPoint3D pntMinAlt);
            
            /// <summary>
            /// Get Ground Length
            /// </summary>
            /// <param name="geoLine3D"></param>
            /// <param name="bUseSampleGap"></param>
            /// <param name="dDSampleGap"></param>
            /// <returns></returns>
            public double GetGroundLength(GeoData.VGEGeoPolyline3D geoLine3D, bool bUseSampleGap, double dDSampleGap);
            
            /// <summary>
            /// Get Ground Length
            /// </summary>
            /// <param name="pnt3ds"></param>
            /// <param name="nPointCount"></param>
            /// <param name="bUseSampleGap"></param>
            /// <param name="dDSampleGap"></param>
            /// <returns></returns>
            public double GetGroundLength(GeoData.VGEPoint3Ds pnt3ds, int nPointCount, bool bUseSampleGap, double dDSampleGap);
            
            /// <summary>
            /// Get Polyline Segment
            /// </summary>
            /// <param name="geoPolyline"></param>
            /// <param name="dFromDistance"></param>
            /// <param name="dToDistance"></param>
            /// <returns></returns>
            public GeoData.VGEGeoPolyline3D GetPolylineSegment(GeoData.VGEGeoPolyline3D geoPolyline, double dFromDistance, double dToDistance);
           
            /// <summary>
            /// Get Polyline Segment
            /// </summary>
            /// <param name="geoPolyline"></param>
            /// <param name="dFromDistance"></param>
            /// <param name="dToDistance"></param>
            /// <param name="nSubIndex"></param>
            /// <param name="dGlobeRadius"></param>
            /// <param name="bDistIgnoreZ"></param>
            /// <returns></returns>
            public GeoData.VGEGeoPolyline3D GetPolylineSegment(GeoData.VGEGeoPolyline3D geoPolyline, double dFromDistance, double dToDistance, 
                int nSubIndex, double dGlobeRadius, bool bDistIgnoreZ);
            
            /// <summary>
            /// Whether two GeoPolyline Intersect in 2D
            /// </summary>
            /// <param name="line1"></param>
            /// <param name="line2"></param>
            /// <returns></returns>
            public bool IsTwoGeoPolylineIntersect2D(GeoData.VGEGeoPolyline3D line1, GeoData.VGEGeoPolyline3D line2);

            /// <summary>
            /// No Source Flood Analyse
            /// </summary>
            /// <param name="geoPolygon"></param>
            /// <param name="dDestAlt"></param>
            /// <param name="dFloodArea"></param>
            /// <param name="dTotalArea"></param>
            /// <param name="pntMaxAlt"></param>
            /// <param name="pntMinAlt"></param>
            /// <param name="bUseSampleGap"></param>
            /// <param name="dDSampleGap"></param>
            /// <returns></returns>
            public bool NoSourceFloodAnalyse(GeoData.VGEGeoPolygon3D geoPolygon, double dDestAlt, out double dFloodArea, out double dTotalArea, 
                out GeoData.VGEPoint3D pntMaxAlt, out GeoData.VGEPoint3D pntMinAlt, bool bUseSampleGap, double dDSampleGap);
            
            /// <summary>
            /// Profile Analyse
            /// </summary>
            /// <param name="geoPolyline"></param>
            /// <param name="nSamplePointNum"></param>
            /// <param name="pnt3ds"></param>
            /// <param name="dLineLength"></param>
            /// <param name="pntMax"></param>
            /// <param name="pntMin"></param>
            /// <param name="pntStart"></param>
            /// <param name="pntEnd"></param>
            /// <returns></returns>
            public bool ProfileAnalyse(GeoData.VGEGeoPolyline3D geoPolyline, int nSamplePointNum, out GeoData.VGEPoint3Ds pnt3ds, out double dLineLength, 
                out GeoData.VGEPoint3D pntMax, out GeoData.VGEPoint3D pntMin, out GeoData.VGEPoint3D pntStart, out GeoData.VGEPoint3D pntEnd);
           
            /// <summary>
            /// Profile Analyse With Model
            /// </summary>
            /// <param name="geoPolyline"></param>
            /// <param name="nSamplePointNum"></param>
            /// <param name="pnt3ds"></param>
            /// <param name="dLineLength"></param>
            /// <param name="pntMax"></param>
            /// <param name="pntMin"></param>
            /// <param name="pntStart"></param>
            /// <param name="pntEnd"></param>
            /// <returns></returns>
            public bool ProfileAnalyseWithModel(GeoData.VGEGeoPolyline3D geoPolyline, int nSamplePointNum, out GeoData.VGEPoint3Ds pnt3ds, out double dLineLength, 
                out GeoData.VGEPoint3D pntMax, out GeoData.VGEPoint3D pntMin, out GeoData.VGEPoint3D pntStart, out GeoData.VGEPoint3D pntEnd);


            protected static EventHandler.SteppedEventHandler m_stepped;
            public event EventHandler.SteppedEventHandler Stepped;
        };

        /// <summary>
        /// View Envelope Analysis(雷达分析，指定球心与半径的可视域分析)
        /// </summary>
        class VGEViewEnvelopeAnalysis
        {
            public VGEViewEnvelopeAnalysis();
            public ~VGEViewEnvelopeAnalysis();

            private double centerHeight;    //set, get  
        };

        /// <summary>
        /// Viewshed Analysis
        /// </summary>
        class VGEViewshedAnalysis
        {
            public VGEViewshedAnalysis();
            public ~VGEViewshedAnalysis();

            private double centerHeight;    //set, get
        };

        /// <summary>
        /// Viewshed 3DAnalysis
        /// </summary>
        class VGEViewshed3DAnalysis
        {
            public VGEViewshed3DAnalysis();
            public ~VGEViewshed3DAnalysis();

            public void SetDistDirByPoint(GeoData.VGEPoint3D value);

            private double direction;           //set, get
            private double distance;           //set, get
            private double horizontalFov;           //set, get
            private double pitch;           //set, get
            private double verticalFov;           //set, get
            private GeoData.VGEPoint3D viewerPosition;           //set, get
        };

        /// <summary>
        /// Track Tool
        /// </summary>
        abstract class VGETrackTool
        {
            public VGETrackTool();
            public ~VGETrackTool();

            public void Clear();
            public void ClearLastOne();

            private Enum.TrackMode trackMode;    //set, get
        };

        class VGETrackPolygonTool : VGETrackTool { };

        class VGETrackPolylineTool : VGETrackTool { };

        class VGETrackRectTool : VGETrackTool { };
    }
}
