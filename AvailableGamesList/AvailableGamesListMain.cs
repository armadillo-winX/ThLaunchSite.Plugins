using System.Collections.Generic;
using ThLaunchSite.Plugin;

namespace AvailableGamesList
{
    public class AvailableGamesListMain : GameFilesPluginBase
    {
        public override string Name => "�L���ȃQ�[���̈ꗗ";

        public override string Version => "1.0.0";

        public override string Developer => "Mashiro Tamane";

        public override string Description => "�����ǐ��� NX �Ƀp�X���o�^����Ă���Q�[���Ƃ��̎��s�t�@�C���p�X�����X�g�����܂��B";

        public override string CommandName => "�L���ȃQ�[���̈ꗗ";

        private readonly static Dictionary<string, string> _gameNameDictionary = new()
        {
            { "Th06", "�����g����" },
            { "Th07", "�����d�X��" },
            { "Th08", "�����i�鏴" },
            { "Th09", "�����ԉf��" },
            { "Th095", "�������Ԓ�" },
            { "Th10", "�������_�^" },
            { "Th11", "�����n��a" },
            { "Th12", "�������@�D" },
            { "Th125", "�_�u���X�|�C���[" },
            { "Th128", "�d����푈" },
            { "Th13", "�����_��_" },
            { "Th14", "�����P�j��" },
            { "Th143", "�e���A�}�m�W���N" },
            { "Th15", "��������`" },
            { "Th16", "�����V����" },
            { "Th165", "�镕�i�C�g���A�_�C�A���[" },
            { "Th17", "�����S�`�b" },
            { "Th18", "����������" },
            { "Th185", "�o���b�g�t�B���A�B�̈Ŏs��" },
            { "Th19", "�����b����" }
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
