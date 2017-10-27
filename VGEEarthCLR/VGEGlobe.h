#pragma once

#include "VGEEnum.h"
#include "VGE3DAnalysis.h"
#include "VGEAnimationPages.h"
#include "VGE3DMeasure.h"
#include "VGEEnvironment.h"
#include "VGECamera.h"
#include "VGEControl.h"
#include "VGEDataManager.h"
#include "VGELayer.h"
#include "VGELatLonGrid.h"
#include "VGEOcean.h"

using namespace VGE::GeoData;

namespace VGE{
	namespace Globe{

		class VGEGlobe{
		public:
			VGEGlobe();
			~VGEGlobe();

		public:
			void AddFeatureToSelection(VGEFeature feature, bool bAllowEdit);
			void AddHudControl(VGEHudControl control);
			int AddPit(std::string strName, VGEGeoPit geoPit);
			bool AddToEditHistroy(VGELayer layer, VGEFeature feature, EnumEditType eType);
			bool AddToEditHistroy(VGELayer layer, VGEFeature feature, VGEFeature oldFeature, EnumEditType eType);
			void ButtjointPipelineDataset(VGEDataset dataset, bool bIgnoreZ, double dTolerance);
			void ButtjointPipelineDataset(VGEDataset dataset);
			void ButtjointSelPipeline(bool bIgnoreZ, double dTolerance);
			void ButtjointSelPipeline();
			void ButtjointSelPipelineWithIntersect();
			void CancelPipelineDatasetJoint(VGEDataset dataset, bool bCancelHeadJoint, bool bCanchelTailJoint);
			void CancelSelPipelineJoint(bool bCancelHeadJoint, bool bCanchelTailJoint);
			void ClearAnalysis();
			void ClearLastTrackPolygon();
			void ClearLastTrackPolyline();
			void ClearMeasure();
			void ClearSelection();
			bool ConnectServer(std::string strIP, int nPort, std::string strUser, std::string strPsw);
			int ConnectServer2(std::string strIP, int nPort, std::string strUser, std::string strPsw);
			void ContinueFly();
			void DecjointSelPipeline(double dDecHead, double dDecTail);
			void FlyAlongWithLine(VGEGeoPolyline3D geoLine, double dHeightAboveLine, double dHeading, double dTilt);
			void FlyAroundCenter(double dRepeatValue, EnumFlyRepeatValueType enValueType);
			void FlyAroundCenter();
			void FlyAroundEye(double dRepeatValue, EnumFlyRepeatValueType enValueType);
			void FlyAroundEye();
			void FlyAroundFeature(VGEFeature feature, bool bAlwaysFly, double dRepeatValue, EnumFlyRepeatValueType enValueType);
			void FlyAroundGeometry(VGEGeometry geometry, bool bAlwaysFly, double dRepeatValue, EnumFlyRepeatValueType enValueType);
			void FlyAroundPosition(VGEPoint3D position, bool bAlwaysFly, double dRepeatValue, EnumFlyRepeatValueType enValueType);
			void FlyEyeAlongWithLine(VGEGeoPolyline3D geoLine);
			void FlyEyeAlongWithLine(VGEGeoPolyline3D geoLine, EnumAltitudeMode altMode, double dHeightAboveLine, double dTilt, bool bUseParamTilt, double dHeading, bool bUseParamHeading);
			void FlyEyeAlongWithLine(VGEGeoPolyline3D geoLine, double dHeightAboveLine, double dTilt, bool bUseParamTilt, double dHeading, bool bUseParamHeading);
			void FlyToCameraState(VGECameraState cameraState);
			void FlyToFeature(VGEFeature feature, double dHeading, double dTilt, double dDistance);
			void FlyToFeature(VGEFeature feature);
			void FlyToGeometry(VGEGeometry geometry, double dHeading, double dTilt, double dDistance);
			void FlyToGeometry(VGEGeometry geometry);
			void FlyToPosition(VGEPoint3D position, EnumAltitudeMode altMode, double dHeading, double dTilt, double dDistance);
			void FlyToPosition(VGEPoint3D position, EnumAltitudeMode altMode);
			void FullExtent();
			double Get2PointDist(VGEPoint3D pnt1, VGEPoint3D pnt2);
			double Get2PointEulaDist(VGEPoint3D pnt1, VGEPoint3D pnt2);
			VGEHudControl GetHudControlByName(std::string name);
			VGEGeoPit GetPitByID(int nID);
			VGEGeoPit GetPitByName(std::string strName);
			void GetSelectObject(int nIndex, VGEFeature resFeature, VGELayer resLayer);
			double GetZ(double lon, double lat);
			VGEFeature HitTest(int x, int y, bool isIgnore2DObject, bool isIgnoreLayerSelectable);
			VGEFeature HitTest(int x, int y, VGELayer resLayer, VGEPoint3D geoPoint, bool isIgnore2DObject, bool isIgnoreLayerSelectable, int nSelLevel);
			VGEFeature InsertJointPipeline(bool bAddToDestLayer);
			VGEGeoPolyline3D InsertJointPipeline1(VGEPipeLineStyle3D resultStyle);
			bool IsCameraChanged();
			bool IsVideoRecording();
			void JumpTo(VGECameraLookAt cameraLookAt);
			void JumpToCameraState(VGECameraState cameraState);
			void JumpToFeature(VGEFeature feature, double dDistance);
			void JumpToGeometry(VGEGeometry geometry, double dDistance);
			void JumpToPosition(VGEPoint3D position, EnumAltitudeMode altMode, double dDistance);
			bool OpenWorkSpace(std::string strPath);
			bool OutputHighPic(float dWidthPix, float dHightPix, std::string strFilePath);
			void PaseRecordVideo();
			void PauseFly();
			void ReDoEdit();
			void Refresh();
			void RefreshAnalysis();
			void RemoveAllPits();
			void RemoveLastPit();
			void RemovePitByID(int nID);
			void RemovePitByName(std::string strName);
			void ResumeRecordVideo();
			void SaveAsWorkSpace(std::string strPath);
			VGEPoint2D SceneToScreen(VGEPoint3D pnt);
			VGEPoint3D ScreenToScene(int x, int y);
			void StartRecordVideo();
			void StopFly();
			void StopRecordVideo();
			void UnDoEdit();

