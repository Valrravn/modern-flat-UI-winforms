using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectXFormYT {
    public partial class Form1 : DevExpress.XtraEditors.DirectXForm {
        public Form1() {
            InitializeComponent();

            viewPages = new List<ViewPage>();
            viewPages.Add(new ViewPage("page-home", "Agents", npHome) { IsSelected = true });
            viewPages.Add(new ViewPage("page-transactions", "Map", npTransactions));
            viewPages.Add(new ViewPage("page-accounts", "Accounts", npAccounts));
            viewPages.Add(new ViewPage("page-payroll", "Payroll", npPayroll));
            viewPages.Add(new ViewPage("page-settings", "Settings", npSettings));

            UpdateHtmlForm();
        }

        List<ViewPage> viewPages;

        void UpdateHtmlForm() {
            HtmlTemplate.Template = HtmlTemplate.Template.Insert(0, " ");
            HtmlTemplate.Template = HtmlTemplate.Template.Remove(0, 1);
        }
        protected override object GetHtmlValue(string fieldName, DxHtmlElementBase element) {
            if(fieldName == "Pages")
                return viewPages;
            return base.GetHtmlValue(fieldName, element);
        }
        void Form1_HtmlElementMouseDown(object sender, DevExpress.Utils.Html.DxHtmlElementMouseEventArgs e) {
            if(e.ElementId.StartsWith("page-"))
                (e.MouseArgs as DXMouseEventArgs).Handled = true;
        }

        void Form1_HtmlElementMouseClick(object sender, DxHtmlElementMouseEventArgs e) {
            if(e.ElementId.StartsWith("page-")) {
                var selectedPage = viewPages.First(x => x.Id == e.ElementId);
                viewPages.ForEach(x => x.IsSelected = x.Page == selectedPage.Page);
                navigationFrame1.SelectedPage = selectedPage.Page;
                UpdateHtmlForm();
            }
        }
    }

    public class ViewPage {
        public string Id { get; }
        public string Caption { get; }
        public NavigationPage Page { get; }
        public bool IsSelected { get; set; }

        public ViewPage(string id, string caption, NavigationPage page) {
            Id = id;
            Caption = caption;
            Page = page;
        }
    }
}
