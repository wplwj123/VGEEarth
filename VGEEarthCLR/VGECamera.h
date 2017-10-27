#pragma once

#include "VGEEnum.h"
#include "VGEGeoData.h"

using namespace VGE::GeoData;

namespace VGE{
	namespace Globe{

		class VGECameraLookAt{
		public:
			VGECameraLookAt();
			~VGECameraLookAt();

		private:
			VGEPoint3D direction;    //set, get
			VGEPoint3D position;    //set, get
			VGEPoint3D upDir;       //set, get
		};

		class VGECameraState{
		public:
			VGECameraState();
			~VGECameraState();

		private:
			EnumAltitudeMode altitudeMode;    //set, get
			double altitude;          //set, get
			double distance;          //set, get
			double heading;           //set, get
			double latitude;          //set, get
			double longtitude;        //set, get;
			double tilt;              //set, get
		};

	}
}