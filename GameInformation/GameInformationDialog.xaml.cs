using System.Windows;

namespace GameInformation
{
    /// <summary>
    /// GameInformationDialog.xaml の相互作用ロジック
    /// </summary>
    public partial class GameInformationDialog : Window
    {
        public GameInformationDialog()
        {
            InitializeComponent();
        }

        public string? GameId
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    GameIdBox.Text = value;
                }
            }
        }

        public string? GameName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    GameNameBox.Text = value;
                }
            }
        }

        public string? GamePath
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    GamePathBox.Text = value;
                }
            }
        }

        private void OKButtonClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
