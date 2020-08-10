using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CustomDataGridView
{
    /// <summary>
    /// ʱ��ؼ��༭�࣬�̳��� DateTimePickerʱ��ؼ�����ʵ�� DataGridView �ĵ�Ԫ���ڵĿؼ��ĳ������ܽӿ�
    /// </summary>
    class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl()
        {
            this.Format = DateTimePickerFormat.Short;
        }

        //��ȡ�����ÿؼ���ֵ
        public object EditingControlFormattedValue
        {
            get
            {
                return this.Value.ToShortDateString();
            }
            set
            {
                String newValue = value as String;
                if (newValue != null)
                {
                    this.Value = DateTime.Parse(newValue);
                }
            }
        }

        //��ñ༭ʱ�ؼ�ֵ
        public object GetEditingControlFormattedValue(
            DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        //���ÿؼ�������ʽ
        public void ApplyCellStyleToEditingControl(
            DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.CalendarForeColor = dataGridViewCellStyle.ForeColor;
            this.CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        //��ȡ�����õ�ǰ�ؼ�������
        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        // ���ÿؼ��õ�����ʱ��Ӧ���̰���������true�ǵ�ǰ�ؼ���Ӧ����������false�ǵ�ǰDataGridView��Ӧ����
        public bool EditingControlWantsInputKey(
            Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp:
                    return true;
                default:
                    return false;
            }
        }

        // ׼���༭�ؼ��õ�����
        public void PrepareEditingControlForEdit(bool selectAll)
        {
            
        }

        // ���ؼ�ֵ�Ż�ʱ����������
        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }

        // ��ȡ�����õ�ǰ�ؼ�����DataGridView����
        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        // ��ȡ�����õ�ǰ�༭�ؼ�ֵ�޸�״̬
        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }

        // ��ȡ�ĵ�ǰ�༭���Դ
        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }

        //��дDateTimePicker.OnValueChanged��������ֵ�ı�ʱ���õ�ǰDataGridViewΪ�޸�״̬��
        protected override void OnValueChanged(EventArgs eventargs)
        {
            // ֪ͨ��ǰ DataGridView �ڵ�Ԫ�����иı�
            valueChanged = true;
            this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
}
