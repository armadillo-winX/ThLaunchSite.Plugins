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

        public override void Main(List<string> availableGamesList, Dictionary<string, string> availableGameFilesDictionary)
        {
            
        }
    }
}
