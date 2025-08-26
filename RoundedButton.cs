using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace BibliotecaQRCode
{


    public class RoundedButton : Button
    {
        public int CornerRadius { get; set; } = 12;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = Color.SteelBlue;
            ForeColor = Color.White;
            Resize += (s, e) => UpdateRegion();
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            base.OnPaint(pevent);
        }

        private void UpdateRegion()
        {
            var rect = ClientRectangle;
            rect.Inflate(-1, -1);
            using var path = new GraphicsPath();
            int d = CornerRadius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            Region?.Dispose();
            Region = new Region(path);
            Invalidate();
        }
    }

}
