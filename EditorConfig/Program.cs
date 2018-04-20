using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorConfig
{
  class positiveInteger
  {
    public positiveInteger(int value)
    {
      Value = value;
    }

    private void someMethod()
    {
      Value = 42;

      int x = 42;

      int y = 42;
    }

    public int Value { get; set; }
  }


  class Program
  {
    static void Main(string[] args)
    {

    }
  }
}
