﻿using AutoMapper;
using System;

namespace WebApiTest.Utility
{
    public static class AutoMapperExtension
    {
        /// <summary>
        /// Entity转DTO
        /// </summary>
        public static T ToDTO<T>(this object source)
        {
            return Mapper.Map<T>(source);
        }
    }
}
