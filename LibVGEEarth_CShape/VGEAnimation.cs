using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VGEEarth
{
    namespace Animation
    {
        /// <summary>
        /// Animation Object
        /// </summary>
        abstract class VGEAniObject
        {
            public VGEAniObject();
            public ~VGEAniObject();

            public void Copy(VGEAniObject aniobject);

            private Enum.AniObjectType type;   //get
        };

        /// <summary>
        /// Animation Break Point
        /// </summary>
        class VGEAniBreakPoint
        {
            public VGEAniBreakPoint();
            public ~VGEAniBreakPoint();

            private float duration;  //set, get
            private int frame;      //set, get
        };

        /// <summary>
        /// Animation Effect
        /// </summary>
        abstract class VGEAniEffect
        {
            public VGEAniEffect();
            public ~VGEAniEffect();

            public void Copy(VGEAniEffect effect);

            private int frameCount;    //get
            private bool isSmooth;    //set, get
            private string name;  //set, get
            private float repeatCount;  //ser, get
            private Enum.AniEffectType type; //get
        };

        /// <summary>
        /// Animation Key Frame 
        /// </summary>
        class VGEAniKeyFrame
        {
            public VGEAniKeyFrame();
            public ~VGEAniKeyFrame();

            public VGEAniEffect AddEffect(VGEAniEffect effect);
            public VGEAniEffect AddEffectToHead(VGEAniEffect effect);
            public VGEAniEffect AddEffectToTail(VGEAniEffect effect);
            public VGEAniEffect GetEffectAt(int nIndex);
            public int GetEffectCount();
            public VGEAniEffect GetHeadEffect();
            public VGEAniEffect GetTailEffect();
            public VGEAniEffect InsertEffectAt(int nPos, VGEAniEffect effect);
            public void RemoveAllEffects();
            public bool RemoveEffectAt(int nIndex);
            public bool RemoveHeadEffect();
            public bool RemoveTailEffect();

            private int effectCount;    //get
            private int frame;        //set, get
            private Enum.AniKeyFramePosType posType;  //set, get
            private List<VGEAniEffect> aniEffects;
        };

        /// <summary>
        /// Animation Object Time Line
        /// </summary>
        class VGEAniObjTimeLine
        {
            public VGEAniObjTimeLine();
            public ~VGEAniObjTimeLine();
            
            public VGEAniKeyFrame AddKeyFrame(VGEAniKeyFrame keyFrame);
            public VGEAniKeyFrame GetKeyFrameAt(int nIndex);
            public int GetKeyFrameCount();
            public VGEAniKeyFrame GetTailKeyFrame();
            public void RemoveAllKeyFrames();
            public bool RemoveKeyFrameAt(int nIndex);
            public bool RemoveTailKeyFrame();

            private VGEAniObject aniObject;    //set, get
            private bool isActive;            //set, get
            private int keyFrameCount;        //get
            private string name;         //set, get
            private List<VGEAniKeyFrame> aniKeyFrames;
        };

        /// <summary>
        /// Animation Page
        /// </summary>
        class VGEAnimationPage
        {
            public VGEAnimationPage();
            public ~VGEAnimationPage();

            public VGEAniBreakPoint AddBreakPoint(VGEAniBreakPoint aniBreakPoint);
            public VGEAniObjTimeLine AddObjTimeLine(VGEAniObjTimeLine objTimeLine);
            public VGEAniObjTimeLine AddObjTimeLineToHead(VGEAniObjTimeLine objTimeLine);
            public VGEAniObjTimeLine AddObjTimeLineToTail(VGEAniObjTimeLine objTimeLine);
            public VGEAniBreakPoint GetBreakPointAt(int nIndex);
            public VGEAniObjTimeLine GetHeadObjTimeLine();
            public VGEAniObjTimeLine GetObjTimeLineAt(int nIndex);
            public VGEAniBreakPoint GetTailBreakPoint();
            public VGEAniObjTimeLine GetTailObjTimeLine();
            public void Pause();
            public void Play();
            public void RemoveAllBreakPoints();
            public void RemoveAllObjTimeLines();
            public bool RemoveBreakPointAt(int nIndex);
            public bool RemoveHeadObjTimeLine();
            public bool RemoveObjTimeLineAt(int nIndex);
            public bool RemoveTailBreakPoint();
            public bool RemoveTailObjTimeLine();
            public void RePlay();
            public bool Save();
            public bool SaveAs(string strFilePath);
            public void Stop();

            private int breakPointCount;  //get
            private int curFrame;        //set, get
            private float fps;           //set, get
            private int frameCount;      //set, get
            private int ID;               //get
            private bool isActive;         //set, get
            private bool isPlaying;         //get
            private string name;        //set, get
            private int objTimeLineCount;    //get
            private float repeatCount;      //set, get
        };

        /// <summary>
        /// Animation Pages 
        /// </summary>
        class VGEAnimationPages
        {
            public VGEAnimationPages();
            public ~VGEAnimationPages();

            public VGEAnimationPage Add(VGEAnimationPage animationPage);
            public VGEAnimationPage AddAnimationPage(string strFilePath);
            public VGEAnimationPage GetAt(int nIndex);
            public VGEAnimationPage InsertAt(int nPos, VGEAnimationPage animationPage);
            public void MoveDown(int nCurIndex);
            public void MoveTo(int nFromIndex, int nToIndex);
            public void MoveUp(int nCurIndex);
            public void RemoveAll();
            public bool RemoveAt(int nIndex);

            private List<VGEAnimationPage> aniPages;
            private int length; //get
        };
    }
}
