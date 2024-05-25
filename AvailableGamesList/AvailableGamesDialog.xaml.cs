using System.Collections.Generic;
using System.Windows;

namespace AvailableGamesList
{
    /// <summary>
    /// AvailableGamesDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class AvailableGamesDialog : Window
    {
        public AvailableGamesDialog()
        {
            InitializeComponent();
        }

        public Dictionary<string, string>? AvailableGamesNameFileDictionary
        {
            set
            {
                AvailableGamesListBox.Items.Clear();

                if (value != null && value.Count > 0)
                {
                    foreach (KeyValuePair<string, string> gameNamePathPair in value)
                    {
                        string gameName = gameNamePathPair.Key;
                        string gamePath = gameNamePathPair.Value;

                        AvailableGamesListBox.Items.Add($"{gameName}: \"{gamePath}\"");
                    }
                }
            }
        }
    }
}
