using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace ClientManagement.Models.Validation
{
    public class MobilePhoneValidate : ValidationAttribute
    {
      
        
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (Regex.IsMatch(value.ToString(), "\\d{4}-\\d{6}") == true)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    var errorMsg = string.Format("手機格式必須是 09xx-xxxxxx!");

                    return new ValidationResult(errorMsg);

                }
            }
            else
            {
                return ValidationResult.Success;
            }
         
        }
    }
}