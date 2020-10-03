using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
{
    class LineProperties
    {
        /// <summary>
        /// The absicca first point
        /// </summary>
        public double absiccaFirstPoint;
        public double ordinateFirstPoint;
        public double absiccaSecondPoint;
        public double ordinateSecondPoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="LineProperties"/> class.
        /// </summary>
        /// <param name="absiccaFirstPoint">The absicca first point.</param>
        /// <param name="ordinateFirstPoint">The ordinate first point.</param>
        /// <param name="absiccaSecondPoint">The absicca second point.</param>
        /// <param name="ordinateSecondPoint">The ordinate second point.</param>
        public LineProperties(double absiccaFirstPoint, double ordinateFirstPoint, double absiccaSecondPoint, double ordinateSecondPoint)
        {
            this.absiccaFirstPoint = absiccaFirstPoint;
            this.absiccaSecondPoint = absiccaSecondPoint;
            this.ordinateFirstPoint = ordinateFirstPoint;
            this.ordinateSecondPoint = ordinateSecondPoint;
        }

        /// <summary>
        /// Lengthes the of line.
        /// </summary>
        /// <param name="absiccaFirstPoint">The absicca first point.</param>
        /// <param name="ordinateFirstPoint">The ordinate first point.</param>
        /// <param name="absiccaSecondPoint">The absicca second point.</param>
        /// <param name="ordinateSecondPoint">The ordinate second point.</param>
        /// <returns></returns>
        public double lengthOfLine(double absiccaFirstPoint, double ordinateFirstPoint, double absiccaSecondPoint, double ordinateSecondPoint)
        {
            return Math.Sqrt(Math.Pow(absiccaSecondPoint - absiccaFirstPoint, 2) + Math.Pow(ordinateSecondPoint - ordinateFirstPoint, 2));
        }
         
        public double lengthOfLine(LineProperties lineProperties)
        {
            return Math.Sqrt(Math.Pow(lineProperties.absiccaSecondPoint -lineProperties.absiccaFirstPoint, 2) + Math.Pow(lineProperties.ordinateSecondPoint -lineProperties.ordinateFirstPoint, 2));
        }

        /// <summary>
        /// Lengthes the compare.
        /// In-BuiltComparator
        /// <param name="linePropertiesOne">The line properties one.</param>
        /// <param name="linePropertiesTwo">The line properties two.</param>
        /// <returns></returns>
        public int lengthCompare(LineProperties linePropertiesOne, LineProperties linePropertiesTwo)
        {
            if (lengthOfLine(linePropertiesOne) > lengthOfLine(linePropertiesTwo))
                return 1;
            else if (lengthOfLine(linePropertiesOne) < lengthOfLine(linePropertiesTwo))
                return -1;
            else
                return 0;
        }
    }
}
