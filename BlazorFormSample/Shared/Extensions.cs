using System.Linq;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorFormSample.Shared
{
    public static class Extensions
    {
        public static string BootstrapFieldCssClass(this EditContext editContext, in FieldIdentifier fieldIdentifier)
        {
            var isValid = !editContext.GetValidationMessages(fieldIdentifier).Any();
            if (editContext.IsModified(fieldIdentifier))
            {
                return isValid ? "modified" : "modified is-invalid";
            }
            else
            {
                return isValid ? string.Empty : "is-invalid";
            }
        }
    }
}
