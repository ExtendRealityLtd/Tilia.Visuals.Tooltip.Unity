namespace Tilia.Visuals.Tooltip.TextProcessing
{
    using UnityEngine;
    using UnityEngine.UI;

    /// <summary>
    /// A text processor that uses the Unity UI <see cref="Text"/> element for display.
    /// </summary>
    public class UITextProcessor : BaseTextProcessor
    {
        [Tooltip("The Text to render onto the tooltip.")]
        [SerializeField]
        private Text tooltipText;
        /// <summary>
        /// The <see cref="Text"/> to render onto the tooltip.
        /// </summary>
        public Text TooltipText
        {
            get
            {
                return tooltipText;
            }
            set
            {
                tooltipText = value;
            }
        }

        /// <inheritdoc />
        public override void SetColor(Color color)
        {
            TooltipText.color = color;
        }

        /// <inheritdoc />
        public override void SetSize(float size)
        {
            RectTransform rect = TooltipText.GetComponent<RectTransform>();
            TooltipText.fontSize = Mathf.RoundToInt(size / rect.localScale.x);
        }

        /// <inheritdoc />
        public override void SetText(string text)
        {
            TooltipText.text = text;
        }
    }
}