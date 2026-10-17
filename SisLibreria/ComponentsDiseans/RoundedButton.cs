using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SisLibreria.ComponentsDiseans
{
    public class RoundedButton : Button
    {
        private Color borderColor = Color.White;
        private int borderSize = 2;
        private int borderRadius = 10; // Esquinas ligeramente redondeadas
        private bool showPlusCircle = true;
        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(160, 45);
            this.BackColor = Color.FromArgb(84, 122, 169); // Color azul del botón
            this.ForeColor = Color.White;
            this.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.Cursor = Cursors.Hand;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -1, -1);
            int smoothSize = 2;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1))
            using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                this.Region = new Region(pathSurface);
                pevent.Graphics.DrawPath(penSurface, pathSurface);

                //Dibuja el borde blanco exterior
                if (borderSize >= 1)
                {
                    pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }

            // Dibuja el círculo azul con el símbolo '+' a la derecha del texto
            //if (showPlusCircle)
            //{
            //    Calculamos la posición del texto y del círculo basado en el ancho
            //    SizeF textSize = pevent.Graphics.MeasureString(this.Text, this.Font);
            //    float textX = (this.Width - textSize.Width) / 2f - 15; // Centrado movido un poco a la izquierda
            //    float textY = (this.Height - textSize.Height) / 2f;

            //    Dibujar el círculo azul a la derecha del texto
            //    float circleDiameter = 26;
            //    float circleX = textX + textSize.Width + 12;
            //    float circleY = (this.Height - circleDiameter) / 2f;

            //    using (Brush circleBrush = new SolidBrush(Color.FromArgb(30, 144, 255))) // Azul brillante para el círculo
            //    {
            //        pevent.Graphics.FillEllipse(circleBrush, circleX, circleY, circleDiameter, circleDiameter);
            //    }

            //    Dibujar el símbolo '+' dentro del círculo
            //    using (Brush plusBrush = new SolidBrush(Color.White))
            //    using (Font plusFont = new Font("Segoe UI", 14, FontStyle.Bold))
            //    {
            //        StringFormat sf = new StringFormat();
            //        sf.Alignment = StringAlignment.Center;
            //        sf.LineAlignment = StringAlignment.Center;

            //        RectangleF circleRect = new RectangleF(circleX, circleY, circleDiameter, circleDiameter);
            //        pevent.Graphics.DrawString("+", plusFont, plusBrush, circleRect, sf);
            //    }
            //}
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
