namespace Tilia.Visuals.Tooltip
{
    using Malimbe.MemberChangeMethod;
    using Malimbe.MemberClearanceMethod;
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Data.Attribute;

    /// <summary>
    /// The public interface for the Tooltip prefab.
    /// </summary>
    public class TooltipFacade : MonoBehaviour
    {
        #region Source Settings
        /// <summary>
        /// The origin to draw the tooltip line from.
        /// </summary>
        [Serialized, Cleared]
        [field: Header("Source Settings"), DocumentedByXml]
        public GameObject LineOrigin { get; set; }
        /// <summary>
        /// The source that the tooltip will face towards.
        /// </summary>
        [Serialized, Cleared]
        [field: DocumentedByXml]
        public GameObject FacingSource { get; set; }
        #endregion

        #region Text Settings
        /// <summary>
        /// The text to display on the tooltip.
        /// </summary>
        [Serialized]
        [field: Header("Text Settings"), DocumentedByXml]
        public string TooltipText { get; set; } = "Tooltip Text";
        /// <summary>
        /// The font size for the text of the tooltip.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public int FontSize { get; set; } = 30;
        /// <summary>
        /// The font color for the text of the tooltip.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public Color FontColor { get; set; } = Color.black;
        #endregion

        #region Background Settings
        /// <summary>
        /// The color for the outer background of the tooltip.
        /// </summary>
        [Serialized]
        [field: Header("Background Settings"), DocumentedByXml]
        public Color OuterBackgroundColor { get; set; } = Color.black;
        /// <summary>
        /// The color for the inner background of the tooltip.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public Color InnerBackgroundColor { get; set; } = Color.white;
        #endregion

        #region Reference Settings
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public TooltipConfigurator Configuration { get; protected set; }
        #endregion

        /// <summary>
        /// Called after <see cref="LineOrigin"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(LineOrigin))]
        protected virtual void OnAfterLineOriginChange()
        {
            Configuration.ConfigureLine();
        }

        /// <summary>
        /// Called after <see cref="TooltipText"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(TooltipText))]
        protected virtual void OnAfterTooltipTextChange()
        {
            Configuration.ConfigureText();
        }

        /// <summary>
        /// Called after <see cref="FontSize"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(FontSize))]
        protected virtual void OnAfterFontSizeChange()
        {
            Configuration.ConfigureText();
        }

        /// <summary>
        /// Called after <see cref="FontColor"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(FontColor))]
        protected virtual void OnAfterFontColorChange()
        {
            Configuration.ConfigureText();
        }

        /// <summary>
        /// Called after <see cref="OuterBackgroundColor"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(OuterBackgroundColor))]
        protected virtual void OnAfterOuterBackgroundColorChange()
        {
            Configuration.ConfigureBackground();
        }

        /// <summary>
        /// Called after <see cref="InnerBackgroundColor"/> has been changed.
        /// </summary>
        [CalledAfterChangeOf(nameof(InnerBackgroundColor))]
        protected virtual void OnAfterInnerBackgroundColorChange()
        {
            Configuration.ConfigureBackground();
        }
    }
}