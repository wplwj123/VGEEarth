#pragma once

namespace VGE{
	namespace Globe{

		class VGELatLonGrid{
		public:
			VGELatLonGrid();
			~VGELatLonGrid();

		private:
			bool lineVisible;      //set, get
			bool textVisible;      //set, get
			bool visible;      //set, get
		};

	}
}