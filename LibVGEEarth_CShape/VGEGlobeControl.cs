using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace VGEEarth
{
    namespace Globe
    {
        /// <summary>
        ///Expose interface, encapsule to Globe Control
        /// </summary>
        public class VGEGlobeControl : System.Windows.Forms.UserControl
        {
            public VGEGlobeControl();
			public ~VGEGlobeControl();

            public bool HasNaviInertia(Enum.WindowNaviType type);
            public void ImmediatelyRefresh();
            public void Refresh();
            public void SetActionCursor(Enum.CursorAction iActionType, int iHotX, int iHotY, string strCursorPath);
            public void SetNaviInertia(Enum.WindowNaviType type, bool bVal);
            public void SetNeedRefresh();
            public void SwapBuffer();

            //System Event
            protected override void OnGotFocus(System.EventArgs e);
            protected override void OnHandleDestroyed(System.EventArgs e);
            protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e);
            protected override void OnKeyUp(System.Windows.Forms.KeyEventArgs e);
            protected override void OnLoad(System.EventArgs e);
            protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e);
            protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e);
            protected override void OnMouseHover(System.EventArgs e);
            protected override void OnMouseLeave(System.EventArgs e);
            protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e);
            protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e);
            protected override void OnMouseWheel(System.Windows.Forms.MouseEventArgs e);
            protected override void OnPaint(System.Windows.Forms.PaintEventArgs e);
            protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e);
            protected override void OnPreviewKeyDown(System.Windows.Forms.PreviewKeyDownEventArgs e);
            protected override void OnSizeChanged(System.EventArgs e);


            //User Event, such as:
            protected void raise_FeatureMouseClickEvent(object value0, EventHandler.FeatureMouseClickEventArgs value1);
            public event EventHandler.FeatureMouseClickEventHandler FeatureMouseClickEvent;
            //and so on....

            /// <summary>
            /// Globe Scene
            /// </summary>
            private VGEGlobe globe;                 //get
            private bool isOnlyActiveRender;          //set, get
            private bool isRotateDirAccordWithNavi;   //set, get
        }
    }

}
