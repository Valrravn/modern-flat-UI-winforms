using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectXFormYT {
    public partial class ucOperatives : XtraUserControl {
        public ucOperatives() {
            InitializeComponent();
            gridControl1.DataSource = Operative.GenSampleData();
            tileView1.FocusedRowChanged += TileView1_FocusedRowChanged;
        }

        private void TileView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            Operative item = (gridControl1.DataSource as List<Operative>)[tileView1.GetDataSourceRowIndex(e.FocusedRowHandle)];
            layoutControl1.DataSource = item;
        }
    }

    public class Operative {

        public Operative(Image photo, string firstName, string lastName, string agentCode, DateTime joinDate, float successRate, AgentRank rank, string handler, DateTime handlerAssigned, AgentStatus status, string gradeMM, string gradePH, string gradeEST, string gradeOverall) {
            Photo = photo;
            FirstName = firstName;
            LastName = lastName;
            AgentCode = agentCode;
            JoinDate = joinDate;
            SuccessRate = successRate;
            Rank = rank;
            Handler = handler;
            HandlerAssigned = handlerAssigned;
            Status = status;
            GradeMM = gradeMM;
            GradePH = gradePH;
            GradeEST = gradeEST;
            GradeOverall = gradeOverall;
        }

        public static List<Operative> GenSampleData() {
            List<Operative> result = new List<Operative>();
            Operative ag1 = new Operative(
                global::DirectXFormYT.Properties.Resources.saints_cain,
                "Louisa",
                "Cain",
                "XCA-024-St",
                DateTime.Now.AddDays(-87).AddYears(-19),
                86,
                AgentRank.Omega,
                "Benjamin Travis",
                DateTime.Now.AddDays(-12).AddYears(-19),
                AgentStatus.Terminated,
                "A", "A", "C", "B");
            result.Add(ag1);

            Operative ag2 = new Operative(
                global::DirectXFormYT.Properties.Resources.cd47_transparent,
                "Unknown",
                "Unknown",
                "XCA-47",
                DateTime.Now.AddDays(-125).AddYears(-23),
                100,
                AgentRank.Delta,
                "Diana Burnwood",
                DateTime.Now.AddDays(-23).AddYears(-23),
                AgentStatus.Active,
                "A", "A", "A", "A");
            result.Add(ag2);
            return result;
        }

        public Image Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AgentCode { get; set; }
        public DateTime JoinDate { get; set; }
        public float SuccessRate { get; set; }
        public AgentRank Rank { get; set; }
        public string Handler { get; set; }
        public DateTime HandlerAssigned { get; set; }
        public AgentStatus Status { get; set; }
        public string GradeMM { get; set; }
        public string GradePH { get; set; }
        public string GradeEST { get; set; }
        public string GradeOverall { get; set; }
    }

    public enum AgentRank { Gamma, Tetra, Delta, Omega }
    public enum AgentStatus { Active, Inactive, Terminated }

}
