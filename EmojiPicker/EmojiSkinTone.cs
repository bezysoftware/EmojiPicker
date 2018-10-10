namespace EmojiPicker
{
    public class EmojiSkinTone
    {
        public EmojiSkinTone(string emoji, string name)
        {
            this.Emoji = emoji;
            this.Name = name;
        }

        public string Emoji { get; }
        public string Name { get; }
    }
}