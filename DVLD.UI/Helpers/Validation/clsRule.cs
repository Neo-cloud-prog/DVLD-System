using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.UI.Helpers.Validation
{
    public class clsRule
    {
        public Func<bool> Condition { get; set; }
        public Action OnValid { get; set; }
        public Action<string> OnInvalid { get; set; }
        public string ErrorMessage { get; set; }

        public bool Validate()
        {
            if (Condition())
            {
                OnValid?.Invoke();
                return true;
            }
            else
            {
                OnInvalid?.Invoke(ErrorMessage);
                return false;
            }
        }
    }
}
