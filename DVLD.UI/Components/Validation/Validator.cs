using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DVLD.UI.Helpers.Validation;

namespace DVLD.UI.Components.Validation
{
    public partial class Validator : Component
    {
        private List<clsRule> _Rules = new List<clsRule>();

        public Validator()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        [Category("Validation")]
        [Description("List of validation rules")]
        public List<clsRule> Rules => _Rules;

        public Validator(IContainer Container)
        {
            Container.Add(this);

            InitializeComponent();
        }

        public void AddRule(clsRule Rule)
        {
            _Rules.Add(Rule);
        }

        public bool ValidateAll()
        {
            return _Rules.All(Rule => Rule.Validate());
        }

        public void Clear()
        {
            _Rules.Clear();
        }

        public void DeleteRule(int Index)
        {
            _Rules.RemoveAt(Index);
        }

        public void ValidateRuleIndex(int Index)
        {
            _Rules.ElementAt(Index).Validate();
        }
    }
}
