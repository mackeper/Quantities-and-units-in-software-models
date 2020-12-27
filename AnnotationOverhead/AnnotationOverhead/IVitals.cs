using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationOverhead
{
  interface IVitals
  {
    string HeightString();
    string WeightString();
    string BodySurfaceAreaString();
    string BodyMassIndexString();
  }
}
