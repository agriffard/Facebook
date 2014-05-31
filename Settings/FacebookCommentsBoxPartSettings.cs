namespace Facebook.Settings {
    public class FacebookCommentsBoxPartSettings {
        public FacebookCommentsBoxPartSettings() {
            Width = 550;
            NumberOfPosts = 15;
            ColorScheme = "light";
            OrderBy = "social";
        }

        public virtual int Width { get; set; }
        public virtual int NumberOfPosts { get; set; }
        public virtual string ColorScheme { get; set; }
        public virtual string OrderBy { get; set; }
    }
}