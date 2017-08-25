using System;

namespace EVE.ISXEVE.Services
{
  public interface IFrameService
  {
    void ScheduleAction(Action nextFn, Action doneFn = null);
  }
}