using System.ComponentModel.DataAnnotations;

namespace Angioletti.Models
{
    public class maxLastYear : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            int year = (int)value;

            if(year >= DateTime.Today.Year) return false;

            return true;    
        }

    }
}
