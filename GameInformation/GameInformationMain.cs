﻿using System.Collections.Generic;
using System.Windows;
using ThLaunchSite.Plugin;

namespace GameInformation
{
    public class GameInformationMain : SelectedGamePluginBase
    {
        public override string Name => "ゲームの情報";

        public override string Version => "1.0.0";

        public override string Developer => "珠音茉白/東方管制塔開発部";

        public override string Description => "選択中のゲームについて簡易的に情報を提供します。";

        public override string CommandName => "このゲームについて";

        public Window? MainWindow { get; set; }

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

        GameInformationDialog? _gameInformationDialog = null;

        public override void Main(string gameId, string gameFile)
        {
            if (_gameInformationDialog == null || !_gameInformationDialog.IsLoaded)
            {
                _gameInformationDialog = new()
                {
                    GameId = gameId,
                    GameName = _gameNameDictionary[gameId],
                    GamePath = gameFile
                };

                if (this.MainWindow != null) _gameInformationDialog.Owner = this.MainWindow;

                _gameInformationDialog.Show();
            }
            else
            {
                _gameInformationDialog.WindowState = System.Windows.WindowState.Normal;
                _gameInformationDialog.Activate();
            }
        }
    }
}
