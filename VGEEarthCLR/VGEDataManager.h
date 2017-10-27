#pragma once

#include <vector>
#include "VGEEnum.h"
#include "VGEGeoData.h"

using namespace VGE::GeoData;

namespace VGE{
	namespace DataManager{

		class VGEDataset{
		public:
			VGEDataset();
			~VGEDataset();

		public:
			void Close();
			std::string ExportProjectionRefToProj4();
			std::string ExportProjectionRefToWkt();
			bool ImportProjectionRefFromESRI(std::string strProParam);
			bool ImportProjectionRefFromProj4(std::string strProParam);
			bool ImportProjectionRefFromWkt(std::string strProParam);
			bool LoadProjectionFromESRIFile(std::string strFilePath);
			bool Open();
			bool Save();
			bool SaveAs(std::string srFilePath);
			bool SaveAs(std::string srFilePath, std::string strProj, int nProjStrType);

		private:
			std::string name;    //set, get
			std::string alias;   //set, get
			std::string caption;   //set, get
			int beginLevel;     //get
			int endLevel;     //get
			bool isCloseSaved;     //set, get
			bool isFeatureDataset;   //get
			bool isOpen;       //get

			GeoData::VGERect2D bounds;  //get
			GeoData::VGERect2D latlonBounds;  //get
			VGEDataSource dataSource;   //get
			EnumGeoReferenceType geoReferenceType;   //get
			EnumDatasetType type;
		};

		class VGEFeatureDataset :public VGEDataset{
		public:
			VGEFeatureDataset();
			~VGEFeatureDataset();

		public:
			void AddFeature(VGEFeature feature);
			void AddFeatures(VGEFeatures features);
			bool AddField(VGEFieldAttr fieldAttr);
			bool AddFields(VGEFieldAttr fieldDefns[]);
			VGEFeature CreateFeature();
			bool DeleteField(std::string strFiledName);
			VGEFeatures FindFeaturesInPolygon(VGEGeoPolygon3D pPolygon3D, bool bCompletelyContained);
			VGEFeatures GetAllFeatures();
			VGEFeatures GetAllFeatures(bool bContainDeleted);
			VGEFeature GetFeatureAt(int nIndex);
			VGEFeatures GetFeatureByDescription(std::string strDescription, bool bEquel);
			VGEFeatures GetFeatureByFieldValue(std::string strFieldName, std::string strFieldValue, bool bEquel);
			VGEFeature GetFeatureByID(int nID);
			VGEFeatures GetFeatureByName(std::string strName, bool bEquel);
			VGEFeatures GetFeaturesByIDs(int arrIDs[]);
			VGEFieldAttr GetField(int nIndex);
			VGEFieldAttr GetField(std::string strName);
			VGEFeatures Query(std::string srSQL);
			bool RemoveFeatureAt(int nIndex);
			bool RemoveFeatureByID(int nID);

		private:
			int fieldCount;    //get
		};

		class VGENetworkDataset	: public VGEDataset{
		public:
			VGENetworkDataset();
			~VGENetworkDataset();

		public:
			bool ClearValves();
			void CloseValveAnalysis(int nLineID, int arryResNodeID[], int arryResValveID[], bool bNetworkEdgeID, bool bCheckCircle);
			bool ConnexityAnalysis(int nLineID1, int nLineID2, int arryResID[], bool bNetworkEdgeID, bool bCheckCircle);
			int GenerateValves(VGEFeatureDataset pPointDataset, double dTolerance, bool bIgnoreZ, bool bMatchNearestNode, double dNearestDistLimit);
			int GenerateValves(VGEFeatureDataset pPointDataset, double dXYTolerance, double dZTolerance, bool bIgnoreZ, bool bMatchNearestNode, double dNearestDistLimit);
			int GenerateValves(VGEFeatureDataset pPointDataset, bool bCompareDist, double dXYTolerance, double dZTolerance, bool bIgnoreZ, bool bMatchNearestNode, double dNearestDistLimit);
			void TraceUpDownAnalysis(int nLineID, int arryResID[], bool bTraceUp, bool bNetworkEdgeID, bool bCheckCircle);

		private:
			VGEFeatureDataset EdgeDataset;    //get
			VGEFeatureDataset NodeDataset;    //get
		};

		class VGEDataSourceCnn{
		public:
			VGEDataSourceCnn();
			~VGEDataSourceCnn();

