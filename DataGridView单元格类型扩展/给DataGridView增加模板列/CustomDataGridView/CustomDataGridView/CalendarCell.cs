using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CustomDataGridView
{
    /// <summary>
    /// ʱ��ؼ���Ԫ���࣬�̳��� DataGridView �ؼ��еĿɱ༭�ı���Ԫ��
    /// </summary>
    class CalendarCell : DataGridViewCell
    {

        public CalendarCell()
            : base()
        {
            //�������ݸ�ʽ
            this.Style.Format = "d";
        }

        public override void InitializeEditingControl(int rowIndex, object
            initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            // �޸ĳ�ʼ���ؼ�ֵ
            base.InitializeEditingControl(rowIndex, initialFormattedValue,
                dataGridViewCellStyle);
            CalendarEditingControl ctl =
                DataGridView.EditingControl as CalendarEditingControl;
            ctl.Value = (DateTime)this.Value;
        }

        public override Type EditType
        {
            get
            {
                // ���ر༭ʱ����ʾ�Ŀؼ�����
                return typeof(CalendarEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                //���ص�Ԫ�����ֵ������
                return typeof(DateTime);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                // ����Ĭ��ֵ
                return DateTime.Now;
            }
        }
    }
}
