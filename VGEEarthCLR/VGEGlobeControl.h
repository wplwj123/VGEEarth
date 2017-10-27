#pragma once

#include "VGEGlobe.h"

namespace VGE{
	namespace Globe{

		class VGEGlobeControl{
		public:
			VGEGlobeControl();
			~VGEGlobeControl();

		public:
			bool HasNaviInertia();
			void ImmediatelyRefresh();
			void Refresh();
			void SetActionCursor();
			void SetNaviInertia();
			void SetNeedRefresh();
			void SwapBuffer();

			//
		protected:
			void WndProc();
			void Dispose();
			void OnGotFocus();
			void OnHandleDestroyed();
			void OnKeyDown();
			void OnKeyUp();
			void OnLoad();
			void OnMouseDoubleClick();
			void OnMouseDown();
			void OnMouseHover();
			void OnMouseLeave();
			void OnMouseMove();
			void OnMouseUp();
			void OnMouseWheel();
			void OnPaint();
			void OnPaintBackground();
			void OnPreviewKeyDown();
			void OnSizeChanged();

			//VGEEventHandler
		public:
			void AfterKeyDownDeleteFeatureEvent();
			void AfterLayerAddEvent();
			void AfterLayerMoveEvent();
			void AfterLayerRemoveEvent();
			void AfterNetLayerAddEvent();
			void AfterNetSceneAddEvent();
			void AfterNetTerrainAddEvent();
			void AfterTerrainAddEvent();
			void AfterTerrainMoveEvent();
			void AfterTerrainRemoveEvent();
			void BeforeKeyDownDeleteFeatureEvent();
			void BeforeLayerRemoveEvent();
			void BeforeSceneRenderEvent();
			void BeforeTerrainRemoveEvent();
			void CameraBeginMoveEvent();
			void CameraBeginStopEvent();
			void DrawAddFeatureEvent();
			void FeatureMouseClickEvent();
			void FeatureMouseHoverEvent();
			void FeatureMouseIntoEvent();
			void FeatureMouseOutEvent();
			void FeatureMouseOverEvent();
			void FeatureSelectedEvent();
			void FlyOverEvent();
			void HudControlMouseDbClickEvent();
			void HudControlMouseDownEvent();
			void HudControlMouseIntoEvent();
			void HudControlMouseMoveEvent();
			void HudControlMouseOutEvent();
			void HudControlMouseUpEvent();
			void TrackPolygonEndEvent();
			void TrackPolylineEndEvent();
			void TrackRectEndEvent();

		private:
			VGEGlobe globe;                 //get
			bool isOnlyActiveRender;          //set, get
			bool isRotateDirAccordWithNavi;   //set, get
		};

	}
}