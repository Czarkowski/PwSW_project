using PasiekaMainProject.Helpers;
using PasiekaMainProject.Model;
using PasiekaMainProject.MyClassAndInterface;
using PasiekaMainProject.MyEnums;
using PasiekaMainProject.Repositories;
using SingletonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasiekaMainProject
{
    public partial class PasiekaMap : UserControl, IObserver<UlModel>, ISingleton<PasiekaMap>
    {
        private Point? lastMouseLocation = null;
        private IPasiekaRepository repository;
        private readonly Size mapSize = SpecialValues.MapSize;
        private UlModel ulModel;
        private PoseModel poseModel;
        private Point lastPoseModelPoint = Point.Empty;
        private PasiekaGrid pasiekaGrid => SingletonPasiekaGrid.Instance;
        private MapControler pbMapControler;
        private bool isMoveMod;
        private List<PoseModel> poseModels { get; set; }

        public PasiekaMap()
        {
            InitializeComponent();
            repository = new PasiekaRepository(MyDbContext.Instance);
            poseModels = repository.GetPoseModels();

            pbMapControler = new MapControler();

            panelMain.Controls.Clear();

            panelMain.Controls.Add(pbMapControler);


            //DoubleBuffered = true; // Zapobiega migotaniu podczas odświeżania rysunku
            pbMapControler.MouseDown += PictureBoxMouseDown;
            pbMapControler.MouseUp += PictureBoxMouseUp;
            pbMapControler.MouseMove += PictureBoxMouseMove;
            pbMapControler.MouseDoubleClick += PictureBoxMouseDoubleClick;
            pbMapControler.Size = mapSize;
            pbMapControler.Location = new Point(0, 0);
            pbMapControler.PoseModels = poseModels;


            panelPasiekaGrid.Controls.Clear();
            panelPasiekaGrid.Controls.Add(pasiekaGrid);
            pasiekaGrid.Subscribe(this);
        }

        public void RefreshSingletonControls()
        {
            panelPasiekaGrid.Controls.Clear();
            panelPasiekaGrid.Controls.Add(pasiekaGrid);
            pasiekaGrid.Subscribe(this);
        }

        private void PasiekaMap_Load(object sender, EventArgs e)
        {
            cbColor.Items.Clear();
            cbColor.DataSource = Enum.GetValues(typeof(ColorEnum)).Cast<ColorEnum>().ToList();
        }

        private void PictureBoxMouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && IsUlHit(poseModels, e.Location, out PoseModel model))
            {
                pasiekaGrid.ChangeSelectedModel(model.UlId);
                cbColor.SelectedItem = model.ColorEnum;
            }
        }
        private void PictureBoxMouseDown(object sender, MouseEventArgs e)
        {
            if (isMoveMod)
            {
                repository.UpdatePoseModel(poseModel);
                CancleMoveMode(true);
                pbMapControler.Refresh();
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                lastMouseLocation = e.Location;
            }
        }

        private void PictureBoxMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastMouseLocation = null;
            }
        }

        private void PictureBoxMouseMove(object sender, MouseEventArgs e)
        {
            if (isMoveMod)
            {
                poseModel.x = e.X;
                poseModel.y = e.Y;
                pbMapControler.Refresh();
                return;
            }
            if (lastMouseLocation.HasValue)
            {
                int deltaX = e.X - lastMouseLocation.Value.X;
                int deltaY = e.Y - lastMouseLocation.Value.Y;

                int newX = pbMapControler.Location.X + deltaX;
                int newY = pbMapControler.Location.Y + deltaY;

                var point = new Point(newX, newY);
                shrinkPoint(ref point);
                //pbMapControler.Location = point;
                panelMain.AutoScrollPosition = new Point(-point.X, -point.Y);

                //lastMouseLocation = e.Location;
            }
        }

        private void shrinkPoint(ref Point point)
        {
            point.X = point.X > 0 ? 0 : point.X;
            point.Y = point.Y > 0 ? 0 : point.Y;
            point.X = point.X < (-mapSize.Width + panelMain.Width) ? (-mapSize.Width + panelMain.Width) : point.X;
            point.Y = point.Y < (-mapSize.Height + panelMain.Height) ? (-mapSize.Height + panelMain.Height) : point.Y;
        }

        private bool IsUlHit(List<PoseModel> poseModels, Point point, out PoseModel? model)
        {
            model = poseModels.Find(x =>
            {
                return point.IsContainsIn(x);
            });
            return !model.IsNull();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(UlModel value)
        {
            CancleMoveMode();
            ulModel = value;
            pbMapControler.SelectedUlId = ulModel?.Id ?? default;
            if (value == null)
            {
                poseModel = null;
                btnRemove.Enabled = false;
                btnMove.Enabled = false;
                cbColor.Enabled = false;
                btnAdd.Enabled = false;
                //poseModels.RemoveAll(x => x.UlModel == null);
            }
            else if (IsOnMap(value.Id, out PoseModel pose))
            {
                poseModel = pose;
                btnRemove.Enabled = true;
                btnMove.Enabled = true;
                cbColor.Enabled = true;
                btnAdd.Enabled = false;
            }
            else
            {
                poseModel = null;
                btnRemove.Enabled = false;
                btnMove.Enabled = false;
                cbColor.Enabled = false;
                btnAdd.Enabled = true;
            }
            pbMapControler.Refresh();
        }

        public bool IsOnMap(int ulId, out PoseModel pose)
        {
            pose = poseModels.Where(x => x.UlId == ulId).FirstOrDefault();
            return pose != null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var point = panelMain.AutoScrollPosition;
            var poseModel = new PoseModel(point.X + panelMain.Width / 2, point.Y + panelMain.Height / 2, ulModel.Id, ColorEnum.Szary);
            repository.SavePoseModel(poseModel);
            poseModels.Add(poseModel);
            pasiekaGrid.ChangeSelectedModel(poseModel.UlId);
            pbMapControler.Refresh();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            poseModels.Remove(poseModel);
            repository.DeletePoseModel(poseModel);
            pasiekaGrid.ChangeSelectedModel(ulModel);
            pbMapControler.Refresh();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!isMoveMod)
            {
                btnMove.Text = "Wyłacz tryb przesuwania";
                isMoveMod = true;
                lastPoseModelPoint = new Point(poseModel.x, poseModel.y);
            }
            else
            {
                CancleMoveMode();
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbColor.Enabled || poseModel == null)
            {
                return;
            }
            poseModel.ColorEnum = (ColorEnum)cbColor.SelectedItem;
            repository.UpdatePoseModel(poseModel);
            pbMapControler.Refresh();
        }


        private void pasiekaMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                isMoveMod = false;
            }
        }

        private void CancleMoveMode(bool isGood = false)
        {
            if (!isMoveMod) return;
            if (!isGood)
            {
                poseModel.y = lastPoseModelPoint.Y;
                poseModel.x = lastPoseModelPoint.X;
                pbMapControler.Refresh();
            }
            lastPoseModelPoint = Point.Empty;
            isMoveMod = false;
            btnMove.Text = "Przesuń";
        }

        static PasiekaMap ISingleton<PasiekaMap>.initilize()
        {
            return new();
        }
        
    }
}
