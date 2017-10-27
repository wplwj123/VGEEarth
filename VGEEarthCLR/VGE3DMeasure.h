#pragma once

#include "VGEEnum.h"

namespace VGE{
	namespace Globe{

		class VGEAreaRuler{
		public:
			VGEAreaRuler();
			~VGEAreaRuler();

		public:
			void Clear();

		private:
			EnumAreaMeasureMode measureMode;   //set, get
			double groundArea;    //get
			double spaceArea;    //get
			double sphereArea;    //get
			bool spaceMeasure;   //set, get
		};

		class VGEDistanceRuler{
		public:
			VGEDistanceRuler();
			~VGEDistanceRuler();

		public:
			void Clear();

		private:
			EnumDistanceMeasureMode measureMode;    //set, get
			double currentGroundLength;    //get
			double currentSpaceLength;    //get
			double currentSphereLength;    //get
			double horiLength;             //get
			double totalGroundLength;    //get
			double totalSpaceLength;    //get
			double totalSphereLength;    //get
			double vertiLength;           //get
			bool spaceMeasure;           //set, get
		};

		class VGEHeightRuler{
		public:
			VGEHeightRuler();
			~VGEHeightRuler();

		public:
			void Clear();

		private:
			double heightAboveGround;    //get
			double heightAboveSea;     //get
			double spaceHeight;       //get
			bool spaceMeasure;        //set, get
		};

		class VGETrackTool{
		public:
			VGETrackTool();
			~VGETrackTool();

		public:
			void Clear();
			void ClearLastOne();

		private:
			EnumTrackMode trackMode;    //set, get
		};

		class VGETrackPolygonTool : public VGETrackTool{};

		class VGETrackPolylineTool : public VGETrackTool{};

		class VGETrackRectTool : public VGETrackTool{};
	}
}