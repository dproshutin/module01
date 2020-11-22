//-----------------------------------------------------------------------
// <copyright file="Elem.cs" company="Epam External Training">
//     Company copyright tag.
// </copyright>
// <author>Dmitry Proshutin</author>
//-----------------------------------------------------------------------

namespace Module01
{
    /// <summary>
    /// The class for Elem objects
    /// </summary>
    public class Elem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Elem" /> class.
        /// </summary>
        /// <param name="index">Index as an integer number</param>
        /// <param name="parameter">Calculated condition as an integer number</param>
        public Elem(int index, int parameter)
        {
            this.ElemIndex = index;
            this.ElemParameter = parameter;
        }

        /// <summary>
        /// Gets or sets ElemIndex property
        /// </summary>
        public int ElemIndex { get; set; }

        /// <summary>
        /// Gets or sets ElemParameter property
        /// </summary>
        public int ElemParameter { get; set; }
    }
}
