#pragma once

#include "VGEEnum.h"
#include <vector>

namespace VGE{
	namespace Globe{

		class VGEAniObject{
		public:
			VGEAniObject();
			~VGEAniObject();

		public:
			void Copy(VGEAniObject aniobject);

		private:
			EnumAniObjectType type;   //get
		};

		class VGEAniBreakPoint{
		public:
			VGEAniBreakPoint();
			~VGEAniBreakPoint();

		private:
			float duration;  //set, get
			int frame;      //set, get
		};

		class VGEAniEffect
		{
		public:
			VGEAniEffect();
			~VGEAniEffect();

		public:
			void Copy(VGEAniEffect effect);

		private:
			int frameCount;    //get
			bool isSmooth;    //set, get
			std::string name;  //set, get
			float repeatCount;  //ser, get
			EnumAniEffectType type; //get
		};

		class VGEAniKeyFrame
		{
		public:
			VGEAniKeyFrame();
			~VGEAniKeyFrame();

		public:
			VGEAniEffect AddEffect(VGEAniEffect effect);
			VGEAniEffect AddEffectToHead(VGEAniEffect effect);
			VGEAniEffect AddEffectToTail(VGEAniEffect effect);
			VGEAniEffect GetEffectAt(int nIndex);
			int GetEffectCount();
			VGEAniEffect GetHeadEffect();
			VGEAniEffect GetTailEffect();
			VGEAniEffect InsertEffectAt(int nPos, VGEAniEffect effect);
			void RemoveAllEffects();
			bool RemoveEffectAt(int nIndex);
			bool RemoveHeadEffect();
			bool RemoveTailEffect();

		private:
			int effectCount;    //get
			int frame;        //set, get
			EnumAniKeyFramePosType posType;  //set, get
			std::vector<VGEAniEffect> aniEffects;
		};

		class VGEAniObjTimeLine{
		public:
			VGEAniObjTimeLine();
			~VGEAniObjTimeLine();

		public:
			VGEAniKeyFrame AddKeyFrame(VGEAniKeyFrame keyFrame);
			VGEAniKeyFrame GetKeyFrameAt(int nIndex);
			int GetKeyFrameCount();
			VGEAniKeyFrame GetTailKeyFrame();
			void RemoveAllKeyFrames();
			bool RemoveKeyFrameAt(int nIndex);
			bool RemoveTailKeyFrame();

		private:
			VGEAniObject aniObject;    //set, get
			bool isActive;            //set, get
			int keyFrameCount;        //get
			std::string name;         //set, get
			std::vector<VGEAniKeyFrame> aniKeyFrames;
		};

		class VGEAnimationPage{
		public:
			VGEAnimationPage();
			VGEAnimationPage();

		public:
			VGEAniBreakPoint AddBreakPoint(VGEAniBreakPoint aniBreakPoint);
			VGEAniObjTimeLine AddObjTimeLine(VGEAniObjTimeLine objTimeLine);
			VGEAniObjTimeLine AddObjTimeLineToHead(VGEAniObjTimeLine objTimeLine);
			VGEAniObjTimeLine AddObjTimeLineToTail(VGEAniObjTimeLine objTimeLine);
			VGEAniBreakPoint GetBreakPointAt(int nIndex);
			VGEAniObjTimeLine GetHeadObjTimeLine();
			VGEAniObjTimeLine GetObjTimeLineAt(int nIndex);
			VGEAniBreakPoint GetTailBreakPoint();
			VGEAniObjTimeLine GetTailObjTimeLine();
			void Pause();
			void Play();
			void RemoveAllBreakPoints();
			void RemoveAllObjTimeLines();
			bool RemoveBreakPointAt(int nIndex);
			bool RemoveHeadObjTimeLine();
			bool RemoveObjTimeLineAt(int nIndex);
			bool RemoveTailBreakPoint();
			bool RemoveTailObjTimeLine();
			void RePlay();
			bool Save();
			bool SaveAs(std::string strFilePath);
			void Stop();

		private:
			int breakPointCount;  //get
			int curFrame;        //set, get
			float fps;           //set, get
			int frameCount;      //set, get
			int ID;               //get
			bool isActive;         //set, get
			bool isPlaying;         //get
			std::string name;        //set, get
			int objTimeLineCount;    //get
			float repeatCount;      //set, get
		};

		class VGEAnimationPages{
		public:
			VGEAnimationPages();
			VGEAnimationPages();

		public:
			VGEAnimationPage Add(VGEAnimationPage animationPage);
			VGEAnimationPage AddAnimationPage(std::string strFilePath);
			VGEAnimationPage GetAt(int nIndex);
			VGEAnimationPage InsertAt(int nPos, VGEAnimationPage animationPage);
			void MoveDown(int nCurIndex);
			void MoveTo(int nFromIndex, int nToIndex);
			void MoveUp(int nCurIndex);
			void RemoveAll();
			bool RemoveAt(int nIndex);

		private:
			std::vector<VGEAnimationPage> aniPages;
			int length; //get
		};
	}
}