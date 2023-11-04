using PasiekaMainProject.Model;
using PasiekaMainProject.MyException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject
{
    public class MapControler : PictureBox
    {
        public int SelectedUlId { get; set; }
        public List<PoseModel> PoseModels { get; set; }
        public MapControler()
        {
            DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            BackColor = Color.LightGreen;
            base.OnPaint(e);

            Graphics g = e.Graphics;

            bool isNoUlModel = false;
            foreach (var pose in PoseModels)
            {
                try
                {

                    Rectangle rect = new Rectangle(pose.x, pose.y, 50, 50);
                    Color kolorWypelnienia = Color.FromKnownColor((KnownColor)pose.ColorEnum);
                    string numer = pose.Ul?.Numer.ToString() ?? throw new NoOrBadModelValueException("Ulmodel.Name", pose);
                    //if (numer == string.Empty) {
                    //    PoseModels.Remove(pose);
                    //    continue;
                    //}
                    using (Brush brush = new SolidBrush(kolorWypelnienia))
                    {
                        g.FillRectangle(brush, rect);
                    }

                    using (Pen pen = new Pen(pose.UlId == SelectedUlId ? Color.BlueViolet : Color.Black, 5))
                    {
                        g.DrawRectangle(pen, rect);
                    }

                    using (Font font = new Font("Arial", 12))
                    using (Brush numerBrush = new SolidBrush(Color.Black))
                    {
                        SizeF numerSize = g.MeasureString(numer, font);
                        PointF numerPosition = new PointF(
                            rect.Left + (rect.Width - numerSize.Width) / 2,
                            rect.Top + (rect.Height - numerSize.Height) / 2
                        );

                        g.DrawString(numer, font, numerBrush, numerPosition);
                    }

                }
                catch (NoOrBadModelValueException ex)
                {
                    DialogResult result = MessageBox.Show($"{ex.Message}", "Rozumiem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isNoUlModel = true;
                }
            }
            if (isNoUlModel)
            {
                PoseModels.RemoveAll(x => x.Ul == null);
            }
        }
    }
}
