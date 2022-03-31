﻿using EF.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IPartRepository
    {
        Part GetPart(int partId);
        List<Part> GetAllParts();
    }
}
