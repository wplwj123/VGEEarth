#pragma once

#include "VGEGeoData.h"

using namespace VGE::GeoData;

namespace VGE{
	namespace Globe{

		class VGE3DAnalysis{
		public:
			VGE3DAnalysis();
			~VGE3DAnalysis();

		public:
			static VGEGeoModel BuildTriangulate(VGEPoint3Ds points);
			static double ComputeHorizonDistance(VGEGeoPolyline3D line1, VGEGeoPolyline3D line2, VGEPoint3D pntIntersect1,
				VGEPoint3D pntIntersect2, VGEPoint3D pntProIntersect1, VGEPoint3D pntProIntersect2, bool bIgnoreTerrain);
			static double ComputeTwoGeoPolylineDistance(VGEGeoPolyline3D line1, VGEGeoPolyline3D line2, VGEPoint3D pntIntersect1,
				VGEPoint3D pntIntersect2, double dHonLen, double dVerLen, bool bIgnoreTerrain, bool bCalNoIntersetLines, double dNoIntersetStartRatio);
			static double ComputeVerticalDistance(VGEGeoPolyline3D line1, VGEGeoPolyline3D line2, VGEPoint3D pntIntersect1,
				VGEPoint3D pntIntersect2, VGEPoint3D pntProIntersect1, VGEPoint3D pntProIntersect2, bool bIgnoreTerrain);
			static bool DigFillAnalyse(VGEGeoPolygon3D geoPolygon, double dDestAlt, double dDigVolume,
				double dFillVolume, double dDigArea, double dFillArea, double dTotalArea, VGEPoint3D pntMaxAlt,
				VGEPoint3D pntMinAlt, bool bUseSampleGap, double dDSampleGap);
			static bool DigFillAnalyseWithModel(VGEGeoPolygon3D geoPolygon, double dDestAlt, double dDigVolume,
				double dFillVolume, double dDigArea, double dFillArea, double dTotalArea, double dDSampleGap,
				VGEGeoPolyline3D geoPolyline3DDig, VGEGeoPolyline3D geoPolyline3DFill);
			static bool FetchDigFillAnalyseResult(double dDestAlt, double dDigVolume, double dFillVolume,
				double dDigArea, double dFillArea, double dTotalArea, VGEPoint3D pntMaxAlt, VGEPoint3D pntMinAlt);
			static bool FetchDigFillAnalyseWithModelResult(double dDestAlt, double dDigVolume, double dFillVolume,
				double dDigArea, double dFillArea, double dTotalArea, VGEGeoPolyline3D geoPolyline3DDig, VGEGeoPolyline3D geoPolyline3DFill);
			static bool FetchNoSourceFloodAnalyseResult(double dDestAlt, double dFloodArea, double dTotalArea, VGEPoint3D pntMaxAlt, VGEPoint3D pntMinAlt);
			static double GetGroundLength(VGEGeoPolyline3D geoLine3D, bool bUseSampleGap, double dDSampleGap);
			static double GetGroundLength(VGEPoint3Ds pnt3ds, int nPointCount, bool bUseSampleGap, double dDSampleGap);
			static VGEGeoPolyline3D GetPolylineSegment(VGEGeoPolyline3D geoPolyline, double dFromDistance, double dToDistance);
			static VGEGeoPolyline3D GetPolylineSegment(VGEGeoPolyline3D geoPolyline, double dFromDistance, double dToDistance,
				int nSubIndex, double dGlobeRadius, bool bDistIgnoreZ);
			static bool IsTwoGeoPolylineIntersect2D(VGEGeoPolyline3D line1, VGEGeoPolyline3D line2);
			static bool NoSourceFloodAnalyse(VGEGeoPolygon3D geoPolygon, double dDestAlt, double dFloodArea,
				double dTotalArea, VGEPoint3D pntMaxAlt, VGEPoint3D pntMinAlt, bool bUseSampleGap, double dDSampleGap);
			static bool ProfileAnalyse(VGEGeoPolyline3D geoPolyline, int nSamplePointNum, VGEPoint3Ds pnt3ds,
				double dLineLength, VGEPoint3D pntMax, VGEPoint3D pntMin, VGEPoint3D pntStart, VGEPoint3D pntEnd);
			static bool ProfileAnalyseWithModel(VGEGeoPolyline3D geoPolyline, int nSamplePointNum, VGEPoint3Ds pnt3ds,
				double dLineLength, VGEPoint3D pntMax, VGEPoint3D pntMin, VGEPoint3D pntStart, VGEPoint3D pntEnd);

		};

		class VGEViewEnvelopeAnalysis{
		public:
			VGEViewEnvelopeAnalysis();
			~VGEViewEnvelopeAnalysis();

		private:
			double centerHeight;    //set, get
		};

		class VGEViewshedAnalysis{
		public:
			VGEViewshedAnalysis();
			~VGEViewshedAnalysis();

		private:
			double centerHeight;    //set, get
		};

		class VGEViewshed3DAnalysis{
		public:
			VGEViewshed3DAnalysis();
			~VGEViewshed3DAnalysis();

		public:
			void SetDistDirByPoint(VGEPoint3D value);

		private:
			double direction;           //set, get
			double distance;           //set, get
			double horizontalFov;           //set, get
			double pitch;           //set, get
			double verticalFov;           //set, get
			VGEPoint3D viewerPosition;           //set, get
		};

	}
}