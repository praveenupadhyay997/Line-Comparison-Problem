using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    class LineProperties
    {
        public double absiccaFirstPoint;
        public double ordinateFirstPoint;
        public double absiccaSecondPoint;
        public double ordinateSecondPoint;

        public LineProperties(double absiccaFirstPoint, double ordinateFirstPoint, double absiccaSecondPoint, double ordinateSecondPoint)
        {
            this.absiccaFirstPoint = absiccaFirstPoint;
            this.absiccaSecondPoint = absiccaSecondPoint;
            this.ordinateFirstPoint = ordinateFirstPoint;
            this.ordinateSecondPoint = ordinateSecondPoint;
        }

     

    }
}
