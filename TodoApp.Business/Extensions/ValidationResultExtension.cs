using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Common.ResponseObjects;

namespace TodoApp.Business.Extensions
{
    public static class ValidationResultExtension
    {
        public static List<CustomValidationError> ConverToCustomValidationError(this ValidationResult validationResult)
        {
            List<CustomValidationError> errors = new();

            foreach (var error in validationResult.Errors)
            {
                errors.Add(new()
                {
                    ErrorMessage = error.ErrorMessage,
                    PropertyName = error.PropertyName
                });

            }
            return errors;
        }
    }
}
