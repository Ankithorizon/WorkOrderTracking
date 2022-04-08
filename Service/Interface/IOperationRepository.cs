﻿using EF.Core.DTO;
using EF.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
    public interface IOperationRepository
    {
        List<Operation> GetAllWorkOrderOperations(int woid);
        List<SelectListItem> GetWorkOrderList();
        bool AddOperation(Operation operation);
        Operation GetOperation(int operationId);
        void EditOperation(Operation operation);
    }
}
