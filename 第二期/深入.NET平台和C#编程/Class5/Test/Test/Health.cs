using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test
{
    /// <summary>
    /// ����ײ���
    /// </summary>
    public partial class Health
    {

        #region �ֶ�
        //����
        private string name;

        //�����ϸ�б�
        private List<HealthItem> itemList = new List<HealthItem>();
        #endregion

        #region ����
        //����
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //�����ϸ�б�
        public List<HealthItem> ItemList
        {
            get { return itemList; }
            set { itemList = value; }
        }
        #endregion

        #region ����

        #endregion

    }
}
