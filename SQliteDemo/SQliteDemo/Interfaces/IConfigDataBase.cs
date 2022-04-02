using System;
using System.Collections.Generic;
using System.Text;

namespace SQliteDemo.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
