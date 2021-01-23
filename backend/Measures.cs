using System;

namespace backend
{
  public class Measures
  {
    public string Id { get; set; }
    public float SystolicPressure { get; set; }
    public float DiastolicPressure { get; set; }
    public DateTime DateTime { get; set; }
  }
}