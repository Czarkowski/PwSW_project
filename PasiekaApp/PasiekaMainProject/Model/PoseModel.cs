using PasiekaMainProject.MyEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasiekaMainProject.Model
{
    [Table("Pozycja")]
    public class PoseModel
    {
        public PoseModel() { }
        public PoseModel(int x, int y, int ulid, ColorEnum color)
        {
            this.x = x;
            this.y = y;
            this.UlId = ulid;
            this.ColorEnum = color;
        }
        public int Id { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        [ForeignKey("UlModel")]
        public int UlId { get; set; }
        public UlModel Ul { get; set; }
        public ColorEnum ColorEnum { get; set; }
    }
}
