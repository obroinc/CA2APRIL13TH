using System;
using System.ComponentModel.DataAnnotations;

namespace memberEAD.Model
{
    


        public class DOBAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object DOB, ValidationContext validationContext)
            {
                Member mem = (Member)validationContext.ObjectInstance;

            //converting dob  so calc can take place
            DateTime DOBDate = Convert.ToDateTime(mem.DOB);
            

                if (DateTime.Now.Year-DOBDate.Year < 18)
                {
                return new ValidationResult(GetErrorMessage());
                }
                    return ValidationResult.Success;
                
            }

        private string GetErrorMessage()
        {
            return $"You must be over 18";
        }





        }

    
}