using TMPro;
using UnityEngine;

namespace SimpleTextProvider
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TextProviderTMP : AbstractTextProvider
    {
        private TextMeshProUGUI _label;

        private void Awake()
        {
            _label = GetComponent<TextMeshProUGUI>();
        }

        protected override void SetLabelText(string text)
        {
            _label.text = text;
        }
    }
}