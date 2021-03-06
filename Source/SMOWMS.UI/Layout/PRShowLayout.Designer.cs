using System;
using Smobiler.Core;
namespace SMOSEC.UI.Layout
{
    partial class PrShowLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public PrShowLayout()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Panel1 = new Smobiler.Core.Controls.Panel();
            this.lblPRID = new Smobiler.Core.Controls.Label();
            this.Label1 = new Smobiler.Core.Controls.Label();
            this.Label3 = new Smobiler.Core.Controls.Label();
            this.Label4 = new Smobiler.Core.Controls.Label();
            this.Label5 = new Smobiler.Core.Controls.Label();
            this.Label6 = new Smobiler.Core.Controls.Label();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.lblASSID = new Smobiler.Core.Controls.Label();
            this.lblSN = new Smobiler.Core.Controls.Label();
            this.lblHMan = new Smobiler.Core.Controls.Label();
            this.lblHDate = new Smobiler.Core.Controls.Label();
            this.lblMode = new Smobiler.Core.Controls.Label();
            this.txtContent = new Smobiler.Core.Controls.TextBox();
            // 
            // Panel1
            // 
            this.Panel1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.lblPRID,
            this.Label1,
            this.Label3,
            this.Label4,
            this.Label5,
            this.Label6,
            this.Label7,
            this.lblASSID,
            this.lblSN,
            this.lblHMan,
            this.lblHDate,
            this.lblMode,
            this.txtContent});
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(300, 190);
            // 
            // lblPRID
            // 
            this.lblPRID.DataMember = "PrId";
            this.lblPRID.DisplayMember = "PrId";
            this.lblPRID.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblPRID.Location = new System.Drawing.Point(10, 5);
            this.lblPRID.Name = "lblPRID";
            this.lblPRID.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblPRID.Size = new System.Drawing.Size(274, 20);
            this.lblPRID.Text = "001";
            this.lblPRID.ZIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(10, 25);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label1.Size = new System.Drawing.Size(68, 16);
            this.Label1.Text = "资产编号";
            this.Label1.ZIndex = 1;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(10, 41);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label3.Size = new System.Drawing.Size(68, 16);
            this.Label3.Text = "SN编号";
            this.Label3.ZIndex = 1;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(10, 57);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label4.Size = new System.Drawing.Size(68, 16);
            this.Label4.Text = "处理人";
            this.Label4.ZIndex = 1;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(10, 73);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label5.Size = new System.Drawing.Size(68, 16);
            this.Label5.Text = "处理时间";
            this.Label5.ZIndex = 1;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(10, 89);
            this.Label6.Name = "Label6";
            this.Label6.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label6.Size = new System.Drawing.Size(68, 16);
            this.Label6.Text = "处理方式";
            this.Label6.ZIndex = 1;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(10, 105);
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(68, 58);
            this.Label7.Text = "处理内容";
            this.Label7.ZIndex = 1;
            // 
            // lblASSID
            // 
            this.lblASSID.DataMember = "AssId";
            this.lblASSID.DisplayFormat = "资产";
            this.lblASSID.DisplayMember = "AssId";
            this.lblASSID.Location = new System.Drawing.Point(78, 25);
            this.lblASSID.Name = "lblASSID";
            this.lblASSID.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblASSID.Size = new System.Drawing.Size(206, 16);
            this.lblASSID.Text = "001";
            this.lblASSID.ZIndex = 1;
            // 
            // lblSN
            // 
            this.lblSN.DataMember = "SN";
            this.lblSN.DisplayMember = "SN";
            this.lblSN.Location = new System.Drawing.Point(78, 41);
            this.lblSN.Name = "lblSN";
            this.lblSN.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblSN.Size = new System.Drawing.Size(206, 16);
            this.lblSN.ZIndex = 1;
            // 
            // lblHMan
            // 
            this.lblHMan.DataMember = "HandleMan";
            this.lblHMan.DisplayMember = "HandleMan";
            this.lblHMan.Location = new System.Drawing.Point(78, 57);
            this.lblHMan.Name = "lblHMan";
            this.lblHMan.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblHMan.Size = new System.Drawing.Size(206, 16);
            this.lblHMan.Text = "001";
            this.lblHMan.ZIndex = 1;
            // 
            // lblHDate
            // 
            this.lblHDate.DataMember = "HandleDate";
            this.lblHDate.DisplayMember = "HandleDate";
            this.lblHDate.Location = new System.Drawing.Point(78, 73);
            this.lblHDate.Name = "lblHDate";
            this.lblHDate.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblHDate.Size = new System.Drawing.Size(206, 16);
            this.lblHDate.Text = "001";
            this.lblHDate.ZIndex = 1;
            // 
            // lblMode
            // 
            this.lblMode.DataMember = "ProcessModeName";
            this.lblMode.DisplayMember = "ProcessModeName";
            this.lblMode.Location = new System.Drawing.Point(78, 89);
            this.lblMode.Name = "lblMode";
            this.lblMode.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.lblMode.Size = new System.Drawing.Size(206, 16);
            this.lblMode.Text = "001";
            this.lblMode.ZIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.Transparent;
            this.txtContent.DataMember = "ProcessContent";
            this.txtContent.DisplayMember = "ProcessContent";
            this.txtContent.Location = new System.Drawing.Point(78, 106);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Padding = new Smobiler.Core.Controls.Padding(10F, 0F, 0F, 0F);
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(206, 57);
            this.txtContent.Text = "111";
            // 
            // PrShowLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Panel1});
            this.Size = new System.Drawing.Size(300, 170);
            this.Name = "PrShowLayout";

        }
        #endregion

        internal Smobiler.Core.Controls.Panel Panel1;
        private Smobiler.Core.Controls.Label lblPRID;
        private Smobiler.Core.Controls.Label Label1;
        private Smobiler.Core.Controls.Label Label3;
        private Smobiler.Core.Controls.Label Label4;
        private Smobiler.Core.Controls.Label Label5;
        private Smobiler.Core.Controls.Label Label6;
        private Smobiler.Core.Controls.Label Label7;
        private Smobiler.Core.Controls.Label lblASSID;
        private Smobiler.Core.Controls.Label lblSN;
        private Smobiler.Core.Controls.Label lblHMan;
        private Smobiler.Core.Controls.Label lblHDate;
        private Smobiler.Core.Controls.Label lblMode;
        internal Smobiler.Core.Controls.TextBox txtContent;
    }
}