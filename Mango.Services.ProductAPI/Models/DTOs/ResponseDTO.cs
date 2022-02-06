﻿namespace Mango.Services.ProductAPI.Models.DTOs
{
    public class ResponseDTO
    {
        public bool IsSuccess { get; set; }
        public string DisplayMessage { get; set; }

        public List<string> ErrorMessages { get; set; }

        public object Result { get; set; }
    }
}
