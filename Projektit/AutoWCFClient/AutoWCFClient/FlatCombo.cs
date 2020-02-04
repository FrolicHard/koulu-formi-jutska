
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AutoWCFClient
{
    public class FlatCombo : ComboBox
    {

        private Brush BorderBrush = new SolidBrush(Color.FromArgb(255, 40, 40, 80));
        private Brush ArrowBrush = new SolidBrush(Color.FromArgb(255, 20, 30, 50));
        private Brush DropButtonBrush = new SolidBrush(SystemColors.ControlText);
        
        private Color _ButtonColor = Color.FromArgb(255,20,30,50);
        public Color ButtonColor
        {
            get { return _ButtonColor; }
            set
            {
                _ButtonColor = value;
                DropButtonBrush = new SolidBrush(this.ButtonColor);
                this.Invalidate();
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case 0xf:
                    //Paint the background. Only the borders
                    //will show up because the edit
                    //box will be overlayed
                    Graphics g = this.CreateGraphics();
                    Pen p = new Pen(Color.Snow, 1);
                    g.FillRectangle(BorderBrush, this.ClientRectangle);

                    //Draw the background of the dropdown button
                    Rectangle rect = new Rectangle(this.Width - 15, 3, 12, this.Height - 6);
                    g.FillRectangle(DropButtonBrush, rect);

                    //Create the path for the arrow
                    GraphicsPath pth = new GraphicsPath();
                    PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
                    PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
                    PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
                    pth.AddLine(TopLeft, TopRight);
                    pth.AddLine(TopRight, Bottom);

                    g.SmoothingMode = SmoothingMode.HighQuality;

                    //Determine the arrow's color.
                    if (this.DroppedDown)
                    {
                        ArrowBrush = new SolidBrush(SystemColors.HighlightText);
                    }
                    else
                    {
                        ArrowBrush = new SolidBrush(Color.DeepPink);
                    }

                    //Draw the arrow
                    g.FillPath(ArrowBrush, pth);

                    break;
                default:
                    break;
            }
        }

        //Override mouse and focus events to draw
        //proper borders. Basically, set the color and Invalidate(),
        //In general, Invalidate causes a control to redraw itself.
        #region "Mouse and focus Overrides"
        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            BorderBrush = new SolidBrush(Color.DeepPink);
            this.Invalidate();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            BorderBrush = new SolidBrush(Color.FromArgb(255, 40, 40, 80));
            this.Invalidate();
        }

        protected override void OnLostFocus(System.EventArgs e)
        {
            base.OnLostFocus(e);
            BorderBrush = new SolidBrush(Color.FromArgb(255, 40, 40, 80));
            this.Invalidate();
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            BorderBrush = new SolidBrush(Color.DeepPink);
            this.Invalidate();
        }

        protected override void OnMouseHover(System.EventArgs e)
        {
            base.OnMouseHover(e);
            BorderBrush = new SolidBrush(Color.DeepPink);
            this.Invalidate();
        }
        #endregion
    }
}