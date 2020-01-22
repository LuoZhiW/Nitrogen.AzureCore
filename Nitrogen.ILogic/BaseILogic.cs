using Nitrogen.DataBase.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nitrogen.ILogic
{
    public interface BaseILogic<T> : IDataBase<T> where T : class
    {
    }
}
