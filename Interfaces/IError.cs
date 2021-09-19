using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorAPI.Interfaces.Repositories
{
  public interface IError : IDisposable
  {
    IEnumerable<Error> GetErrors();
    Error GetErrorByID(int ID);
    void PostError(string formName, Uri formUri, string formElements);
    void Save();
  }
}
