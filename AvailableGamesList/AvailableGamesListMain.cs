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

        private readonly static Dictionary<string, string> _gameNameDictionary = new()
        {
            { "Th06", "東方紅魔郷" },
            { "Th07", "東方妖々夢" },
            { "Th08", "東方永夜抄" },
            { "Th09", "東方花映塚" },
            { "Th095", "東方文花帖" },
            { "Th10", "東方風神録" },
            { "Th11", "東方地霊殿" },
            { "Th12", "東方星蓮船" },
            { "Th125", "ダブルスポイラー" },
            { "Th128", "妖精大戦争" },
            { "Th13", "東方神霊廟" },
            { "Th14", "東方輝針城" },
            { "Th143", "弾幕アマノジャク" },
            { "Th15", "東方紺珠伝" },
            { "Th16", "東方天空璋" },
            { "Th165", "秘封ナイトメアダイアリー" },
            { "Th17", "東方鬼形獣" },
            { "Th18", "東方虹龍洞" },
            { "Th185", "バレットフィリア達の闇市場" },
            { "Th19", "東方獣王園" }
        };

        private AvailableGamesDialog _availableGamesDialog = null;

        public override void Main(List<string> availableGamesList, Dictionary<string, string> availableGameFilesDictionary)
        {
            Dictionary<string, string> availableGamesNameFileDictionary = [];

            if (availableGamesList != null && availableGamesList.Count > 0)
            {
                foreach (string gameId in availableGamesList)
                {
                    availableGamesNameFileDictionary.Add(_gameNameDictionary[gameId], availableGameFilesDictionary[gameId]);
                }
            }

            if (_availableGamesDialog == null || !_availableGamesDialog.IsLoaded)
            {
                AvailableGamesDialog availableGamesDialog = new()
                {
                    AvailableGamesNameFileDictionary = availableGamesNameFileDictionary
                };

                availableGamesDialog.ShowDialog();
            }
            else
            {
                _availableGamesDialog.AvailableGamesNameFileDictionary = availableGamesNameFileDictionary
            }
        }
    }
}
