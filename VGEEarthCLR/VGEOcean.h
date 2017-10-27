#pragma once

#include <string>
#include "VGEGeoData.h"

using namespace VGE::GeoData;

namespace VGE{
	namespace Globe{

		class VGEOcean{
		public:
			VGEOcean();
			~VGEOcean();

		public:
			bool AddRotorWash(std::string strName, VGEPoint3D pos, double dVelocity, int nRotorWashSize);
			bool AddShipWake(std::string strName, VGEPoint3D pos, bool bSprayEffect, double dBowSprayOffset, double dBowWaveOffset, double dBeamWidth, double dLength);
			void RemoveAllRotorWash();
			void RemoveAllShipWake();
			bool RemoveRotorWash(std::string strName);
			bool RemoveShipWake(std::string strName);
			void SimulateSeaState(double dBeaufortScale, double dWindDirection);
			void UpdateRotorWash(std::string strName, VGEPoint3D pos, double dVelocity);
			void UpdateShipWake(std::string strName, VGEPoint3D pos);

		private:
			double seaLevel;       //set, get
			bool visible;              //set, get
		};

	}
}