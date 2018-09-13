using System;
using Smobiler.Core.Controls;
using SMOWMS.DTOs.InputDTO;
using SMOWMS.UI.AssetsManager;

namespace SMOWMS.UI.Layout
{
    ////ToolboxItem���ڿ����Ƿ������Զ���ؼ��������䣬true���ӣ�false������
    //[System.ComponentModel.ToolboxItem(true)]
    partial class frmOrderCreateSNLayout : Smobiler.Core.Controls.MobileUserControl
    {
        /// <summary>
        /// �õ�ѡ��������
        /// </summary>
        /// <returns></returns>
        public AssetsOrderRow getData()
        {
            AssetsOrderRow Data = new AssetsOrderRow();
            Data.IMAGE = imgAss.BindDisplayValue.ToString();
            Data.ASSID = lblName.BindDataValue.ToString();
            Data.SN = lblSN.BindDataValue.ToString();
            Data.QTY = 1;
            Data.STATUS = 0;
            return Data;
        }
        private void plRow_LongPress(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("�Ƿ�ɾ��������?", "ϵͳ����", MessageBoxButtons.YesNo, (object sender1, MessageBoxHandlerArgs args) =>
                {
                    try
                    {
                        if (args.Result == ShowResult.Yes)     //ɾ��������
                        {
//                            ((frmAssTransferCreate)Form).ReMoveAssSN(lblName.BindDataValue.ToString(), lblSN.BindDataValue.ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        Form.Toast(ex.Message);
                    }
                });
            }
            catch (Exception ex)
            {
                Form.Toast(ex.Message);
            }
        }
    }
}