using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static RestoRite_Common.Constants.ErrorMessages;

namespace RestoRite_Common.Exceptions
{
    public class ModelStateException : Exception
    {
        public int StatusCode { get; set; }
        public List<string> Messages { get; set; }
        public Dictionary<string, object>? Metadata { get; set; }

        public ModelStateException(ModelStateDictionary modelState) : base(ExceptionMessage.INVALID_MODELSTATE)
        {
            Messages = GetErrorMessages(modelState);
        }

        private static List<string> GetErrorMessages(ModelStateDictionary modelState)
        {
            List<string> message = new();

            if (modelState != null && modelState.Count > 0)
            {
                foreach (KeyValuePair<string, ModelStateEntry> item in modelState)
                {
                    foreach (ModelError error in item.Value.Errors)
                    {
                        message.Add(error.ErrorMessage);
                    }
                }
            }
            return message;
        }

    }
}