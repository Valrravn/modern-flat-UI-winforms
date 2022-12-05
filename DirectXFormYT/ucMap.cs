using DevExpress.Map;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraMap;
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
    public partial class ucMap : XtraUserControl {

        public ucMap() {
            InitializeComponent();
        }

        void wmsDataProvider1_ResponseCapabilities(object sender, CapabilitiesRespondedEventArgs e) {
            wmsDataProvider1.ActiveLayerName = e.Layers[9].Name;
            //labelControl1.Text = string.Format("{0}", e.Layers[9].Name);
            //labelControl2.Text = string.Format("{0}", e.Layers[9].Title);
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            mapControl1.CenterPoint = new GeoPoint(35, -89);
            labelControl2.Text = "Center Point: 35, -89  ";
        }

        private void simpleButton7_Click(object sender, EventArgs e) {
            mapControl1.ZoomLevel = (mapControl1.ZoomLevel == 5) ? 14 : 5;
            labelControl1.Text = (labelControl1.Text == "Zoom Level: 5   ") ? "Zoom Level: 14   " : "Zoom Level: 5   ";
        }

        private void simpleButton5_Click(object sender, EventArgs e) {
            mapControl1.CenterPoint = new GeoPoint(40.7, -74.2);
            labelControl2.Text = "Center Point: 40.7, -74.2  ";
        }
    }

}
