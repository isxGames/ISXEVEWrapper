using System;

namespace EVE.ISXEVE.Services
{
  public class FrameAction
  {
     public Action ToExecuteFn { get; set; }
     public Action DoneFn { get; set; }
  }
}