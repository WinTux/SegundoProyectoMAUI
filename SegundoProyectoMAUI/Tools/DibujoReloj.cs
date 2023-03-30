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
            var centroReloj = new PointF(200,400);
            var radioCirculo = 180;
            //Cuerpo del reloj
            canvas.StrokeColor = Colors.Red;
            canvas.StrokeSize = 7;
            canvas.DrawCircle(centroReloj, radioCirculo);
            canvas.DrawCircle(centroReloj, 5);

            //La manecilla del horero
            canvas.StrokeSize = 4;
            var horero = GetManecillaHora(tiempoActual, radioCirculo,centroReloj);
            canvas.DrawLine(centroReloj, horero);

            var minutero = GetManecillaMinuto(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, minutero);

            var segundero = GetManecillaSegundo(tiempoActual, radioCirculo, centroReloj);
            canvas.DrawLine(centroReloj, segundero);
        }

        private PointF GetManecillaSegundo(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int segudoActual = tiempoActual.Second;
            var anguloGrad = segudoActual * 360 / 60;//sería igual: segundoActual * 6
            var anguloRad = Math.PI / 180.0 * anguloGrad;//Formula grados -> radianes
            PointF extremoManecilla = new(
                (float)(radioCirculo * Math.Sin(anguloRad)) + centroReloj.X,
                (float)(radioCirculo * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }

        private PointF GetManecillaMinuto(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int minutoActual = tiempoActual.Minute;
            var anguloGrad = minutoActual * 360 / 60;//sería igual: minutoActual * 6
            var anguloRad = Math.PI / 180.0 * anguloGrad;//Formula grados -> radianes
            PointF extremoManecilla = new(
                (float)(radioCirculo * Math.Sin(anguloRad)) + centroReloj.X,
                (float)(radioCirculo * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }

        private PointF GetManecillaHora(DateTime tiempoActual, int radioCirculo, PointF centroReloj)
        {
            int horaActual = tiempoActual.Hour;
            if (horaActual > 12) horaActual -= 12;
            var anguloGrad = horaActual * 360 / 12;
            var anguloRad = Math.PI / 180.0 * anguloGrad;//Formula grados -> radianes
            var horeroLongitud = radioCirculo * 0.6;
            PointF extremoManecilla = new( 
                (float)(horeroLongitud * Math.Sin(anguloRad)) + centroReloj.X, 
                (float)(horeroLongitud * Math.Cos(anguloRad)) + centroReloj.Y);
            return extremoManecilla;
        }
    }
}
