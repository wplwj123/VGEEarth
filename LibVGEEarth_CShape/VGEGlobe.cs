using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace Globe
    {
        /// <summary>
        /// Globe Scene Class
        /// </summary>
        public class VGEGlobe
        {
            public VGEGlobe();
            public ~VGEGlobe();

            /// <summary>
            /// add feature to selected features
            /// </summary>
            /// <param name="feature">selected feature</param>
            /// <param name="bAllowEdit">whether allow edit</param>
            public void AddFeatureToSelection(GeoData.VGEFeature feature, bool bAllowEdit);

            /// <summary>
            /// get select object
            /// </summary>
            /// <param name="nIndex">object index</param>
            /// <param name="resFeature">result feature</param>
            /// <param name="resLayer">result layer</param>
            public void GetSelectObject(int nIndex, out GeoData.VGEFeature resFeature, out VGELayer resLayer);

            /// <summary>
            /// clear selection
            /// </summary>
            public void ClearSelection();

            /// <summary>
            /// add HUD control to GlobeControl(HUD is a button on the GlobeControl)
            /// </summary>
            /// <param name="control">HUD control</param>
            public void AddHudControl(Control.VGEHudControl control);

            /// <summary>
            /// get HUD control by name 
            /// </summary>
            /// <param name="name">HUD name</param>
            /// <returns></returns>
            public Control.VGEHudControl GetHudControlByName(string name);

            /// <summary>
            /// add to edit history when feature is be edited
            /// </summary>
            /// <param name="layer">layer that featrue belonged</param>
            /// <param name="feature">feature</param>
            /// <param name="eType">edit type</param>
            /// <returns></returns>
            public bool AddToEditHistroy(VGELayer layer, GeoData.VGEFeature feature, Enum.EditType eType);

            /// <summary>
            /// add to edit history when feature is be edited
            /// </summary>
            /// <param name="layer">layer that featrue belonged</param>
            /// <param name="feature">feature</param>
            /// <param name="oldFeature">feature before edited</param>
            /// <param name="eType">edit type</param>
            /// <returns></returns>
            public bool AddToEditHistroy(VGELayer layer, GeoData.VGEFeature feature, GeoData.VGEFeature oldFeature, Enum.EditType eType);

            /// <summary>
            /// undo edit
            /// </summary>
            public void UnDoEdit();

            /// <summary>
            /// redo edit
            /// </summary>
            public void ReDoEdit();

            /// <summary>
            /// add pit
            /// </summary>
            /// <param name="strName">pit name</param>
            /// <param name="geoPit">pit</param>
            /// <returns>index of this pit</returns>
            public int AddPit(string strName, GeoData.VGEGeoPit geoPit);

            /// <summary>
            /// get pit by id
            /// </summary>
            /// <param name="nID"></param>
            /// <returns></returns>
            public GeoData.VGEGeoPit GetPitByID(int nID);

            /// <summary>
            /// get pit by name
            /// </summary>
            /// <param name="strName"></param>
            /// <returns></returns>
            public GeoData.VGEGeoPit GetPitByName(string strName);

            /// <summary>
            /// remove all pits
            /// </summary>
            public void RemoveAllPits();

            /// <summary>
            /// remove last pit
            /// </summary>
            public void RemoveLastPit();

            /// <summary>
            /// remove pit by pit ID
            /// </summary>
            /// <param name="nID">pit ID</param>
            public void RemovePitByID(int nID);

            /// <summary>
            /// remove pit by pit name
            /// </summary>
            /// <param name="strName">pit name</param>
            public void RemovePitByName(string strName);

            /// <summary>
            /// buttjion pipeline database
            /// </summary>
            /// <param name="dataset">pipeline database</param>
            public void ButtjointPipelineDataset(DataManager.VGEDataset dataset);

            /// <summary>
            /// buttjion pipeline database
            /// </summary>
            /// <param name="dataset">pipeline database</param>
            /// <param name="bIgnoreZ">whether ignore Z</param>
            /// <param name="dTolerance">Tolerance</param>
            public void ButtjointPipelineDataset(DataManager.VGEDataset dataset, bool bIgnoreZ, double dTolerance);

            /// <summary>
            /// cancel pipeline dataset joint
            /// </summary>
            /// <param name="dataset">pipeline dataset</param>
            /// <param name="bCancelHeadJoint">whether cancel head joint</param>
            /// <param name="bCanchelTailJoint">whether cancel tail joint</param>
            public void CancelPipelineDatasetJoint(DataManager.VGEDataset dataset, bool bCancelHeadJoint, bool bCanchelTailJoint);

            /// <summary>
            /// buttjoint selected pipeline
            /// </summary>
            public void ButtjointSelPipeline();

            /// <summary>
            /// buttjoint selected pipeline
            /// </summary>
            /// <param name="bIgnoreZ">whether ignore Z</param>
            /// <param name="dTolerance">Tolerance</param>
            public void ButtjointSelPipeline(bool bIgnoreZ, double dTolerance);

            /// <summary>
            /// buttjoint selected pipeline with intersect
            /// </summary>
            public void ButtjointSelPipelineWithIntersect();

            /// <summary>
            /// insert joint pipeline
            /// </summary>
            /// <param name="bAddToDestLayer"></param>
            /// <returns></returns>
            public GeoData.VGEFeature InsertJointPipeline(bool bAddToDestLayer);

            /// <summary>
            /// insert joint pipeline
            /// </summary>
            /// <param name="resultStyle"></param>
            /// <returns></returns>
            public GeoData.VGEGeoPolyline3D InsertJointPipeline1(GeoData.VGEPipeLineStyle3D resultStyle);

            /// <summary>
            /// cancel selected pipeline
            /// </summary>
            /// <param name="bCancelHeadJoint">whether cancel head joint</param>
            /// <param name="bCanchelTailJoint">whether cancel tail joint</param>
            public void CancelSelPipelineJoint(bool bCancelHeadJoint, bool bCanchelTailJoint);

            /// <summary>
            /// 
            /// </summary>
            /// <param name="dDecHead"></param>
            /// <param name="dDecTail"></param>
            public void DecjointSelPipeline(double dDecHead, double dDecTail);


            /// <summary>
            /// continue fly
            /// </summary>
            public void ContinueFly();

            /// <summary>
            /// flay along with line
            /// </summary>
            /// <param name="geoLine"></param>
            /// <param name="dHeightAboveLine"></param>
            /// <param name="dHeading"></param>
            /// <param name="dTilt"></param>
            public void FlyAlongWithLine(GeoData.VGEGeoPolyline3D geoLine, double dHeightAboveLine, double dHeading, double dTilt);

            /// <summary>
            /// fly around center
            /// </summary>
            public void FlyAroundCenter();

            /// <summary>
            /// fly around center
            /// </summary>
            /// <param name="dRepeatValue"></param>
            /// <param name="enValueType"></param>
            public void FlyAroundCenter(double dRepeatValue, Enum.FlyRepeatValueType enValueType);
           
            /// <summary>
            /// fly around eye
            /// </summary>
            public void FlyAroundEye();

            /// <summary>
            /// fly around eye
            /// </summary>
            /// <param name="dRepeatValue"></param>
            /// <param name="enValueType"></param>
            public void FlyAroundEye(double dRepeatValue, Enum.FlyRepeatValueType enValueType);
            
            /// <summary>
            /// fly around feature
            /// </summary>
            /// <param name="feature"></param>
            /// <param name="bAlwaysFly"></param>
            /// <param name="dRepeatValue"></param>
            /// <param name="enValueType"></param>
            public void FlyAroundFeature(GeoData.VGEFeature feature, bool bAlwaysFly, double dRepeatValue, Enum.FlyRepeatValueType enValueType);

            /// <summary>
            /// fly around geomerty
            /// </summary>
            /// <param name="geometry"></param>
            /// <param name="bAlwaysFly"></param>
            /// <param name="dRepeatValue"></param>
            /// <param name="enValueType"></param>
            public void FlyAroundGeometry(GeoData.VGEGeometry geometry, bool bAlwaysFly, double dRepeatValue, Enum.FlyRepeatValueType enValueType);

            /// <summary>
            /// fly around position
            /// </summary>
            /// <param name="position"></param>
            /// <param name="bAlwaysFly"></param>
            /// <param name="dRepeatValue"></param>
            /// <param name="enValueType"></param>
            public void FlyAroundPosition(GeoData.VGEPoint3D position, bool bAlwaysFly, double dRepeatValue, Enum.FlyRepeatValueType enValueType);

            /// <summary>
            /// fly eye along with line
            /// </summary>
            /// <param name="geoLine"></param>
            public void FlyEyeAlongWithLine(GeoData.VGEGeoPolyline3D geoLine);

            /// <summary>
            /// fly eye along with line
            /// </summary>
            /// <param name="geoLine"></param>
            /// <param name="altMode"></param>
            /// <param name="dHeightAboveLine"></param>
            /// <param name="dTilt"></param>
            /// <param name="bUseParamTilt"></param>
            /// <param name="dHeading"></param>
            /// <param name="bUseParamHeading"></param>
            public void FlyEyeAlongWithLine(GeoData.VGEGeoPolyline3D geoLine, Enum.AltitudeMode altMode, double dHeightAboveLine, double dTilt, bool bUseParamTilt, double dHeading, bool bUseParamHeading);

            /// <summary>
            /// fly eye along with line
            /// </summary>
            /// <param name="geoLine"></param>
            /// <param name="dHeightAboveLine"></param>
            /// <param name="dTilt"></param>
            /// <param name="bUseParamTilt"></param>
            /// <param name="dHeading"></param>
            /// <param name="bUseParamHeading"></param>
            public void FlyEyeAlongWithLine(GeoData.VGEGeoPolyline3D geoLine, double dHeightAboveLine, double dTilt, bool bUseParamTilt, double dHeading, bool bUseParamHeading);
           
            /// <summary>
            /// fly to camrea state
            /// </summary>
            /// <param name="cameraState"></param>
            public void FlyToCameraState(VGECameraState cameraState);

            /// <summary>
            /// fly to feature
            /// </summary>
            /// <param name="feature"></param>
            public void FlyToFeature(GeoData.VGEFeature feature);

            /// <summary>
            /// fly to feature
            /// </summary>
            /// <param name="feature"></param>
            /// <param name="dHeading"></param>
            /// <param name="dTilt"></param>
            /// <param name="dDistance"></param>
            public void FlyToFeature(GeoData.VGEFeature feature, double dHeading, double dTilt, double dDistance);
            
            /// <summary>
            /// fly to geometry
            /// </summary>
            /// <param name="geometry"></param>
            public void FlyToGeometry(GeoData.VGEGeometry geometry);

            /// <summary>
            /// fly to geometry
            /// </summary>
            /// <param name="geometry"></param>
            /// <param name="dHeading"></param>
            /// <param name="dTilt"></param>
            /// <param name="dDistance"></param>
            public void FlyToGeometry(GeoData.VGEGeometry geometry, double dHeading, double dTilt, double dDistance);
            
            /// <summary>
            /// fly to position
            /// </summary>
            /// <param name="position"></param>
            /// <param name="altMode"></param>
            public void FlyToPosition(GeoData.VGEPoint3D position, Enum.AltitudeMode altMode);

            /// <summary>
            /// fly to position
            /// </summary>
            /// <param name="position"></param>
            /// <param name="altMode"></param>
            /// <param name="dHeading"></param>
            /// <param name="dTilt"></param>
            /// <param name="dDistance"></param>
            public void FlyToPosition(GeoData.VGEPoint3D position, Enum.AltitudeMode altMode, double dHeading, double dTilt, double dDistance);
            
            /// <summary>
            /// stop fly
            /// </summary>
            public void StopFly();

            /// <summary>
            /// pause fly
            /// </summary>
            public void PauseFly();

            /// <summary>
            /// clear last track polygon
            /// </summary>
            public void ClearLastTrackPolygon();

            /// <summary>
            /// clear last track polyline
            /// </summary>
            public void ClearLastTrackPolyline();

            /// <summary>
            /// calculate distance of two point
            /// </summary>
            /// <param name="pnt1"></param>
            /// <param name="pnt2"></param>
            /// <returns></returns>
            public double Get2PointDist(GeoData.VGEPoint3D pnt1, GeoData.VGEPoint3D pnt2);

            /// <summary>
            /// calculate eula distance of two point
            /// </summary>
            /// <param name="pnt1"></param>
            /// <param name="pnt2"></param>
            /// <returns></returns>
            public double Get2PointEulaDist(GeoData.VGEPoint3D pnt1, GeoData.VGEPoint3D pnt2);

            /// <summary>
            /// get height of geographic coordinate point
            /// </summary>
            /// <param name="lon"></param>
            /// <param name="lat"></param>
            /// <returns></returns>
            public double GetZ(double lon, double lat);

            /// <summary>
            /// get feature corresponding the sceen point(x,y)
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="isIgnore2DObject"></param>
            /// <param name="isIgnoreLayerSelectable"></param>
            /// <returns></returns>
            public GeoData.VGEFeature HitTest(int x, int y, bool isIgnore2DObject, bool isIgnoreLayerSelectable);

            /// <summary>
            /// get feature corresponding the sceen point(x,y)
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <param name="resLayer"></param>
            /// <param name="geoPoint"></param>
            /// <param name="isIgnore2DObject"></param>
            /// <param name="isIgnoreLayerSelectable"></param>
            /// <param name="nSelLevel"></param>
            /// <returns></returns>
            public GeoData.VGEFeature HitTest(int x, int y, out VGELayer resLayer, out GeoData.VGEPoint3D geoPoint, bool isIgnore2DObject, bool isIgnoreLayerSelectable, int nSelLevel);

            /// <summary>
            /// refresh analysis
            /// </summary>
            public void RefreshAnalysis();

            /// <summary>
            /// clear analysis
            /// </summary>
            public void ClearAnalysis();

            /// <summary>
            /// clear measure
            /// </summary>
            public void ClearMeasure();

            /// <summary>
            /// whether camera state is been changed
            /// </summary>
            /// <returns></returns>
            public bool IsCameraChanged();

            /// <summary>
            /// view jump to camera lookat
            /// </summary>
            /// <param name="cameraLookAt"></param>
            public void JumpTo(VGECameraLookAt cameraLookAt);

            /// <summary>
            /// view jump to camera state
            /// </summary>
            /// <param name="cameraState"></param>
            public void JumpToCameraState(VGECameraState cameraState);

            /// <summary>
            /// view jump to feature
            /// </summary>
            /// <param name="feature"></param>
            /// <param name="dDistance"></param>
            public void JumpToFeature(GeoData.VGEFeature feature, double dDistance);

            /// <summary>
            /// view jump to geometry
            /// </summary>
            /// <param name="geometry"></param>
            /// <param name="dDistance"></param>
            public void JumpToGeometry(GeoData.VGEGeometry geometry, double dDistance);

            /// <summary>
            /// view jump to position
            /// </summary>
            /// <param name="position"></param>
            /// <param name="altMode"></param>
            /// <param name="dDistance"></param>
            public void JumpToPosition(GeoData.VGEPoint3D position, Enum.AltitudeMode altMode, double dDistance);

            /// <summary>
            /// whether is in recording video
            /// </summary>
            /// <returns></returns>
            public bool IsVideoRecording();

            /// <summary>
            /// start record viedo
            /// </summary>
            public void StartRecordVideo();

            /// <summary>
            /// stop record video
            /// </summary>
            public void StopRecordVideo();

            /// <summary>
            /// paser record video
            /// </summary>
            public void PaseRecordVideo();

            /// <summary>
            /// resume record viedo
            /// </summary>
            public void ResumeRecordVideo();

            /// <summary>
            /// output high picture
            /// </summary>
            /// <param name="dWidthPix">width pixel</param>
            /// <param name="dHightPix">height pixel</param>
            /// <param name="strFilePath">picture path</param>
            /// <returns></returns>
            public bool OutputHighPic(float dWidthPix, float dHightPix, string strFilePath);

            /// <summary>
            /// open project
            /// </summary>
            /// <param name="strPath">project name</param>
            /// <returns></returns>
            public bool OpenWorkSpace(string strPath);

            /// <summary>
            /// save as project
            /// </summary>
            /// <param name="strPath">project name</param>
            public void SaveAsWorkSpace(string strPath);

            /// <summary>
            /// connect server
            /// </summary>
            /// <param name="strIP">IP address</param>
            /// <param name="nPort">Port</param>
            /// <param name="strUser">User Name</param>
            /// <param name="strPsw">PassWord</param>
            /// <returns></returns>
            public bool ConnectServer(string strIP, int nPort, string strUser, string strPsw);

            /// <summary>
            /// connect server
            /// </summary>
            /// <param name="strIP">IP address</param>
            /// <param name="nPort">Port</param>
            /// <param name="strUser">User Name</param>
            /// <param name="strPsw">PassWord</param>
            /// <returns></returns>
            public int ConnectServer2(string strIP, int nPort, string strUser, string strPsw);

            /// <summary>
            /// transformat scene point to screen point
            /// </summary>
            /// <param name="pnt">scene opint</param>
            /// <returns></returns>
            public GeoData.VGEPoint2D SceneToScreen(GeoData.VGEPoint3D pnt);

            /// <summary>
            /// transformat screen point to scene point
            /// </summary>
            /// <param name="x">x pixel</param>
            /// <param name="y">y pixel</param>
            /// <returns>scene point</returns>
            public GeoData.VGEPoint3D ScreenToScene(int x, int y);

            /// <summary>
            /// refresh scene
            /// </summary>
            public void Refresh();

            /// <summary>
            /// sceen full extent 
            /// </summary>
            public void FullExtent();

            /// <summary>
            /// set current antion, include draw and change feature, analysis, measure...
            /// </summary>
            private Enum.Action3D action;   //set, get   
            private Enum.RenderDetail ModelRenderDetail;          //set, get

            //camera relevant
            private Enum.CameraMode cameraMode;   //set, get
            private VGECameraLookAt cameraLookAt;  //set, get
            private VGECameraState cameraState;    //set, get
            private GeoData.VGERect2D viewBounds;            //get

            //Environment Effect
            private VGEAtmosphere Atmosphere;  //get
            private VGEClouds clouds;            //get
            private VGEOcean ocean;        //get
            private VGERain rain;           //get
            private VGELight sceneLight;     //get
            private VGESkyBox skyBox;          //get
            private VGESnow snow;             //get
            private VGESun sun;           //get
            private VGEUnderGroundFloor UnderGroundFloor;  //get

            //Control within Globe Control
            private Control.VGEControlPanel controlPanel;   //get
            private Control.VGEHudControl overviewControl;   //get
            private Control.VGEHudControl scalerControl;      //get
            private Control.VGEStatusBar statusBar;           //get

            //Layers
            private VGELayers layers;                 //get
            private VGETerrains Terrains;             //get
            private VGELayer destLayerFeatureAdd;               //set, get
            private VGELatLonGrid latlonGrid;        //get	
            private VGEMemoryLayer memoryLayer;       //get
            private VGELayer selectedObjectLayer;      //get

            //seleted object
            private GeoData.VGEFeature selectedObject;        //get
            private GeoData.VGEPoint3D selNodePos;          //get

            //animation
            private Animation.VGEAnimationPages animationPages;  //get

            //analysis
            private Analysis.VGE3DAnalysis analysis3D;  //get
            private Analysis.VGEViewEnvelopeAnalysis viewEnvelopeAnalysis;   //get
            private Analysis.VGEViewshedAnalysis ViewshedAnalysis;     //get
            private Analysis.VGEViewshed3DAnalysis Viewshed3DAnalysis;     //get
            private Analysis.VGETrackPolygonTool trackPolygonTool;  //get
            private Analysis.VGETrackPolylineTool trackPolylineTool;  //get
            private Analysis.VGETrackRectTool trackRectTool;  //get

            //measure
            private Measure.VGEAreaRuler areaRuler;  //get
            private Measure.VGEDistanceRuler distanceRuler;        //get
            private Measure.VGEHeightRuler heightRuler;           //get

            //feature style
            private GeoData.VGEElecLineStyle3D defaultElecLineStyle3D;   //set, get
            private GeoData.VGEElecLineStyle3D defaultInnerElecLineStyle3D;   //set, get
            private GeoData.VGEElecLineStyle3D highlightElecLineStyle3D;     //set, get
            private GeoData.VGEPipeLineStyle3D defaultJointPipelineStyle;   //set, get	
            private GeoData.VGEEntityStyle3D highlightEntityStyle3D;           //set, get
            private GeoData.VGEMarkerStyle3D highlightMarkerStyle3D;           //set, get
            private GeoData.VGETextStyle highlightTextStyle;               //set, get

            //data manager
            private DataManager.VGEDataManager dataManager;     //get		

            //Other settings
            private bool antialiasing;      //set, get
            private string bkImage;    //set
            private float blurEnhance;      //set, get
            private float blurWidth;        //set, get
            private bool bothFaceRendered;   //set, get
            private double buttjointTolerance;   //set, get
            private string cachePath;     //set, get
            private int cacheSize;           //set, get
            private int curFlyID;             //set, get
            private float decjointValue;      //set, get
            private string DefaultRelativeDir;   //set, get
            private bool editClampObject;        //set, get
            private int editHistorySize;            //set, get
            private bool editSnapObject;          //set, get
            private bool featureMouseOverEnable;    //set, get
            private bool featureMouseOverHighLight;    //set, get
            private double flyAlongLineRotateSpeed;     //set, get
            private double flyAlongLineSpeed;           //set, get
            private double flyToPointSpeed;            //set, get
            private int groundOpaque;          //set, get
            private bool hasSelNode;           //get
            private bool isAudioRecorded;          //set, get
            private bool isCADPointLoaded;          //set, get
            private bool isEditSelectLocked;          //set, get
            private bool isReleaseMemOutOfView;          //set, get
            private bool isUnderGroundLocked;          //set, get
            private bool keyBoradRoamingEnable;          //set, get
            private bool marbleVisible;          //set, get
            private double maxUserBackgroundAlt;          //set, get
            private int minModelVisibleSize;          //set, get
            private double minUserBackgroundAlt;          //set, get
            private int minVectorVisibleSize;          //set, get
            private float modelBlurEnhance;          //set, get
            private float modelBlurWidth;          //set, get
            private bool modelUseLighting;          //set, get
            private bool mouseRoamingEnable;          //set, get
            private bool object2DMouseOverEnable;          //set, get
            private double onePixelRealLenInNearest;         //get
            private double powerLineLinkVisibleDistance;          //set, get
            private double powerLineNodeVisibleDistance;          //set, get
            private GeoData.Color sceneAmbient;          //set, get
            private int selLevel;          //set, get
            private int selObjectCount;        //get
            private bool starsVisible;          //set, get
            private double terrainExra;          //set, get
            private bool terrainUseLighting;          //set, get
            private GeoData.Color userBackgroundColor;          //set, get
            private bool userBackgroundColorValid;          //set, get
            private double userFarProDist;          //set, get
            private double userNearProDist;          //set, get
            private bool usingFBO;          //set, get
            private bool usingVBO;          //set, get
            private string videoPath;          //set, get
            private int videoRecordInterval;          //set, get
            private double viewRange;              //get
            private float walkCrossHeight;          //set, get
            private float walkEyeHeight;          //set, get
            private float walkJumpHeight;          //set, get
        }
    }
}
