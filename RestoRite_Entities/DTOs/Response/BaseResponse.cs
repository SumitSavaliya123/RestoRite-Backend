using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoRite_Entities.DTOs.Response
{
    public class BaseResponse
    {
        public int StatusCode { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}