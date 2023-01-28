using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        [JsonIgnore]
        public int StatusCode { get; set; }
        public T Data { get; set; }
        public ExceptionDto Exception { get; set; }




        //Success with Data
        public static CustomResponseDto<T> Success(int statusCode,T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode };
        }
        //Success with No Data
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> {StatusCode = statusCode };
        }

        //Fail with Exception
        public static CustomResponseDto<T> Fail(int statusCode, ExceptionDto exception)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Exception = exception };
        }





    }
}
