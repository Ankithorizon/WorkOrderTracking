﻿using APICore.Auth.DTO;
using EF.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using EF.Core.DTO;

namespace APICore.Auth.Controllers
{

    [Authorize("Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class WorkOrderController : ControllerBase
    {
        private readonly IWorkOrderRepository _woRepo;
        private readonly ICustomerOrderRepository _custOrderRepo;
        private APIResponse _response;

        public WorkOrderController(ICustomerOrderRepository custOrderRepo,IWorkOrderRepository woRepo)
        {
            _custOrderRepo = custOrderRepo;
            _woRepo = woRepo;
        }

        [HttpGet]
        [Route("allWorkOrders")]
        public IActionResult GetAllWorkOrders()
        {
            _response = new APIResponse();
            try
            {
                // throw new Exception();

                var wos = _woRepo.GetAllWorkOrders();
                return Ok(wos);
            }
            catch (Exception ex)
            {
                return BadRequest("Server Error!");
            }
        }

        [HttpGet]
        [Route("getCustomerOrderDetails/{selectedCoId}")]
        public IActionResult GetCustomerOrderDetails(int selectedCoId)
        {
            var co = _custOrderRepo.GetCustomerOrder(selectedCoId);
            // var co = _custOrderRepo.GetCustomerOrder(0);
            return Ok(co);
        }

        [HttpGet]
        [Route("getCustomerOrders")]
        public IActionResult GetCustomerOrders()
        {
            var cos = _woRepo.GetCustomerOrderList();
            return Ok(cos);
        }

        [HttpPost]
        [Route("createWorkOrder")]
        public IActionResult CreateWorkOrder(WorkOrder wo)
        {
            _response = new APIResponse();
            try
            {
                // throw new Exception();

                if (ModelState.IsValid)
                {    
                    _woRepo.AddWorkOrder(wo);
                    _response.ResponseCode = 0;
                    _response.ResponseMessage = "Work-Order Added Successfully!";
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (WO_OP_Unique_Exception wouEx)
            {
                _response.ResponseCode = -1;
                _response.ResponseMessage = wouEx.Message;
            }
            catch (Exception ex)
            {
                _response.ResponseCode = -1;
                _response.ResponseMessage = "Server Error!";
            }
            return Ok(_response);
        }

        [HttpGet]
        [Route("getWorkOrder/{selectedWorkOrderId}")]
        public IActionResult GetWorkOrder(int selectedWorkOrderId)
        {
            var wo = _woRepo.GetWorkOrder(selectedWorkOrderId);
            return Ok(wo);
        }
    }
}

