using System;
using System.Collections.Generic;
using System.Text;
using Claims.Core.Domain;
namespace ClaimSolution.Services.LossType
{
    public interface ILossTypeService
    {
        dynamic GetAllLossTypes();
    }
}
