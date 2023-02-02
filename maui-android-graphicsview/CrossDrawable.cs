namespace maui_android_graphicsview;

public sealed class CrossDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.StrokeColor = Colors.Red;

        // horizontal line
        canvas.DrawLine(0, dirtyRect.Height / 2, dirtyRect.Width, dirtyRect.Height / 2);

        // vertical line
        canvas.DrawLine(dirtyRect.Width / 2, 0, dirtyRect.Width / 2, dirtyRect.Height);
    }
}