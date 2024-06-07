using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoRite_Entities.DTOs.Response
{
    public class ApiResponse<T> : BaseResponse
    {
        public T? Data { get; set; }
    }
}