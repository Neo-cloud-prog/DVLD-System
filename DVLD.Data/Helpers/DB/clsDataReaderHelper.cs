using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Data.Helpers.DB
{
    public class clsDataReaderHelper
    {
        public static T GetValueOrDefault<T>(object DBValue, T DefaultValue = default)
        {
            return DBValue == DBNull.Value || DBValue == null
                ? DefaultValue
                : (T)Convert.ChangeType(DBValue, typeof(T));
        }
    }
}
