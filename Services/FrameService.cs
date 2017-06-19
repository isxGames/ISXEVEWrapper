using System;
using System.Collections.Generic;
using EVE.ISXEVE.Common;
using LavishScriptAPI;

namespace EVE.ISXEVE.Services
{
  public class FrameService : IFrameService
  {
    private readonly InnerspaceLogging<FrameService> logger;

    public FrameService()
    {
      ActionList = new Queue<FrameAction>();
      logger = new InnerspaceLogging<FrameService>();

      LavishScript.Events.AttachEventTarget(LavishScript.Events.RegisterEvent("OnFrame"), ExecuteOnFrame);
    }

    private Queue<FrameAction> ActionList { get; set; }

    public void ScheduleAction(Action nextFn, Action doneFn = null)
    {
      var newAction = new FrameAction { ToExecuteFn = nextFn, DoneFn = doneFn };

      ActionList.Enqueue(newAction);
    }

    private void ExecuteOnFrame(object sender, LSEventArgs args)
    {
      if (ActionList.Count > 0)
      {
        var frameAction = ActionList.Dequeue();

        try
        {
          frameAction.ToExecuteFn();
          if (frameAction.DoneFn != null)
          {
            frameAction.DoneFn();
          }
        }
        catch (Exception e)
        {
          logger.LogException(e, "ExecuteOnFrame");
        }
      }
    }
  }
}