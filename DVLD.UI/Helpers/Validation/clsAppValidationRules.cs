
using System.Linq;
using System.Windows.Forms;
using DVLD.Core.Entities.User;
using DVLD.UI.Utils.Validation;
using DVLD.UI.Helpers.Session;
using DVLD.UI.Utils.Presentation;

namespace DVLD.UI.Helpers.Validation
{
    // Depends on the application context
    public class clsAppValidationRules
    {
        // Special Case:
        private static TextBox _TextBoxPassword = new TextBox();

        public enum enRuleType { FilledField, ValidePassword, ValideEmail, NationalNumberNotExist, PasswordShouldEqualToCurrentPassword, ConfirmPasswordShouldEqualToPassword, IsNumber }

        public static clsRule GetRule(TextBox TextBoxToApply, ErrorProvider ErrorProviderToOut, enRuleType RuleType)
        {
            switch (RuleType)
            {
                case enRuleType.FilledField:
                    return new clsRule
                    {
                        Condition = () => !string.IsNullOrWhiteSpace(TextBoxToApply.Text),
                        ErrorMessage = "this field is required",
                        OnValid = () => ErrorProviderToOut.SetError(TextBoxToApply, string.Empty),
                        OnInvalid = (Message) =>
                        {
                            clsPresentationUtils.SetErrorAndFocus(ref TextBoxToApply, ErrorProviderToOut, Message);
                        }
                    };
                case enRuleType.ValidePassword:
                    // Store Password to use it in ["enRuleType.PasswordShouldEqualToCurrentPassword"]
                    _TextBoxPassword = TextBoxToApply;
                    return new clsRule
                    {
                        Condition = () => clsValidateUtils.IsValidPassword(TextBoxToApply.Text),
                        ErrorMessage = "At least one lowercase letter and one uppercase letter and one digit one special character and minimum 8 characters",
                        OnValid = () => ErrorProviderToOut.SetError(TextBoxToApply, string.Empty),
                        OnInvalid = (Message) =>
                        {
                            clsPresentationUtils.SetErrorAndFocus(ref TextBoxToApply, ErrorProviderToOut, Message);
                        }
                    };
                case enRuleType.NationalNumberNotExist:
                    return new clsRule
                    {
                        Condition = () => clsPerson.Find(TextBoxToApply.Text) == null,
                        ErrorMessage = "This national number already exist",
                        OnValid = () => ErrorProviderToOut.SetError(TextBoxToApply, string.Empty),
                        OnInvalid = (Message) =>
                        {
                            clsPresentationUtils.SetErrorAndFocus(ref TextBoxToApply, ErrorProviderToOut, Message);
                        }

                    };
                case enRuleType.ValideEmail:
                    return new clsRule
                    {
                        Condition = () => clsValidateUtils.IsValideEmail(TextBoxToApply.Text),
                        ErrorMessage = "Email is not valide",
                        OnValid = () => ErrorProviderToOut.SetError(TextBoxToApply, string.Empty),
                        OnInvalid = (Message) =>
                        {
                            clsPresentationUtils.SetErrorAndFocus(ref TextBoxToApply, ErrorProviderToOut, Message);
                        }
                    };
                case enRuleType.PasswordShouldEqualToCurrentPassword:
                    return new clsRule
                    {
                        Condition = () => TextBoxToApply.Text == clsAppSession.CurrentUser.Password,
                        ErrorMessage = "Password does not match",
                        OnValid = () => ErrorProviderToOut.SetError(TextBoxToApply, string.Empty),
                        OnInvalid = (Message) =>
                        {
                            clsPresentationUtils.SetErrorAndFocus(ref TextBoxToApply, ErrorProviderToOut, Message);
                        }
                    };
                case enRuleType.ConfirmPasswordShouldEqualToPassword:
                    return new clsRule
                    {
                        Condition = () => TextBoxToApply.Text == _TextBoxPassword.Text,
                        ErrorMessage = "Does not match the new password",
                        OnValid = () => ErrorProviderToOut.SetError(TextBoxToApply, string.Empty),
                        OnInvalid = (Message) =>
                        {
                            clsPresentationUtils.SetErrorAndFocus(ref TextBoxToApply, ErrorProviderToOut, Message);
                        }
                    };
                default:
                    return new clsRule
                    {
                        Condition = () => !string.IsNullOrEmpty(TextBoxToApply.Text) && TextBoxToApply.Text.All(char.IsDigit),
                        ErrorMessage = "Please enter numeric value",
                        OnValid = () => ErrorProviderToOut.SetError(TextBoxToApply, string.Empty),
                        OnInvalid = (Message) =>
                        {
                            clsPresentationUtils.SetErrorAndFocus(ref TextBoxToApply, ErrorProviderToOut, Message);
                        }
                    };
            }
        } 
    }
}
