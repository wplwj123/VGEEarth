// VGEEarthCLR.h

#pragma once

#include "VGEGlobeControl.h"

using namespace System;

namespace VGEEarthCLR {

	public ref class GlobeControl
	{
	public:
		GlobeControl();
		~GlobeControl();

	public:
		void initEarth();

	private:
		VGE::Globe::VGEGlobeControl* globeControl;
	};
}
