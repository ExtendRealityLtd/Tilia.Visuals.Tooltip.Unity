namespace Tilia.Visuals.Tooltip
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
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
        /// <summary>
        /// The public interface facade.
        /// </summary>
        [Serialized]
        [field: Header("Facade Settings"), DocumentedByXml, Restricted]
        public TooltipFacade Facade { get; protected set; }
        #endregion

        #region Reference Settings
        /// <summary>
        /// The <see cref="UnityEngine.LineRenderer"/> to draw a line from tooltip to target.
        /// </summary>
        [Serialized]
        [field: Header("Reference Settings"), DocumentedByXml, Restricted]
        public LineRenderer LineRenderer { get; protected set; }
        /// <summary>
        /// The <see cref="GameObject"/> use as the anchor point for the line.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public GameObject TooltipLineAnchor { get; protected set; }
        /// <summary>
        /// The <see cref="Text"/> to render onto the tooltip.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public Text TooltipText { get; protected set; }
        /// <summary>
        /// The <see cref="Image"/> to render as the tooltip outer background.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public Image OuterImage { get; protected set; }
        /// <summary>
        /// The <see cref="Image"/> to render as the tooltip inner background.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml, Restricted]
        public Image InnerImage { get; protected set; }
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
            RectTransform rect = TooltipText.GetComponent<RectTransform>();
            TooltipText.text = Facade.TooltipText;
            TooltipText.fontSize = Mathf.RoundToInt(Facade.FontSize / rect.localScale.x);
            TooltipText.color = Facade.FontColor;
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