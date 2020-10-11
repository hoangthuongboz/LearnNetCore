using System;
using System.Collections.Generic;
using System.Text;

namespace LearnNetCore.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SeoAlias { set; get; }
        string SeoKeywords { set; get; }
        string SeoDiscription { set; get; }

    }
}
