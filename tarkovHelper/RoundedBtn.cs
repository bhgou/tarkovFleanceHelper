using System.Runtime.InteropServices;


namespace tarkovHelper
{
    public class RoundedBtn : Button
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse );

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            IntPtr ptr = CreateRoundRectRgn(0, 0, Width, Height, 35, 35);
            Region = Region.FromHrgn(ptr);
        }
    }
}
