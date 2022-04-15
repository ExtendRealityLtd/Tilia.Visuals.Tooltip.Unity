namespace Tilia.Visuals.Tooltip
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;

    /// <summary>
    /// The public interface for the Tooltip prefab.
    /// </summary>
    public class TooltipFacade : MonoBehaviour
    {
        #region Source Settings
        [Header("Source Settings")]
        [Tooltip("The origin to draw the tooltip line from.")]
        [SerializeField]
        private GameObject lineOrigin;
        /// <summary>
        /// The origin to draw the tooltip line from.
        /// </summary>
        public GameObject LineOrigin
        {
            get
            {
                return lineOrigin;
            }
            set
            {
                lineOrigin = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterLineOriginChange();
                }
            }
        }
        [Tooltip("The source that the tooltip will face towards.")]
        [SerializeField]
        private GameObject facingSource;
        /// <summary>
        /// The source that the tooltip will face towards.
        /// </summary>
        public GameObject FacingSource
        {
            get
            {
                return facingSource;
            }
            set
            {
                facingSource = value;
            }
        }
        #endregion

        #region Text Settings
        [Header("Text Settings")]
        [Tooltip("The source that the tooltip will face towards.")]
        [SerializeField]
        [TextArea]
        private string tooltipText = "Tooltip Text";
        /// <summary>
        /// The text to display on the tooltip.
        /// </summary>
        public string TooltipText
        {
            get
            {
                return tooltipText;
            }
            set
            {
                tooltipText = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTooltipTextChange();
                }
            }
        }
        [Tooltip("The font size for the text of the tooltip.")]
        [SerializeField]
        private int fontSize = 30;
        /// <summary>
        /// The font size for the text of the tooltip.
        /// </summary>
        public int FontSize
        {
            get
            {
                return fontSize;
            }
            set
            {
                fontSize = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterFontSizeChange();
                }
            }
        }
        [Tooltip("The font color for the text of the tooltip.")]
        [SerializeField]
        private Color fontColor = Color.black;
        /// <summary>
        /// The font color for the text of the tooltip.
        /// </summary>
        public Color FontColor
        {
            get
            {
                return fontColor;
            }
            set
            {
                fontColor = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterFontColorChange();
                }
            }
        }
        #endregion

        #region Background Settings
        [Header("Background Settings")]
        [Tooltip("The color for the outer background of the tooltip.")]
        [SerializeField]
        private Color outerBackgroundColor = Color.black;
        /// <summary>
        /// The color for the outer background of the tooltip.
        /// </summary>
        public Color OuterBackgroundColor
        {
            get
            {
                return outerBackgroundColor;
            }
            set
            {
                outerBackgroundColor = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterOuterBackgroundColorChange();
                }
            }
        }
        [Tooltip("The color for the inner background of the tooltip.")]
        [SerializeField]
        private Color innerBackgroundColor = Color.white;
        /// <summary>
        /// The color for the inner background of the tooltip.
        /// </summary>
        public Color InnerBackgroundColor
        {
            get
            {
                return innerBackgroundColor;
            }
            set
            {
                innerBackgroundColor = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterInnerBackgroundColorChange();
                }
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private TooltipConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public TooltipConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="LineOrigin"/>.
        /// </summary>
        public virtual void ClearLineOrigin()
        {
            if (!this.IsValidState())
            {
                return;
            }

            LineOrigin = default;
        }

        /// <summary>
        /// Clears <see cref="FacingSource"/>.
        /// </summary>
        public virtual void ClearFacingSource()
        {
            if (!this.IsValidState())
            {
                return;
            }

            FacingSource = default;
        }

        /// <summary>
        /// Called after <see cref="LineOrigin"/> has been changed.
        /// </summary>
        protected virtual void OnAfterLineOriginChange()
        {
            Configuration.ConfigureLine();
        }

        /// <summary>
        /// Called after <see cref="TooltipText"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTooltipTextChange()
        {
            Configuration.ConfigureText();
        }

        /// <summary>
        /// Called after <see cref="FontSize"/> has been changed.
        /// </summary>
        protected virtual void OnAfterFontSizeChange()
        {
            Configuration.ConfigureText();
        }

        /// <summary>
        /// Called after <see cref="FontColor"/> has been changed.
        /// </summary>
        protected virtual void OnAfterFontColorChange()
        {
            Configuration.ConfigureText();
        }

        /// <summary>
        /// Called after <see cref="OuterBackgroundColor"/> has been changed.
        /// </summary>
        protected virtual void OnAfterOuterBackgroundColorChange()
        {
            Configuration.ConfigureBackground();
        }

        /// <summary>
        /// Called after <see cref="InnerBackgroundColor"/> has been changed.
        /// </summary>
        protected virtual void OnAfterInnerBackgroundColorChange()
        {
            Configuration.ConfigureBackground();
        }
    }
}