		private:
			EnumAction3D action;   //set, get
			EnumCameraMode cameraMode;   //set, get
			EnumRenderDetail ModelRenderDetail;          //set, get
								
			VGECameraLookAt cameraLookAt;  //set, get
			VGECameraState cameraState;    //set, get

			VGEAtmosphere Atmosphere;  //get
			VGEClouds clouds;            //get
			VGEOcean ocean;        //get
			VGERain rain;           //get
			VGELight sceneLight;     //get
			VGESkyBox skyBox;          //get
			VGESnow snow;             //get
			VGESun sun;           //get
			VGEUnderGroundFloor UnderGroundFloor;  //get

			VGEControlPanel controlPanel;   //get
			VGEHudControl overviewControl;   //get
			VGEHudControl scalerControl;      //get
			VGEStatusBar statusBar;           //get

			VGELayers layers;                 //get
			VGETerrains Terrains;             //get
			VGELayer destLayerFeatureAdd;               //set, get
			VGELatLonGrid latlonGrid;        //get	
			VGEMemoryLayer memoryLayer;       //get
			VGELayer selectedObjectLayer;      //get
			VGEFeature selectedObject;        //get
			VGEPoint3D selNodePos;          //get
			VGERect2D viewBounds;            //get
			VGEAnimationPages animationPages;  //get

			VGE3DAnalysis analysis3D;  //get
			VGEViewEnvelopeAnalysis viewEnvelopeAnalysis;   //get
			VGEViewshedAnalysis ViewshedAnalysis;     //get
			VGEViewshed3DAnalysis Viewshed3DAnalysis;     //get
			VGEAreaRuler areaRuler;  //get
			VGEDistanceRuler distanceRuler;        //get
			VGEHeightRuler heightRuler;           //get
			VGETrackPolygonTool trackPolygonTool;  //get
			VGETrackPolylineTool trackPolylineTool;  //get
			VGETrackRectTool trackRectTool;  //get

            VGEElecLineStyle3D defaultElecLineStyle3D;   //set, get
			VGEElecLineStyle3D defaultInnerElecLineStyle3D;   //set, get
			VGEElecLineStyle3D highlightElecLineStyle3D;     //set, get
			VGEPipeLineStyle3D defaultJointPipelineStyle;   //set, get	
			VGEEntityStyle3D highlightEntityStyle3D;           //set, get
			VGEMarkerStyle3D highlightMarkerStyle3D;           //set, get
			VGETextStyle highlightTextStyle;               //set, get

			VGE::DataManager::VGEDataManager dataManager;     //get		

			bool antialiasing;      //set, get
			std::string bkImage;    //set
			float blurEnhance;      //set, get
			float blurWidth;        //set, get
			bool bothFaceRendered;   //set, get
			double buttjointTolerance;   //set, get
			std::string cachePath;     //set, get
			int cacheSize;           //set, get
			int curFlyID;             //set, get
			float decjointValue;      //set, get
			std::string DefaultRelativeDir;   //set, get
			bool editClampObject;        //set, get
			int editHistorySize;            //set, get
			bool editSnapObject;          //set, get
			bool featureMouseOverEnable;    //set, get
			bool featureMouseOverHighLight;    //set, get
			double flyAlongLineRotateSpeed;     //set, get
			double flyAlongLineSpeed;           //set, get
			double flyToPointSpeed;            //set, get
			int groundOpaque;          //set, get
			bool hasSelNode;           //get
			bool isAudioRecorded;          //set, get
			bool isCADPointLoaded;          //set, get
			bool isEditSelectLocked;          //set, get
			bool isReleaseMemOutOfView;          //set, get
			bool isUnderGroundLocked;          //set, get
			bool keyBoradRoamingEnable;          //set, get
			bool marbleVisible;          //set, get
			double maxUserBackgroundAlt;          //set, get
			int minModelVisibleSize;          //set, get
			double minUserBackgroundAlt;          //set, get
			int minVectorVisibleSize;          //set, get
			float modelBlurEnhance;          //set, get
			float modelBlurWidth;          //set, get
			bool modelUseLighting;          //set, get
			bool mouseRoamingEnable;          //set, get
			bool object2DMouseOverEnable;          //set, get
			double onePixelRealLenInNearest;         //get
			double powerLineLinkVisibleDistance;          //set, get
			double powerLineNodeVisibleDistance;          //set, get
			Color sceneAmbient;          //set, get
			int selLevel;          //set, get
			int selObjectCount;        //get
			bool starsVisible;          //set, get
			double terrainExra;          //set, get
			bool terrainUseLighting;          //set, get
			Color userBackgroundColor;          //set, get
			bool userBackgroundColorValid;          //set, get
			double userFarProDist;          //set, get
			double userNearProDist;          //set, get
			bool usingFBO;          //set, get
			bool usingVBO;          //set, get
			std::string videoPath;          //set, get
			int videoRecordInterval;          //set, get
			double viewRange;              //get
			float walkCrossHeight;          //set, get
			float walkEyeHeight;          //set, get
			float walkJumpHeight;          //set, get
		};
	}
}