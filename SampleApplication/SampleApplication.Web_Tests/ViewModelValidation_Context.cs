using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using NUnit.Framework;

namespace SampleApplication.Web_Tests
{
    public abstract class ViewModelValidation_Context<T> where T : new()
    {
        public T Target;
        public List<ValidationResult> ActualMessages;
        public bool Actual;

        [SetUp]
        public void SetUp()
        {
            Context();
            Because();
        }

        public virtual void Context()
        {
            Target = new T();
            ActualMessages = new List<ValidationResult>();
        }

        public virtual void Because()
        {
            var context = new ValidationContext(Target, null, null);
            Actual = Validator.TryValidateObject(Target, context, ActualMessages, true);
        }
    }
}
