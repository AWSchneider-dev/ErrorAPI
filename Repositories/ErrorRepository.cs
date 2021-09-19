using ErrorAPI.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErrorAPI.Repositories
{
  public class ErrorRepository : IError
  {
    private bool disposed = false;
    private IDisposable context; // NOT correct

    protected virtual void Dispose(bool disposing)
    {
      if (!this.disposed)
      {
        if (disposing)
        {
          context.Dispose();
        }
      }
      this.disposed = true;
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    public Error GetErrorByID(int ID)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Error> GetErrors()
    {
      throw new NotImplementedException();
    }

    public void PostError(string formName, Uri formUri, string formElements)
    {
      throw new NotImplementedException();
    }

    public void Save()
    {
      throw new NotImplementedException();
    }
  }
}
