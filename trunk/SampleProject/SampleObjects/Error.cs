using System.Collections.ObjectModel;

namespace SampleObjects
{
    /// <summary>
    /// an object to hold errors
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>The message.</value>
        public string Message { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error"/> class.
        /// </summary>
        /// <param name="error">The error.</param>
        public Error(string error)
        {
            Message = error;
            
        }
    }

    /// <summary>
    /// A Collection of error objects
    /// </summary>
    public class Errors : Collection<Error>
    {
        /// <summary>
        /// Adds the specified new error.
        /// </summary>
        /// <param name="newError">The new error.</param>
        public void Add(string newError)
        {
            Error myError = new Error(newError);
            Add(myError);
        }

        /// <summary>
        /// Adds the specified new errors.
        /// </summary>
        /// <param name="newErrors">The new errors.</param>
        public void Add(Errors newErrors)
        {
            for (int i = 0; i < newErrors.Count; i++)
            {
                Add(newErrors[i]);
            }            
        }
    }
}
