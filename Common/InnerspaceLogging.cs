using System;
using InnerSpaceAPI;

namespace EVE.ISXEVE.Common
{
  public class InnerspaceLogging<T> : ILogging
  {
    private readonly string currentTypeName;

    public InnerspaceLogging()
    {
      currentTypeName = typeof (T).Name;
    }

    public void LogException(Exception e, string message)
    {
      InnerSpace.Echo(string.Format("{0}| {1} - {2}\n{3}", DateTime.Now, currentTypeName, message, e.StackTrace));
    }

    public void LogInfo(string message)
    {
      InnerSpace.Echo(string.Format("{0}| {1} - {2}", DateTime.Now, currentTypeName, message));
    }
  }
}