using System;
using System.Collections.Generic;

namespace ObjectValidator.Domain.ConfirmedViolationCreated
{
  public class ConfirmedViolationCreated
  {
    public Guid Id { get; set; }
    public ICollection<PotentialViolationCreated> PotentialViolations { get; set; }
  }
}
