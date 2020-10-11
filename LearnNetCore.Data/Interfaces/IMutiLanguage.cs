using System;
using System.Collections.Generic;
using System.Text;

namespace LearnNetCore.Data.Interfaces
{
    public interface IMutiLanguage<T>
    {
        T LanguageId { set; get; }
    }
}
