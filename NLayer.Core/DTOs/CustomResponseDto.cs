﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore]//bir API yanıtının JSON olarak dönüştürülmesi sırasında, istemciye belirli bir özelliği göndermek istemiyorsanız,
                    //bu özelliği[JsonIgnore] ile işaretleyebilirsiniz.
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Success(int statusCode, T data)
        {
            return new CustomResponseDto<T> { Data = data, StatusCode = statusCode};
        }
        public static CustomResponseDto<T> Success(int statusCode)
        {
            return new CustomResponseDto<T> {StatusCode = statusCode};
        }
        public static CustomResponseDto<T> Fail(List<string>errors, int statusCode)
        {
            return new CustomResponseDto<T> {StatusCode = statusCode, Errors=errors};
        }
        public static CustomResponseDto<T> Fail(string error, int statusCode)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };
        }
    }
}
