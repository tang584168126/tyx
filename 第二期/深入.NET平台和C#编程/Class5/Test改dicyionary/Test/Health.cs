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

        //�����Ŀ�б�
        private Dictionary<string, HealthItem> itemDic = new Dictionary<string, HealthItem>();

        #endregion

        #region ����
        //����
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //�����Ŀ�б�
        public Dictionary<string, HealthItem> ItemDic
        {
            get { return itemDic; }
            set { itemDic = value; }
        }
        #endregion

        #region ����

        #endregion

    }
}
