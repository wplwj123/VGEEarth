#pragma once

#include "VGEGeoData.h"
using namespace VGE::GeoData;

namespace VGE{
	namespace Globe{

		class VGEAtmosphere{
		public:
			VGEAtmosphere();
			~VGEAtmosphere();

		private:
			bool shaderUsing;  // set, get
			bool visible;      //set, get
		};

		class VGEClouds{
		public:
			VGEClouds();
			~VGEClouds();

		private:
			bool visible;   //set, get
		};

		class VGERain{
		public:
			VGERain();
			~VGERain();

		private:
			float directionFix;        //set, get
			float directionRnd;        //set, get
			float emitPerSec;        //set, get
			float emitterXZAngleFix;        //set, get
			int maxCount;        //set, get
			VGEPoint2D sizeFix;        //set, get
			VGEPoint2D sizeRnd;        //set, get
			bool visible;        //set, get
		};

		class VGELight{
		public:
			VGELight();
			~VGELight();

		private:
			Color ambient;            //set, get
			Color diffuse;            //set, get
			Color specular;            //set, get
			EnumLightMode lightMode;            //set, get
			bool lightOn;            //set, get
			EnumLightType lightType;            //set, get
			VGEPoint3D Position;            //set, get
		};

		class VGESkyBox{
		public:
			VGESkyBox();
			~VGESkyBox();

		private:
			std::string bkImage;   //set
			std::string dnImage;   //set
			std::string frImage;   //set
			std::string lfImage;   //set
			std::string rtImage;   //set
			std::string upImage;   //set
			bool visible;   //set, get
		};

		class VGESnow{
		public:
			VGESnow();
			~VGESnow();

		private:
			float directionFix;          //set, get
			float directionRnd;          //set, get
			float emitPerSec;          //set, get
			float emitterXZAngleFix;          //set, get
			int maxCount;          //set, get
			VGEPoint2D sizeFix;          //set, get
			VGEPoint2D sizeRnd;          //set, get
			bool visible;          //set, get
		};

		class VGESun{
		public:
			VGESun();
			~VGESun();

		public:
			int* GetPositionTime();
			void SetPosition(int x, int y, int z);
			void SetPositionByTime(int nYear, int nMonth, int nDate, int nHour, int nMinitus, int nSeconds);

		private:
			double distanceToEarth;        //set, get
			bool isRealTimePos;        //set, get
			double radius;        //set, get
			bool visible;        //set, get
		};

		class VGEUnderGroundFloor{
		public:
			VGEUnderGroundFloor();
			~VGEUnderGroundFloor();

		private:
			double altitude;           //set, get
			std::string floorImage;    //set
			int gridRowNum;        //set, get
			bool isVisibleAboveGroud;        //set, get
			int meshGridRowNum;        //set, get
			double oneGridLen;        //set, get
			bool visible;        //set, get
		};

	}
}