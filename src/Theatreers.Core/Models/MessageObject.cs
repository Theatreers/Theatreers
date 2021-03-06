﻿using System;
using Theatreers.Core.Abstractions;

namespace Theatreers.Core.Models
{
  public class MessageHeaders
  {
    public string RequestCorrelationId { get; set; } = Guid.NewGuid().ToString();
    public DateTime RequestCreatedAt { get; set; } = DateTime.Now;
  }


//  Test Comment- To test which builds will trigger
  public class MessageObject<T> where T : IStorableValidatable
  {
    public MessageHeaders Headers { get; set; }
    public T Body { get; set; }
  }
}
