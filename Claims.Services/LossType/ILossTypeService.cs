using System;
using System.Collections.Generic;
using System.Text;
using Claims.Core.Domain;
namespace Claims.Services.LossType
{
    public interface ILossTypeService
    {
         IEnumerable<LossTypes> GetAllLossTypes();
    }
}
