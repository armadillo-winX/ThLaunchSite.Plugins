using System.Collections.Generic;
using ThLaunchSite.Plugin;

namespace AvailableGamesList
{
    public class AvailableGamesListMain : GameFilesPluginBase
    {
        public override string Name => "有効なゲームの一覧";

        public override string Version => "1.0.0";

        public override string Developer => "Mashiro Tamane";

        public override string Description => "東方管制塔 NX にパスが登録されているゲームとその実行ファイルパスをリスト化します。";

        public override string CommandName => "有効なゲームの一覧";

        public override void Main(List<string> availableGamesList, Dictionary<string, string> availableGameFilesDictionary)
        {
            
        }
    }
}
