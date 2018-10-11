using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using NeoSmart.Unicode;
using Windows.UI.Core;
using System.Collections.ObjectModel;

namespace EmojiPicker
{
    public partial class EmojiPicker : Control
    {
        private static Popup openPopup;

        private int skinToneIndex = 0;
        private Border highlightBorder;
        private Button skinToneButton;
        private ListViewBase emojiPresenter;
        private Button[] categoryButtons;
        private Button closeButton;
        private TextBlock searchPhrase;
        private string selectedEmoji;
        private SingleEmoji[] activeEmoji;
        private ObservableCollection<SingleEmoji> allEmoji;
        private bool searchMode;

        public EmojiPicker()
        {
            this.DefaultStyleKey = typeof(EmojiPicker);
            this.categoryButtons = new Button[6];
        }

        public static async Task<string> ShowAsync()
        {
            var picker = new EmojiPicker();
            var container = new Grid
            {
                Width = Window.Current.Bounds.Width,
                Height = Window.Current.Bounds.Height,
                Background = new SolidColorBrush(new Color { A = 100, R = 100, G = 100, B = 100 })
            };
            container.Children.Add(picker);

            openPopup = new Popup
            {
                IsLightDismissEnabled = true,
                LightDismissOverlayMode = LightDismissOverlayMode.On,
                Child = container,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                VerticalAlignment = VerticalAlignment.Stretch,
                ChildTransitions = new TransitionCollection
                {
                    new ContentThemeTransition()
                },
                IsOpen = true
            };

            picker.Focus(FocusState.Programmatic);

            var tcs = new TaskCompletionSource<string>();

            openPopup.Closed += (_, __) => tcs.SetResult(picker.selectedEmoji);

            return await tcs.Task;
        }

        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.highlightBorder = (Border) this.GetTemplateChild("HighlightBorder");
            this.skinToneButton = (Button) this.GetTemplateChild("SkinToneButton");
            this.emojiPresenter = (ListViewBase) this.GetTemplateChild("EmojiPresenter");

            this.categoryButtons[0] = (Button) this.GetTemplateChild("SmilesButton");
            this.categoryButtons[1] = (Button) this.GetTemplateChild("PeopleButton");
            this.categoryButtons[2] = (Button) this.GetTemplateChild("BalloonButton");
            this.categoryButtons[3] = (Button) this.GetTemplateChild("PizzaButton");
            this.categoryButtons[4] = (Button) this.GetTemplateChild("CarButton");
            this.categoryButtons[5] = (Button) this.GetTemplateChild("HeartButton");

            this.closeButton = (Button) this.GetTemplateChild("CloseButton");
            this.searchPhrase = (TextBlock)this.GetTemplateChild("SearchPhrase");

            this.skinToneButton.Click += this.SkinToneButtonClick;
            this.closeButton.Click += this.CloseButtonClick;
            this.emojiPresenter.SelectionChanged += this.EmojiSelected;

            foreach (var button in this.categoryButtons)
            {
                button.Click += this.ChangeCategoryClick;
            }

            this.SetCurrentEmoji(0);
            this.allEmoji = new ObservableCollection<SingleEmoji>(AllEmoji());
        }

        protected override void OnKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Tab)
            {
                var shift = CoreWindow.GetForCurrentThread().GetKeyState(VirtualKey.Shift) == CoreVirtualKeyStates.Down;
                var current = Grid.GetColumn(this.highlightBorder);
                var i = this.PositiveModulo(shift ? current - 2 : current, 6);
                this.SetCurrentEmoji(i);
                Grid.SetColumn(this.highlightBorder, i + 1);
            }

            var key = (int)e.Key;
            if (key >= 0x41 && key <= 0x5A)
            {
                this.searchPhrase.Text += ((char)key).ToString().ToLower();
                this.RefreshSearch(this.searchPhrase.Text);
            }

            if (e.Key == VirtualKey.Back && this.searchPhrase.Text.Length > 0)
            {
                this.searchPhrase.Text = this.searchPhrase.Text.Substring(0, this.searchPhrase.Text.Length - 1);
                this.RefreshSearch(this.searchPhrase.Text);
            }

        }

        private void RefreshSearch(string phrase)
        {
            if (phrase.Length == 0)
            {
                VisualStateManager.GoToState(this, "NormalState", true);
                this.searchMode = false;
                this.SetCurrentEmoji(0);
                Grid.SetColumn(this.highlightBorder, 1);
                this.skinToneButton.Visibility = Visibility.Collapsed;
            }
            else
            {
                VisualStateManager.GoToState(this, "SearchState", true);
                this.searchMode = true;
                this.skinToneButton.Visibility = Visibility.Visible;

                this.UpdateSearchResults(phrase);

                this.emojiPresenter.ItemsSource = this.allEmoji;
            }
        }

        private void UpdateSearchResults(string phrase)
        {
            var skinToneName = SkinTones[this.skinToneIndex].Name;

            // remove emoji which don't satisfy current search phrase
            this.allEmoji
                .Where(e => !e.SearchTerms.Any(s => s.StartsWith(phrase)))
                .ToList()
                .ForEach(s => this.allEmoji.Remove(s));

            // add emoji which satisfy current search phrase
            AllEmoji()
                .Where(e => e.SearchTerms.Any(s => s.StartsWith(phrase)))
                .Where(e => !this.allEmoji.Contains(e))
                .ToList()
                .ForEach(s => this.allEmoji.Add(s));
        }

        private void EmojiSelected(object sender, SelectionChangedEventArgs e)
        {
            this.selectedEmoji = ((SingleEmoji)e.AddedItems.First()).ToString();
            openPopup.IsOpen = false;
        }

        private void ChangeCategoryClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var tag = int.Parse(button.Tag.ToString());
            this.SetCurrentEmoji(tag);
            this.skinToneButton.Visibility = tag == 1 ? Visibility.Visible : Visibility.Collapsed;
            Grid.SetColumn(this.highlightBorder, tag + 1);
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            openPopup.IsOpen = false;
        }

        private int PositiveModulo(int x, int m)
        {
            return (x % m + m) % m;
        }

        private void SetCurrentEmoji(int id)
        {
            this.activeEmoji = EmojiGroups[id];
            this.emojiPresenter.ItemsSource = activeEmoji;
        }

        private void SkinToneButtonClick(object sender, RoutedEventArgs e)
        {
            this.skinToneIndex = (this.skinToneIndex + 1) % 6;
            var skinTone = SkinTones[this.skinToneIndex];
            EmojiGroups[1] = skinTone.SkinEmoji;

            this.skinToneButton.Content = skinTone.Emoji;

            if (!this.searchMode)
            {
                this.SetCurrentEmoji(1);
            }
            else
            {
                this.allEmoji.Clear();
                this.RefreshSearch(this.searchPhrase.Text);
            }
        }
    }
}
