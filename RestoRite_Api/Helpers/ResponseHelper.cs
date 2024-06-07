using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using RestoRite_Entities.DTOs.Response;
using RestoRite_Common.Constants;

namespace RestoRite_Api.Helpers
{
    public class ResponseHelper
    {
        public static IActionResult CreatedResponse<T>(T? data, string message)
        {
            ApiResponse<T> result = new()
            {
                StatusCode = (int)HttpStatusCode.Created,
                Message = message,
                Data = data,
                Success = true,
            };
            return new ObjectResult(result) { StatusCode = (int)HttpStatusCode.Created };
        }

        public static IActionResult SuccessResponse<T>(T? data, string message = SystemConstants.SUCCESS)
        {
            ApiResponse<T> result = new()
            {
                StatusCode = (int)HttpStatusCode.OK,
                Message = message,
                Data = data,
                Success = true,
            };
            return new ObjectResult(result) { StatusCode = (int)HttpStatusCode.OK };

        }

        public static IActionResult CreatePageResponse<T>(IEnumerable<T> data, int pageNumber, int pageSize, int totalPage, long totalRecords = 0)
        {
            PageResponse<T> result = new(data, pageNumber, pageSize, totalPage, totalRecords);
            ApiResponse<PageResponse<T>> response = new()
            {
                Success = true,
                Data = result,
                StatusCode = (int)HttpStatusCode.OK,
            };
            return new ObjectResult(response) { StatusCode = (int)HttpStatusCode.OK };
        }
    }
}