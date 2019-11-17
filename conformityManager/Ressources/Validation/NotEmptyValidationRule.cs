using System.Globalization;
using System.Windows.Controls;

namespace MoustakbalManager.Tools.ValidationRules
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            return string.IsNullOrWhiteSpace((value ?? "").ToString())
                ? new ValidationResult(false, "champ requis")
                : ValidationResult.ValidResult;
        }
    }
}
