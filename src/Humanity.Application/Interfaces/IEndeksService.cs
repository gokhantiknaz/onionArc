﻿using Humanity.Application.Models.DTOs.firma;
using Humanity.Application.Models.Requests;
using Humanity.Application.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity.Application.Interfaces
{
    public interface IEndeksService
    {
        Task<List<SaatlikEndeksRes>> GetAboneSaatlikEndeks(int aboneId, string donem);

        Task<SaatlikEndeksRes> Create(List<SaatlikEndeksRequest> req);

        Task<List<AylikEndeksRes>> GetAboneDonemEndeks(int aboneId, string donem);
    }
}
