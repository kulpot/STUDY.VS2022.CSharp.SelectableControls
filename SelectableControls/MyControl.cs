using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectableControls
{
    class MyControl : Control
    {
        public MyControl()
        {
            //this.SetStyle(ControlStyles.Selectable, false);
        }

        protected override void OnEnter(EventArgs e)//// you can also use OnGotFocus instead of OnEnter
        {
            base.OnEnter(e);
            this.Invalidate();
        }

        protected override void OnLeave(EventArgs e)/// can also use OnLostFocus instead of OnLeave
        {
            base.OnLeave(e);
            this.Invalidate();
        }

        protected override void OnClick(EventArgs e)//// can also use OnMouseClick instead of OnClick
        {
            base.OnClick(e);
            this.Focus();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

                //(this.ContainsFocus) ---- will be true //(this.Focused)---- will not be true
            if (this.Focused && CanFocus)
                ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }
    }
}
