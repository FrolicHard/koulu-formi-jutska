using System.Drawing;
using System.Windows.Forms;


namespace AutoWCFClient.view
{

    //Override for the toolstrip buttons and toolstripmenu items to make them pretty.
    class CustomProfessionalRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle r = Rectangle.Inflate(e.Item.ContentRectangle, 8,8);

            if (e.Item.Selected)
            {
                using (Brush b = new SolidBrush(Color.DeepPink))
                {
                    e.Graphics.FillRectangle(b, r);
                }
            }
            else
            {
                using (Brush b = new SolidBrush(Color.FromArgb(255, 30, 40, 80)))
                {
                    e.Graphics.FillRectangle(b, r);
                }
            }
            
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            Rectangle r = Rectangle.Inflate(e.AffectedBounds, 0, 2);
            using (Pen p = new Pen(Color.DeepPink,8))
            {
                e.Graphics.DrawRectangle(p, r);
            }
            
        }
    }
}
