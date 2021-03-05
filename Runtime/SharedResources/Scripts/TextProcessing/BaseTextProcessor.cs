namespace Tilia.Visuals.Tooltip.TextProcessing
{
    using UnityEngine;

    /// <summary>
    /// A basis for text elements that can be set and processed.
    /// </summary>
    public abstract class BaseTextProcessor : MonoBehaviour
    {
        /// <summary>
        /// Sets the text of the associated text processor.
        /// </summary>
        /// <param name="text">The text to set.</param>
        public abstract void SetText(string text);
        /// <summary>
        /// Sets the color of the font on the associated text processor.
        /// </summary>
        /// <param name="color">The color to use.</param>
        public abstract void SetColor(Color color);
        /// <summary>
        /// Sets the size of the font on the associated text processor.
        /// </summary>
        /// <param name="size">The size to use.</param>
        public abstract void SetSize(float size);
    }
}