
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food
{
    public class Statistical
    {
        private static Statistical instance;

        public static Statistical Instance
        {
            get { if (instance == null) instance = new Statistical(); return Statistical.instance; }
            private set { Statistical.instance = value; }
        }
        public DataTable GetBillListByDate(DateTime checkDateStart, DateTime checkDateFinish)
        {
            return DataProvider.Instance.ExecuteQuery("exec USP_GetListBillByDate @CheckDateStart , @CheckDateFinish ", new object[] { checkDateStart, checkDateFinish });
        }
        public DataTable GetProductsSoldTheMost()
        {
            return DataProvider.Instance.ExecuteQuery("exec GetProductsSoldTheMost");
        }
    }
}
