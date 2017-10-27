#pragma once

#include "VGEEnum.h"
#include "VGEGeoData.h"

using namespace VGE::GeoData;

namespace VGE{
	namespace Globe{

		class VGEControlPanel{
		public:
			VGEControlPanel();
			~VGEControlPanel();

		private:
			bool fadeOut;   //set, get
			int maxOpaque;   //set, get
			int minOpaque;   //set, get
			bool visible;    //set, get
			Color highlightColor;  //set, get
		};

		class VGEHudControl{
		public:
			VGEHudControl();
			~VGEHudControl();

		public:
			void AjustRect();
			void SetOffset(double dX, double dY);

		private:
			EnumAlign align;    //set, get
			EnumAlign textAlign;    //set, get
			bool fadeOut;       //set, get
			Color highlightRectColor;   //set, get
			Color rectColor;    //set, get
			Color rectOutlineColor;    //set, get
			VGETextStyle textStyle;    //set, get
			VGETextStyle highlightTextStyle;    //set, get
			bool isRectVisible;              //set, get
			float maxOpaque;    //set, get
			float minOpaque;    //set, get
			std::string name;    //set, get
			VGEPoint2D offset;    //set, get
			VGEPoint2D textOffset;    //set, get
			bool offsetFixed;    //set, get
			std::string Text;    //set, get
			bool visible;    //set, get
		};

		class VGEStatusBar{
		public:
			VGEStatusBar();
			~VGEStatusBar();

		public:
			void SetProject(std::string strProject);
			bool GetTextVisible(EnumStatusBarText A_0);
			void SetTextVisible(EnumStatusBarText type, bool bVisible);

		private:
			int lonlatShowMode;            //set, get
			int pixelsBetweenTextItem;           //set, get
			VGETextStyle textStyle;           //set, get
			int textToEndPixels;           //set, get
			int textToStartPixels;           //set, get
			bool visible;           //set, get
		};

	}
}