namespace Tilia.Visuals.Tooltip
{
    using Tilia.Visuals.Tooltip.TextProcessing;
    using UnityEngine;
    using UnityEngine.UI;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Process;

    /// <summary>
    /// Configures Tooltip prefab based on the provided settings and implements the logic to display the tooltip.
    /// </summary>
    public class TooltipConfigurator : MonoBehaviour, IProcessable
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private TooltipFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public TooltipFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The UnityEngine.LineRenderer to draw a line from tooltip to target.")]
        [SerializeField]
        [Restricted]
        private LineRenderer lineRenderer;
        /// <summary>
        /// The <see cref="UnityEngine.LineRenderer"/> to draw a line from tooltip to target.
        /// </summary>
        public LineRenderer LineRenderer
        {
            get
            {
                return lineRenderer;
            }
            protected set
            {
                lineRenderer = value;
            }
        }
        [Tooltip("The GameObject use as the anchor point for the line.")]
        [SerializeField]
        [Restricted]
        private GameObject tooltipLineAnchor;
        /// <summary>
        /// The <see cref="GameObject"/> use as the anchor point for the line.
        /// </summary>
        public GameObject TooltipLineAnchor
        {
            get
            {
                return tooltipLineAnchor;
            }
            protected set
            {
                tooltipLineAnchor = value;
            }
        }
        [Tooltip("The Text to render onto the tooltip.")]
        [SerializeField]
        [Restricted]
        private BaseTextProcessor tooltipText;
        /// <summary>
        /// The <see cref="Text"/> to render onto the tooltip.
        /// </summary>
        public BaseTextProcessor TooltipText
        {
            get
            {
                return tooltipText;
            }
            protected set
            {
                tooltipText = value;
            }
        }
        [Tooltip("The Image to render as the tooltip outer background.")]
        [SerializeField]
        [Restricted]
        private Image outerImage;
        /// <summary>
        /// The <see cref="Image"/> to render as the tooltip outer background.
        /// </summary>
        public Image OuterImage
        {
            get
            {
                return outerImage;
            }
            protected set
            {
                outerImage = value;
            }
        }
        [Tooltip("The Image to render as the tooltip inner background.")]
        [SerializeField]
        [Restricted]
        private Image innerImage;
        /// <summary>
        /// The <see cref="Image"/> to render as the tooltip inner background.
        /// </summary>
        public Image InnerImage
        {
            get
            {
                return innerImage;
            }
            protected set
            {
                innerImage = value;
            }
        }
        #endregion

        /// <summary>
        /// The last frame position of the <see cref="TooltipLineAnchor"/>.
        /// </summary>
        protected Vector3 lastLineAnchorPosition;
        /// <summary>
        /// The last frame position of the <see cref="Facade.LineOrigin"/>.
        /// </summary>
        protected Vector3 lastFacadeLineOriginPosition;

        /// <summary>
        /// Processes the visualization of the tooltip.
        /// </summary>
        public virtual void Process()
        {
            LookAtFacingSource();
            UpdateLinePosition();
        }

        /// <summary>
        /// Configures the rendered line to the tooltip.
        /// </summary>
        public virtual void ConfigureLine()
        {
            ToggleLineVisibility();

            if (Facade.LineOrigin == null)
            {
                return;
            }

            LineRenderer.SetPosition(0, TooltipLineAnchor.transform.position);
            LineRenderer.SetPosition(1, Facade.LineOrigin.transform.position);
        }

        /// <summary>
        /// Configures the tooltip text.
        /// </summary>
        public virtual void ConfigureText()
        {
            TooltipText.SetColor(Facade.FontColor);
            TooltipText.SetSize(Facade.FontSize);
            TooltipText.SetText(Facade.TooltipText);
        }

        /// <summary>
        /// Configures the tooltip background.
        /// </summary>
        public virtual void ConfigureBackground()
        {
            OuterImage.color = Facade.OuterBackgroundColor;
            InnerImage.color = Facade.InnerBackgroundColor;
        }

        protected virtual void OnEnable()
        {
            ConfigureLine();
            ConfigureText();
            ConfigureBackground();
            ToggleLineVisibility();
        }

        /// <summary>
        /// Toggles the visibility of the tooltip line depending on whether there is a valid origin.
        /// </summary>
        protected virtual void ToggleLineVisibility()
        {
            LineRenderer.gameObject.SetActive(Facade.LineOrigin != null);
        }

        /// <summary>
        /// Forces the tooltip to point towards the <see cref="Facade.FacingSource"/>.
        /// </summary>
        protected virtual void LookAtFacingSource()
        {
            if (Facade.FacingSource == null)
            {
                return;
            }

            Facade.transform.LookAt(Facade.FacingSource.transform);
        }

        /// <summary>
        /// Updates the position of the tooltip line.
        /// </summary>
        protected virtual void UpdateLinePosition()
        {
            if (Facade.LineOrigin == null)
            {
                return;
            }

            if (!lastFacadeLineOriginPosition.ApproxEquals(Facade.LineOrigin.transform.position) || !lastLineAnchorPosition.ApproxEquals(TooltipLineAnchor.transform.position))
            {
                ConfigureLine();
            }

            lastFacadeLineOriginPosition = Facade.LineOrigin.transform.position;
            lastLineAnchorPosition = TooltipLineAnchor.transform.position;
        }
    }
}