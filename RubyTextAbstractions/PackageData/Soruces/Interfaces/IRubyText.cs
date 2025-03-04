using UnityEngine;

namespace jp.netsis.RubyText
{
    public interface IRubyText
    {
        #region Text
        // The point size of the font.
        public bool enableAutoSizing { get; }
        // Sets Perspective Correction to Zero for Orthographic Camera mode & 0.875f for Perspective Camera mode.
        public bool isOrthographic { get; }
        // If true, from right to left. Otherwise, left to right.
        public bool isRightToLeftText { get; set; }
        // Function to Calculate the Preferred Width and Height of the text object given a certain string.
        public Vector2 GetPreferredValues(string str);
        #endregion

        #region Ruby Text
        // v offset ruby. (em, px, %).
        public string rubyVerticalOffset { get; }
        // ruby scale. (1=100%)
        public float rubyScale { get; }
        // The height of the ruby line can be specified. (em, px, %)
        public string rubyLineHeight { get; }
        // ruby show type.
        public RubyTextConstants.RubyShowType rubyShowType { get; }
        public float rubyMargin { get; }
        
        public string uneditedText { get; set; }
        #endregion

    }
}