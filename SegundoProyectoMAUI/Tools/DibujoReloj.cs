using Microsoft.Maui.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProyectoMAUI.Tools
{
    public class DibujoReloj : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            DateTime tiempoActual = DateTime.Now;
            var centroReloj = new PointF(390,400);
            var radioCirculo = 200;
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 7;
            canvas.DrawCircle(centroReloj, radioCirculo);
        }
    }
}
