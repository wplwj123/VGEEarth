using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace DataManager
    {
        /// <summary>
        /// Dataset
        /// </summary>
        class VGEDataset
        {
            public VGEDataset();
            public ~VGEDataset();

            public void Close();
            public string ExportProjectionRefToProj4();
            public string ExportProjectionRefToWkt();
            public bool ImportProjectionRefFromESRI(string strProParam);
            public bool ImportProjectionRefFromProj4(string strProParam);
            public bool ImportProjectionRefFromWkt(string strProParam);
            public bool LoadProjectionFromESRIFile(string strFilePath);
            public bool Open();
            public bool Save();
            public bool SaveAs(string srFilePath);
            public bool SaveAs(string srFilePath, string strProj, int nProjStrType);

            private string name;    //set, get
            private string alias;   //set, get
            private string caption;   //set, get
            private int beginLevel;     //get
            private int endLevel;     //get
            private bool isCloseSaved;     //set, get
            private bool isFeatureDataset;   //get
            private bool isOpen;       //get

            private GeoData.VGERect2D bounds;  //get
            private GeoData.VGERect2D latlonBounds;  //get
            private VGEDataSource dataSource;   //get
            private Enum.GeoReferenceType geoReferenceType;   //get
            private Enum.DatasetType type;
        };

        /// <summary>
        /// Feature Dataset
        /// </summary>
        class VGEFeatureDataset : VGEDataset
        {
            public VGEFeatureDataset();
            public ~VGEFeatureDataset();

            public void AddFeature(GeoData.VGEFeature feature);
            public void AddFeatures(GeoData.VGEFeatures features);
            public bool AddField(GeoData.VGEFieldAttr fieldAttr);
            public bool AddFields(GeoData.VGEFieldAttr[] fieldDefns);
            public GeoData.VGEFeature CreateFeature();
            public bool DeleteField(string strFiledName);
            public GeoData.VGEFeatures FindFeaturesInPolygon(GeoData.VGEGeoPolygon3D pPolygon3D, bool bCompletelyContained);
            public GeoData.VGEFeatures GetAllFeatures();
            public GeoData.VGEFeatures GetAllFeatures(bool bContainDeleted);
            public GeoData.VGEFeature GetFeatureAt(int nIndex);
            public GeoData.VGEFeatures GetFeatureByDescription(string strDescription, bool bEquel);
            public GeoData.VGEFeatures GetFeatureByFieldValue(string strFieldName, string strFieldValue, bool bEquel);
            public GeoData.VGEFeature GetFeatureByID(int nID);
            public GeoData.VGEFeatures GetFeatureByName(string strName, bool bEquel);
            public GeoData.VGEFeatures GetFeaturesByIDs(int[] arrIDs);
            public GeoData.VGEFieldAttr GetField(int nIndex);
            public GeoData.VGEFieldAttr GetField(string strName);
            public GeoData.VGEFeatures Query(string srSQL);
            public bool RemoveFeatureAt(int nIndex);
            public bool RemoveFeatureByID(int nID);

            private int fieldCount;    //get
        };

        /// <summary>
        /// Network Dataset
        /// </summary>
        class VGENetworkDataset : VGEDataset
        {
            public VGENetworkDataset();
            public ~VGENetworkDataset();

            public bool ClearValves();
            public void CloseValveAnalysis(int nLineID, int[] arryResNodeID, int[] arryResValveID, bool bNetworkEdgeID, bool bCheckCircle);
            public bool ConnexityAnalysis(int nLineID1, int nLineID2, int[] arryResID, bool bNetworkEdgeID, bool bCheckCircle);
            public int GenerateValves(VGEFeatureDataset pPointDataset, double dTolerance, bool bIgnoreZ, bool bMatchNearestNode, double dNearestDistLimit);
            public int GenerateValves(VGEFeatureDataset pPointDataset, double dXYTolerance, double dZTolerance, bool bIgnoreZ, bool bMatchNearestNode, double dNearestDistLimit);
            public int GenerateValves(VGEFeatureDataset pPointDataset, bool bCompareDist, double dXYTolerance, double dZTolerance, bool bIgnoreZ, bool bMatchNearestNode, double dNearestDistLimit);
            public void TraceUpDownAnalysis(int nLineID, int[] arryResID, bool bTraceUp, bool bNetworkEdgeID, bool bCheckCircle);

            private VGEFeatureDataset EdgeDataset;    //get
            private VGEFeatureDataset NodeDataset;    //get
        };

        /// <summary>
        /// Data Source Connect
        /// </summary>
        class VGEDataSourceCnn
        {
            public VGEDataSourceCnn();
            public ~VGEDataSourceCnn();

            public bool FromXML(string strXmlFilePath);
            public bool ToXML(string strXmlFilePath);

            private string database;    //set, get
            private string driver;    //set, get
            private string password;    //set, get
            private string port;    //set, get
            private string server;    //set, get
            private string user;    //set, get
            private bool readOnly;       //set, get
            private Enum.DataSourceType type;     //set, get
        };

        /// <summary>
        /// Data Source
        /// </summary>
        class VGEDataSource
        {
            public VGEDataSource();
            public ~VGEDataSource();

            public void AddDataset(VGEDataset dataset);
            public void Close();
            public bool Connect();
            public VGEFeatureDataset CreateFeatureDataset(string strName);
            public void DeleteAllDatasets();
            public void DeleteDatasetAt(int nIndex);
            public void DeleteDatasetByAlias(string strAlias);
            public void DeleteDatasetByName(string strName);
            public VGEDataSourceCnn GetConnectionInfo();
            public VGEDataset GetDatasetAt(int nIndex);
            public VGEDataset GetDatasetByAlias(string strAlias);
            public VGEDataset GetDatasetByCaption(string strCaption);
            public VGEDataset GetDatasetByName(string strName);
            public bool Open();
            public void RemoveAllDatasets();
            public void RemoveDataset(VGEDataset dataset);
            public void RemoveDatasetAt(int nIndex);
            public void RemoveDatasetByAlias(string strAlias);
            public void RemoveDatasetByName(string strName);

            private string alias;   //set, get
            private string caption;   //set, get
            private int datasetCount;     //get
            private bool isCloseSaved;     //set, get
            private string name;    //set, get
            private bool readOnly;        //set, get
            private Enum.DataSourceType type;   //get
            private List<VGEDataset> datasets;
        };

        /// <summary>
        /// Data Manager
        /// </summary>
        class VGEDataManager
        {
            public VGEDataManager();
            public ~VGEDataManager();

            public void AddDataSource(VGEDataSource dataspace);
            public VGEDataset AddFileDataset(string strFilePath);
            public VGEDataset AddFileDataset(string strFilePath, string strProj4);
            public VGEDataSource CreateDataSource(VGEDataSourceCnn connection);
            public VGEDataSource CreateDataSource(string strServer, string strPort, string strDriver,
                string strDataBase, string strUser, string strPassword, Enum.DataSourceType eType);
            public VGEDataSource CreateOracleDataSource(string strServer, string strPort, string strDataBase, string strUser, string strPassword);
            public VGEDataSource CreateSqlServerDataSource(string strServer, string strPort, string strDataBase, string strUser, string strPassword);
            public void DeleteAllDataSources();
            public void DeleteDataSourceAt(int nIndex);
            public void DeleteDataSourceByAlias(string strAlias);
            public void DeleteDataSourceByName(string strName);
            public VGEDataSource GetDataSourceAt(int nIndex);
            public VGEDataSource GetDataSourceByAlias(string strAlias);
            public VGEDataSource GetDataSourceByCaption(string strCaption);
            public VGEDataSource GetDataSourceByName(string strName);
            public GeoData.VGEPowerLineTemplate LoadPowerlineTemplate(string strTemplatePath);
            public VGEDataSource OpenDataSource(VGEDataSourceCnn connection);
            public VGEDataSource OpenDataSource(string strServer, string strPort, string strDriver,
                string strDataBase, string strUser, string strPassword, Enum.DataSourceType eType);
            public VGEDataSource OpenFileDataSource(string strFilePath);
            public VGEDataSource OpenOracleDataSource(string strServer, string strPort, string strDataBase, string strUser, string strPassword);
            public VGEDataSource OpenSqlServerDataSource(string strServer, string strPort, string strDataBase, string strUser, string strPassword);
            public GeoData.VGEFeatures ReadFeatureData(string strFilePath);
            public void RemoveAllDataSources();
            public void RemoveDataSourceAt(int nIndex);
            public void RemoveDataSourceByAlias(string strAlias);
            public void RemoveDataSourceByName(string strName);
            public bool SaveFeatureData(GeoData.VGEFeatures features, string strFilePath, string strProj, int nProStrType);

            private int dataSourceCount;  //get
            private List<VGEDataSource> dataSources;
        };
    }
}
