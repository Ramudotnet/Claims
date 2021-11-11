using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Claims.Core.Domain;
using ClaimSolution.DBContext;

namespace ClaimSolution.Services.LossType
{
    public class LossTypeService : ILossTypeService
    {
        public dynamic GetAllLossTypes()
        {
            try
            {
                InterviewEntities objDbContext = new InterviewEntities();

                var allLossTypeResult = objDbContext.LossTypes.Select(x => new LossTypes { LossTypeId = x.LossTypeId, LossTypeCode = x.LossTypeCode, LossTypeDescription = x.LossTypeDescription, Status = x.Active ==true ? "InActive" : "Active" }).ToList();

                return allLossTypeResult;
            }
            catch (Exception Exception)
            {
                //Log the exception here 

                throw Exception;

            }

        }
    }
}
