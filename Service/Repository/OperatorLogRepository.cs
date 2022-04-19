﻿using EF.Core;
using EF.Core.DTO;
using EF.Core.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Repository
{
    public class OperatorLogRepository : IOperatorLogRepository
    {
        private readonly WorkOrderTrackingContext appDbContext;
        public OperatorLogRepository(WorkOrderTrackingContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public List<SelectListItem> GetOperationList(int woid)
        {
            List<SelectListItem> datas = new List<SelectListItem>();

            foreach (var op in appDbContext.Operations.Where(x=>x.WorkOrderId==woid))
            {
                datas.Add(new SelectListItem()
                {
                    Value = op.OperationId.ToString(),
                    Text = "[ OP# " + op.OperationNumber + " ] "
                });
            }
            return datas;
        }

        public List<SelectListItem> GetWorkOrderList()
        {
            List<SelectListItem> datas = new List<SelectListItem>();

            foreach (var wo in appDbContext.WorkOrders.Include(x=>x.CustomerOrder))
            {
                datas.Add(new SelectListItem()
                {
                    Value = wo.WorkOrderId.ToString(),
                    Text = "[ WO# " + wo.WorkOrderId + " ] - " + "[ CUST_ORD# " + wo.CustomerOrderId + " - " + wo.CustomerOrder.CustomerName + " ]"                    
                });
            }
            return datas;
        }

        public void AddOperatorLog(OperatorActivity operatorActivity)
        {
            var op_ = appDbContext.Operations
                           .Where(x => x.OperationId == operatorActivity.OperationId).FirstOrDefault();

            if (operatorActivity.OperationStatus == OperationStatusForOperator.Start_Running)
            {
                // start
                operatorActivity.OpPauseRunTime = null;
                operatorActivity.OpQtyDone = 0;
            }
            else
            {
                // pause
                operatorActivity.OpStartRunTime = null;
            }
            operatorActivity.OperationNumber = (OperationNumber)op_.OperationNumber;

            operatorActivity.OperatorId = 1;

            appDbContext.OperatorActivities.Add(operatorActivity);
            appDbContext.SaveChanges();
        }

    }
}
