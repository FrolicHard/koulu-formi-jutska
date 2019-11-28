using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Autokauppa
{
    public class CustomTextBox : TextBox
    {
        private TextFormatFlags textFlags = TextFormatFlags.Default;
        ComboBox comboBox1 = new ComboBox();
        Rectangle textBorder = new Rectangle();
        Rectangle textRectangle = new Rectangle();
        StringBuilder textMeasurements = new StringBuilder();
        private const int borderWidth = 6;
        private Brush BorderBrush = new SolidBrush(Color.FromArgb(255, 40, 40, 80));
        private Brush ArrowBrush = new SolidBrush(Color.FromArgb(255, 20, 30, 50));
        private Brush DropButtonBrush = new SolidBrush(SystemColors.ControlText);
        private Pen p = new Pen(Color.FromArgb(255, 40, 40, 80), borderWidth);


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);


            switch (m.Msg)
            {
                case 0xf:
                    //
                    //Draw Borders to the textbox
                    //

                    Graphics g = this.CreateGraphics();
                    g.DrawRectangle(p, this.ClientRectangle);
                    g.SmoothingMode = SmoothingMode.HighQuality;

                    break;
                default:
                    break;
            }
        }




        public CustomTextBox()
            : base()
        {
            this.Location = new Point(10, 10);
            this.Size = new Size(300, 200);
            this.Font = SystemFonts.IconTitleFont;
            this.Text = " ";

            textBorder.Location = new Point(10, 10);
            textBorder.Size = new Size(200, 50);
            textRectangle.Location = new Point(textBorder.X + 2,
                textBorder.Y + 2);
            textRectangle.Size = new Size(textBorder.Size.Width - 2,
                textBorder.Height - 2);

            
        }

        // Use DrawText with the current TextFormatFlags.
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (TextBoxRenderer.IsSupported)
            {
                TextBoxRenderer.DrawTextBox(e.Graphics, textBorder, this.Text,
                    this.Font, textRectangle, textFlags, TextBoxState.Normal);

                this.Parent.Text = "CustomTextBox Enabled";
            }
            else
            {
                this.Parent.Text = "CustomTextBox Disabled";
            }
        }



        //Override mouse and focus events to draw
        //proper borders. Basically, set the color and Invalidate(),
        //In general, Invalidate causes a control to redraw itself.
        #region "Mouse and focus Overrides"
        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            p = new Pen(Color.DeepPink, borderWidth);
            this.Invalidate();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            p = new Pen(Color.FromArgb(255, 40, 40, 80), borderWidth);
            this.Invalidate();
        }

        protected override void OnLostFocus(System.EventArgs e)
        {
            base.OnLostFocus(e);
            p = new Pen(Color.FromArgb(255, 40, 40, 80), borderWidth);
            this.Invalidate();
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            p = new Pen(Color.DeepPink, borderWidth);
            this.Invalidate();
        }

        protected override void OnMouseHover(System.EventArgs e)
        {
            base.OnMouseHover(e);
            p = new Pen(Color.DeepPink, borderWidth);
            this.Invalidate();
        }
        #endregion
    }
}