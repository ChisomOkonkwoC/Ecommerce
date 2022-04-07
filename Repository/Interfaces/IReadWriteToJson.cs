﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReadWriteToJson
    {
        Task<List<T>> ReadJson<T>(string jsonFile);
        Task<bool> UpdateJson<T>(List<T> model, string jsonFile);
        Task<bool> WriteJson<T>(T model, string jsonFile);
    }
}