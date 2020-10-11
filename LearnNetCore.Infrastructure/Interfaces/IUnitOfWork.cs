using System;
using System.Collections.Generic;
using System.Text;

namespace LearnNetCore.Infrastructure.Interfaces
{
    public interface IUnitOfWork: IDisposable 
    {
        //Call save change from DbContext
        void Commit();
    }
}
