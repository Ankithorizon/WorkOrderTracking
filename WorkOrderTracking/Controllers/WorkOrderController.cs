﻿using EF.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderTracking.Models;

namespace WorkOrderTracking.Controllers
{
    public class WorkOrderController : Controller
    {
        private readonly ILogger<WorkOrderController> _logger;
        private readonly IWorkOrderRepository _wOrderRepo;
        private readonly ICustomerOrderRepository _custOrderRepo;

        public WorkOrderController(ICustomerOrderRepository custOrderRepo, IWorkOrderRepository wOrderRepo  ,ILogger<WorkOrderController> logger)
        {
            _custOrderRepo = custOrderRepo;
            _wOrderRepo = wOrderRepo;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<DataTableResponse> GetAllWorkOrders()
        {
            var wOrders = _wOrderRepo.GetAllWorkOrders();

            return new DataTableResponse
            {
                RecordsTotal = wOrders.Count(),
                RecordsFiltered = 10,
                // Data = wOrders.ToArray()
                Data = wOrders.ToArray()
            };
        }

        [HttpGet]
        public ActionResult GetCustomerOrderDetails(int id)
        {
            var co = _custOrderRepo.GetCustomerOrder(id);
            return PartialView("_CustomerOrderDetails", co);
        }
    }
}
