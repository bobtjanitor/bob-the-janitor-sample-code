using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace SampleApplication.CustomValidators
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class GreaterThenAttribute : ValidationAttribute, IClientValidatable
    {
        public int BaseNumber { get; set; }

        public new bool IsValid(object value)
        {
            bool result = !(value == null || (int)value < BaseNumber);

            return result;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
                             {
                                 ErrorMessage = ErrorMessage,
                                 ValidationType = "Greater Then " + BaseNumber
                             };
        }
    }
}