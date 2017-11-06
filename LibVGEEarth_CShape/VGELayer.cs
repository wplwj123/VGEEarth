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
        /// Layer
        /// </summary>
        abstract class VGELayer
        {
            public VGELayer();
            public ~VGELayer();

            public GeoData.VGEFeature AddFeature(GeoData.VGEFeature feature);
            public void AddFeatures(GeoData.VGEFeatures features);
            public GeoData.VGEFeatures FindFeaturesInPolygon(GeoData.VGEGeoPolygon3D polygon3D, bool bCompletelyContained);
            public GeoData.VGEFeatures GetAllFeatures();
            public GeoData.VGEFeatures GetAllFeatures(bool bContainDeleted);
            public GeoData.VGEFeature GetAt(int nIndex);
            public GeoData.VGEFeature GetFeatureByCustomID(int nID);
            public GeoData.VGEFeatures GetFeatureByDescription(string strDescription, bool bEquel);
            public GeoData.VGEFeatures GetFeatureByFieldValue(string strFieldName, string strVal, bool bEquel);
            public GeoData.VGEFeature GetFeatureByID(int nID);
            public GeoData.VGEFeatures GetFeatureByName(string strName, bool bEquel);
            public GeoData.VGEFeatures GetFeaturesByIDs(int[] arrIDs);
            public bool IsDestLayerFeatureAdd();
            public bool IsSameInnerObject(VGELayer other);
            public GeoData.VGEFeatures Query(string srSQL);
            public bool Reload();
            public void RemoveAllFeature();
            public bool RemoveAt(int nIndex);
            public bool RemoveFeatureByCustomID(int nID);
            public bool RemoveFeatureByID(int nID);
            public bool Save();
            public bool SaveAs(string srFilePath);
            public bool SaveAs(string srFilePath, string strProj, int nProjStrType);

            private GeoData.VGERect2D bounds;    //get
            private GeoData.VGERect2D latlonBounds;   //get
            private DataManager.VGEDataset dataset;       //set, get
            private GeoData.VGEExtrudeStyle extrudeStyle;   //set, get
            private GeoData.VGEStyle highLightStyle;         //set, get
            private GeoData.VGEStyle style;          //set, get
            private Enum.LayerType type;      //get

            private string alias;     //set, get
            private int beginLevel;       //get	
            private string caption;  //set, get
            private bool collidable;      //set, get	
            private bool editable;      //set, get
            private int endLevel;     //get
            private int ID;           //get
            private double maxVisibleAltitude;   //set, get
            private double minVisibleAltitude;   //set, get
            private double objectMaxVisibleDistance;   //set, get
            private double objectMinVisibleDistance;   //set, get
            private double objectMaxVisiblePixelSize;   //set, get
            private double objectMinVisiblePixelSize;   //set, get
            private string name;           //get
            private bool onlyShowMostNearRange;     //set, get
            private double opaque;          //set, get
            private bool selectable;            //set, get
            private int styleID;        //set, get
            private bool visible;    //set, get
        };

        /// <summary>
        /// Memory Layer
        /// Storage Objects during program running
        /// </summary>
        class VGEMemoryLayer : VGELayer { };

        /// <summary>
        /// Image Layer
        /// </summary>
        class VGEImageLayer : VGELayer { };

        /// <summary>
        /// Feature Layer
        /// </summary>
        class VGEFeatureLayer : VGELayer { };

        /// <summary>
        /// PagedLOD Feature Layer
        /// </summary>
        class VGEPageLODFeatureLayer : VGELayer
        {
            public VGEPageLODFeatureLayer();
            public ~VGEPageLODFeatureLayer();

            public int AddFlattenPolygon3D(GeoData.VGEGeoPolygon3D geoPolygon, string tag);
            public void ClearFlattenPolygon3Ds();
            public GeoData.VGEGeoPolygon3D GetFlattenPolygon3D(int index);
            public string GetFlattenPolygon3DTag(int index);
            public int IndexOfFlattenPolygon3D(string tag);
            public bool RemoveFlattenPolygon3D(int index);

            private int flattenPolygon3DCount;    //get
        };

        /// <summary>
        /// Layers
        /// </summary>
        class VGELayers
        {
            public VGELayers();
            public ~VGELayers();

            public VGELayer Add(string strFilePath);
            public VGELayer Add(string strFilePath, string strProj4);
            public VGELayer Add(DataManager.VGEDataset dataset);
            public VGELayer Add(VGELayer layer);
            public VGELayer GetLayerByCaption(string strCaption);
            public VGELayer GetLayerByID(int nID);
            public int GetLayerIndexByID(int nID);
            public void MoveDown(int nCurIndex);
            public void MoveTo(int nFromIndex, int nToIndex);
            public void MoveUp(int nCurIndex);
            public bool Remove(int nIndex);
            public bool Remove(VGELayer layer);
            public bool Remove(string layerName);
            public bool RemoveAll();
            public bool RemoveLayerByID(int nID);

            private int count;    //get
            private List<VGELayer> layers;
        };

        /// <summary>
        /// Terrain Layer
        /// </summary>
        class VGETerrain
        {
            public VGETerrain();
            public ~VGETerrain();

            public bool isSameInnerObject(VGETerrain other);

            private GeoData.VGERect2D bounds;    //get
            private GeoData.VGERect2D latlonBounds;   //get
            private DataManager.VGEDataset dataset;       //set, get
            private string alias;     //set, get
            private int beginLevel;       //get	
            private string caption;  //set, get
            private int endLevel;     //get
            private int ID;           //get
            private string name;           //get
            private bool visible;    //set, get
        };

        /// <summary>
        /// Terrain Layers
        /// </summary>
        class VGETerrains
        {
            public VGETerrains();
            public ~VGETerrains();

            public VGETerrain Add(string strFilePath);
            public VGETerrain Add(DataManager.VGEDataset dataset);
            public VGETerrain Add(VGETerrain terrain);
            public VGETerrain GetTerrainByCaption(string strCaption);
            public VGETerrain GetTerrainByID(int nID);
            public int GetTerrainIndexByID(int nID);
            public void MoveDown(int nCurIndex);
            public void MoveTo(int nFromIndex, int nToIndex);
            public void MoveUp(int nCurIndex);
            public bool Remove(VGETerrain terrain);
            public bool Remove(string layerName);
            public bool Remove(int nIndex);
            public bool RemoveAll();
            public bool RemoveTerrainByID(int nID);

            private int count;    //get
            private List<VGETerrain> terrains;
        };
    }
}
