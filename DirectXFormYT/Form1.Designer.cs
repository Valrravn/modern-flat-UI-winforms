namespace DirectXFormYT {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npHome = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.npTransactions = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.npAccounts = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.npPayroll = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.npSettings = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.ucOperatives1 = new DirectXFormYT.ucOperatives();
            this.ucMap1 = new DirectXFormYT.ucMap();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.npHome.SuspendLayout();
            this.npTransactions.SuspendLayout();
            this.npAccounts.SuspendLayout();
            this.npPayroll.SuspendLayout();
            this.npSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.navigationFrame1);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(82, 166);
            this.directXFormContainerControl1.Margin = new System.Windows.Forms.Padding(4);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Padding = new System.Windows.Forms.Padding(0, 0, 500, 0);
            this.directXFormContainerControl1.Size = new System.Drawing.Size(1776, 927);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationFrame1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.navigationFrame1.Appearance.Options.UseBackColor = true;
            this.navigationFrame1.Controls.Add(this.npHome);
            this.navigationFrame1.Controls.Add(this.npTransactions);
            this.navigationFrame1.Controls.Add(this.npAccounts);
            this.navigationFrame1.Controls.Add(this.npPayroll);
            this.navigationFrame1.Controls.Add(this.npSettings);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame1.Margin = new System.Windows.Forms.Padding(4);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npHome,
            this.npTransactions,
            this.npAccounts,
            this.npPayroll,
            this.npSettings});
            this.navigationFrame1.SelectedPage = this.npHome;
            this.navigationFrame1.Size = new System.Drawing.Size(1776, 927);
            this.navigationFrame1.TabIndex = 0;
            this.navigationFrame1.Text = "navigationFrame1";
            this.navigationFrame1.TransitionAnimationProperties.FrameInterval = 4000;
            this.navigationFrame1.TransitionType = DevExpress.Utils.Animation.Transitions.Push;
            // 
            // npHome
            // 
            this.npHome.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.npHome.Appearance.Options.UseBackColor = true;
            this.npHome.Caption = "npHome";
            this.npHome.Controls.Add(this.ucOperatives1);
            this.npHome.Margin = new System.Windows.Forms.Padding(4);
            this.npHome.Name = "npHome";
            this.npHome.Size = new System.Drawing.Size(1776, 927);
            // 
            // npTransactions
            // 
            this.npTransactions.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.npTransactions.Appearance.Options.UseBackColor = true;
            this.npTransactions.Caption = "npTransactions";
            this.npTransactions.Controls.Add(this.ucMap1);
            this.npTransactions.Margin = new System.Windows.Forms.Padding(4);
            this.npTransactions.Name = "npTransactions";
            this.npTransactions.Size = new System.Drawing.Size(1776, 927);
            // 
            // npAccounts
            // 
            this.npAccounts.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.npAccounts.Appearance.Options.UseBackColor = true;
            this.npAccounts.Caption = "npAccounts";
            this.npAccounts.Controls.Add(this.labelControl3);
            this.npAccounts.Margin = new System.Windows.Forms.Padding(4);
            this.npAccounts.Name = "npAccounts";
            this.npAccounts.Size = new System.Drawing.Size(1776, 927);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl3.Location = new System.Drawing.Point(0, 0);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(1776, 927);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Accounts Page";
            // 
            // npPayroll
            // 
            this.npPayroll.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.npPayroll.Appearance.Options.UseBackColor = true;
            this.npPayroll.Caption = "npPayroll";
            this.npPayroll.Controls.Add(this.labelControl4);
            this.npPayroll.Margin = new System.Windows.Forms.Padding(4);
            this.npPayroll.Name = "npPayroll";
            this.npPayroll.Size = new System.Drawing.Size(1776, 927);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl4.Location = new System.Drawing.Point(0, 0);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(1776, 927);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Payroll Page";
            // 
            // npSettings
            // 
            this.npSettings.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.npSettings.Appearance.Options.UseBackColor = true;
            this.npSettings.Caption = "npSettings";
            this.npSettings.Controls.Add(this.labelControl5);
            this.npSettings.Margin = new System.Windows.Forms.Padding(4);
            this.npSettings.Name = "npSettings";
            this.npSettings.Size = new System.Drawing.Size(1776, 927);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseTextOptions = true;
            this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl5.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl5.Location = new System.Drawing.Point(0, 0);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(1776, 927);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Settings Page";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.ImageSize = new System.Drawing.Size(24, 24);
            this.svgImageCollection1.Add("charttype_swiftplot", "image://svgimages/chart/charttype_swiftplot.svg");
            this.svgImageCollection1.Add("bo_employee", "image://svgimages/business objects/bo_employee.svg");
            this.svgImageCollection1.Add("weather_lightning", "image://svgimages/icon builder/weather_lightning.svg");
            this.svgImageCollection1.Add("link", "image://svgimages/spreadsheet/link.svg");
            this.svgImageCollection1.Add("security_fingerprint", "image://svgimages/icon builder/security_fingerprint.svg");
            // 
            // ucOperatives1
            // 
            this.ucOperatives1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOperatives1.Location = new System.Drawing.Point(0, 0);
            this.ucOperatives1.Name = "ucOperatives1";
            this.ucOperatives1.Size = new System.Drawing.Size(1776, 927);
            this.ucOperatives1.TabIndex = 0;
            // 
            // ucMap1
            // 
            this.ucMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMap1.Location = new System.Drawing.Point(0, 0);
            this.ucMap1.Margin = new System.Windows.Forms.Padding(4);
            this.ucMap1.Name = "ucMap1";
            this.ucMap1.Size = new System.Drawing.Size(1776, 927);
            this.ucMap1.TabIndex = 0;
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(1940, 1171);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.HtmlImages = this.svgImageCollection1;
            // 
            // 
            // 
            this.HtmlTemplate.Styles = resources.GetString("Form1.HtmlTemplate.Styles");
            this.HtmlTemplate.Template = resources.GetString("Form1.HtmlTemplate.Template");
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.HtmlElementMouseClick += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.Form1_HtmlElementMouseClick);
            this.HtmlElementMouseDown += new DevExpress.Utils.Html.DxHtmlElementMouseEventHandler(this.Form1_HtmlElementMouseDown);
            this.directXFormContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.npHome.ResumeLayout(false);
            this.npTransactions.ResumeLayout(false);
            this.npAccounts.ResumeLayout(false);
            this.npPayroll.ResumeLayout(false);
            this.npSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage npHome;
        private DevExpress.XtraBars.Navigation.NavigationPage npTransactions;
        private DevExpress.XtraBars.Navigation.NavigationPage npAccounts;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraBars.Navigation.NavigationPage npPayroll;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraBars.Navigation.NavigationPage npSettings;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private ucOperatives ucOperatives1;
        private ucMap ucMap1;
    }
}

