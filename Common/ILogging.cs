using System;

namespace EVE.ISXEVE.Common
{
  public interface ILogging
  {
    void LogException(Exception e, string message);
    void LogInfo(string message);
  }
}