		public:
			bool FromXML(std::string strXmlFilePath);
			bool ToXML(std::string strXmlFilePath);

		private:
			std::string database;    //set, get
			std::string driver;    //set, get
			std::string password;    //set, get
			std::string port;    //set, get
			std::string server;    //set, get
			std::string user;    //set, get
			bool readOnly;       //set, get
			EnumDataSourceType type;     //set, get
		};

		class VGEDataSource{
		public:
			VGEDataSource();
			~VGEDataSource();

		public:
			void AddDataset(VGEDataset dataset);
			void Close();
			bool Connect();
			VGEFeatureDataset CreateFeatureDataset(std::string strName);
			void DeleteAllDatasets();
			void DeleteDatasetAt(int nIndex);
			void DeleteDatasetByAlias(std::string strAlias);
			void DeleteDatasetByName(std::string strName);
			VGEDataSourceCnn GetConnectionInfo();
			VGEDataset GetDatasetAt(int nIndex);
			VGEDataset GetDatasetByAlias(std::string strAlias);
			VGEDataset GetDatasetByCaption(std::string strCaption);
			VGEDataset GetDatasetByName(std::string strName);
			bool Open();
			void RemoveAllDatasets();
			void RemoveDataset(VGEDataset dataset);
			void RemoveDatasetAt(int nIndex);
			void RemoveDatasetByAlias(std::string strAlias);
			void RemoveDatasetByName(std::string strName);

		private:
			std::string alias;   //set, get
			std::string caption;   //set, get
			int datasetCount;     //get
			bool isCloseSaved;     //set, get
			std::string name;    //set, get
			bool readOnly;        //set, get
			EnumDataSourceType type;   //get
			std::vector<VGEDataset> datasets;
		};

		class VGEDataManager{
		public:
			VGEDataManager();
			~VGEDataManager();

		public:
			void AddDataSource(VGEDataSource dataspace);
			VGEDataset AddFileDataset(std::string strFilePath);
			VGEDataset AddFileDataset(std::string strFilePath, std::string strProj4);
			VGEDataSource CreateDataSource(VGEDataSourceCnn connection);
			VGEDataSource CreateDataSource(std::string strServer, std::string strPort, std::string strDriver, 
				std::string strDataBase, std::string strUser, std::string strPassword, EnumDataSourceType eType);
			VGEDataSource CreateOracleDataSource(std::string strServer, std::string strPort, std::string strDataBase, std::string strUser, std::string strPassword);
			VGEDataSource CreateSqlServerDataSource(std::string strServer, std::string strPort, std::string strDataBase, std::string strUser, std::string strPassword);
			void DeleteAllDataSources();
			void DeleteDataSourceAt(int nIndex);
			void DeleteDataSourceByAlias(std::string strAlias);
			void DeleteDataSourceByName(std::string strName);
			VGEDataSource GetDataSourceAt(int nIndex);
			VGEDataSource GetDataSourceByAlias(std::string strAlias);
			VGEDataSource GetDataSourceByCaption(std::string strCaption);
			VGEDataSource GetDataSourceByName(std::string strName);
			VGEPowerLineTemplate LoadPowerlineTemplate(std::string strTemplatePath);
			VGEDataSource OpenDataSource(VGEDataSourceCnn connection);
			VGEDataSource OpenDataSource(std::string strServer, std::string strPort, std::string strDriver, 
				std::string strDataBase, std::string strUser, std::string strPassword, EnumDataSourceType eType);
			VGEDataSource OpenFileDataSource(std::string strFilePath);
			VGEDataSource OpenOracleDataSource(std::string strServer, std::string strPort, std::string strDataBase, std::string strUser, std::string strPassword);
			VGEDataSource OpenSqlServerDataSource(std::string strServer, std::string strPort, std::string strDataBase, std::string strUser, std::string strPassword);
			VGEFeatures ReadFeatureData(std::string strFilePath);
			void RemoveAllDataSources();
			void RemoveDataSourceAt(int nIndex);
			void RemoveDataSourceByAlias(std::string strAlias);
			void RemoveDataSourceByName(std::string strName);
			bool SaveFeatureData(VGEFeatures features, std::string strFilePath, std::string strProj, int nProStrType);

		private:
			int dataSourceCount;  //get
			std::vector<VGEDataSource> dataSources;
		};

	}
}