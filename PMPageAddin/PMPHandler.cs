using System;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.swpublished;

namespace PMPageAddin
{
    /// <summary>
    /// ����ҳ���¼���Ӧ
    /// </summary>
    public class PMPHandler : IPropertyManagerPage2Handler8
    {
        #region ����
        ISldWorks iSwApp;
        SwAddin userAddin;
        swPropertyManagerPageCloseReasons_e swPMPageCloseReson;
        #endregion

        #region ���캯��
        public PMPHandler(SwAddin addin)
        {
            userAddin = addin;
            iSwApp = (ISldWorks)userAddin.SwApp;
        }
        #endregion

        #region ���ȷ��ȡ���ر���Ӧ
        /// <summary>
        /// ȷ����ťִ�еĶ���
        /// </summary>
        public void OKClick()
        {

        }
        /// <summary>
        /// �رհ�ťִ�еĶ���
        /// </summary>
        public void CloseClick()
        {

        }
        /// <summary>
        /// ȡ���¼�
        /// </summary>
        public void CancelClick()
        {

        }
        //Implement these methods from the interface
        /// <summary>
        /// ����ҳ�رպ�ִ�еķ���
        /// </summary>
        public void AfterClose()
        {
            //This function must contain code, even if it does nothing, to prevent the
            //.NET runtime environment from doing garbage collection at the wrong time.
            int IndentSize;
            IndentSize = System.Diagnostics.Debug.IndentSize;
            System.Diagnostics.Debug.WriteLine(IndentSize);
            //ȷ���ر���ʽ
            switch (swPMPageCloseReson)
            {
                case swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_UnknownReason:
                    break;
                case swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_Okay:
                    OKClick();
                    break;
                case swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_Cancel:
                    CancelClick();
                    break;
                case swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_ParentClosed:
                    break;
                case swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_Closed:
                    CloseClick();
                    break;
                case swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_UserEscape:
                    break;
                case swPropertyManagerPageCloseReasons_e.swPropertyManagerPageClose_Apply:
                    break;
            }
        }
        public void OnClose(int reason)
        {
            //This function must contain code, even if it does nothing, to prevent the
            //.NET runtime environment from doing garbage collection at the wrong time.
            int IndentSize;
            IndentSize = System.Diagnostics.Debug.IndentSize;
            System.Diagnostics.Debug.WriteLine(IndentSize);
            swPMPageCloseReson = (swPropertyManagerPageCloseReasons_e)reason;
        }

        #endregion

        #region ��ѡ��Combobox��Ӧ�¼�
        public void OnComboboxEditChanged(int id, string text)
        {

        }
        public void OnComboboxSelectionChanged(int id, int item)
        {

        }
        #endregion

        #region GroupBox�ؼ���Ӧ�¼�
        public void OnGroupCheck(int id, bool status)
        {

        }
        public void OnGroupExpand(int id, bool status)
        {

        }

        #endregion

        #region ��ҳPMPage��Ӧ
        public bool OnNextPage()
        {
            return true;
        }
        public bool OnPreviousPage()
        {
            return true;
        }
        #endregion

        #region ѡ����¼�

        public void OnSelectionboxCalloutCreated(int id)
        {

        }

        public void OnSelectionboxCalloutDestroyed(int id)
        {

        }

        public void OnSelectionboxFocusChanged(int id)
        {

        }

        public void OnSelectionboxListChanged(int id, int item)
        {

        }
        #endregion

        #region �����ؼ���Ӧִ�еķ���
        /// <summary>
        /// ��ѡCheckBox
        /// </summary>
        /// <param name="id"></param>
        /// <param name="status"></param>
        public void OnCheckboxCheck(int id, bool status)
        {

        }

        public int OnActiveXControlCreated(int id, bool status)
        {
            return -1;
        }
        /// <summary>
        /// ��ť�ؼ�����
        /// </summary>
        /// <param name="id"></param>
        public void OnButtonPress(int id)
        {

        }

        public void OnListboxSelectionChanged(int id, int item)
        {

        }
        public void OnNumberboxChanged(int id, double val)
        {

        }

        public void OnOptionCheck(int id)
        {

        }

        public bool OnHelp()
        {
            return true;
        }
        public void OnTextboxChanged(int id, string text)
        {

        }

        public void AfterActivation()
        {

        }

        public bool OnKeystroke(int Wparam, int Message, int Lparam, int Id)
        {
            return true;
        }

        public void OnPopupMenuItem(int Id)
        {

        }

        public void OnPopupMenuItemUpdate(int Id, ref int retval)
        {

        }

        public bool OnPreview()
        {
            return true;
        }

        public void OnSliderPositionChanged(int Id, double Value)
        {

        }

        public void OnSliderTrackingCompleted(int Id, double Value)
        {

        }

        public bool OnSubmitSelection(int Id, object Selection, int SelType, ref string ItemText)
        {
            return true;
        }

        public bool OnTabClicked(int Id)
        {
            return true;
        }

        public void OnUndo()
        {

        }

        public void OnWhatsNew()
        {

        }


        public void OnGainedFocus(int Id)
        {

        }

        public void OnListboxRMBUp(int Id, int PosX, int PosY)
        {

        }

        public void OnLostFocus(int Id)
        {

        }

        public void OnRedo()
        {

        }

        public int OnWindowFromHandleControlCreated(int Id, bool Status)
        {
            return 0;
        }
        #endregion

    }
}
