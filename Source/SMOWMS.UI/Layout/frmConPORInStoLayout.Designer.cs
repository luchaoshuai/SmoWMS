using System;
using Smobiler.Core;
namespace SMOWMS.UI.Layout
{
    partial class frmConPORInStoLayout : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public frmConPORInStoLayout()
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
            this.plRow = new Smobiler.Core.Controls.Panel();
            this.Check = new Smobiler.Core.Controls.CheckBox();
            this.imgCon = new Smobiler.Core.Controls.Image();
            this.lblName = new Smobiler.Core.Controls.Label();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.numInStoQuant = new Smobiler.Core.Controls.Numeric();
            this.lblQuant = new Smobiler.Core.Controls.Label();
            // 
            // plRow
            // 
            this.plRow.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Check,
            this.imgCon,
            this.lblName,
            this.label1,
            this.label2,
            this.numInStoQuant,
            this.lblQuant});
            this.plRow.Name = "plRow";
            this.plRow.Size = new System.Drawing.Size(300, 60);
            this.plRow.Touchable = true;
            this.plRow.Press += new System.EventHandler(this.plRow_Press);
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(10, 20);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(25, 20);
            this.Check.ZIndex = 1;
            this.Check.CheckedChanged += new System.EventHandler(this.Check_CheckedChanged);
            // 
            // imgCon
            // 
            this.imgCon.BorderRadius = 15;
            this.imgCon.DataMember = "POROWID";
            this.imgCon.DisplayMember = "IMAGE";
            this.imgCon.Location = new System.Drawing.Point(45, 7);
            this.imgCon.Name = "imgCon";
            this.imgCon.Size = new System.Drawing.Size(45, 45);
            this.imgCon.SizeMode = Smobiler.Core.Controls.ImageSizeMode.Cover;
            // 
            // lblName
            // 
            this.lblName.DataMember = "CID";
            this.lblName.DisplayFormat = "耗材名称: {0}";
            this.lblName.DisplayMember = "NAME";
            this.lblName.Location = new System.Drawing.Point(100, 0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.lblName.Size = new System.Drawing.Size(200, 20);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.Text = "可入库数量";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 40);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(5F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.Text = "实际入库数";
            // 
            // numInStoQuant
            // 
            this.numInStoQuant.DisplayFormat = null;
            this.numInStoQuant.FontSize = 13F;
            this.numInStoQuant.Location = new System.Drawing.Point(200, 40);
            this.numInStoQuant.MinusIconColor = System.Drawing.Color.Black;
            this.numInStoQuant.Name = "numInStoQuant";
            this.numInStoQuant.Size = new System.Drawing.Size(100, 20);
            // 
            // lblQuant
            // 
            this.lblQuant.DisplayMember = "QUANTPURCHASED";
            this.lblQuant.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Center;
            this.lblQuant.Location = new System.Drawing.Point(200, 20);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(100, 20);
            // 
            // frmConPORInStoLayout
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.plRow});
            this.Size = new System.Drawing.Size(0, 60);
            this.Name = "frmConPORInStoLayout";

        }
        #endregion

        private Smobiler.Core.Controls.Panel plRow;
        internal Smobiler.Core.Controls.CheckBox Check;
        internal Smobiler.Core.Controls.Image imgCon;
        internal Smobiler.Core.Controls.Label lblName;
        private Smobiler.Core.Controls.Label label1;
        private Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Numeric numInStoQuant;
        private Smobiler.Core.Controls.Label lblQuant;
    }
}