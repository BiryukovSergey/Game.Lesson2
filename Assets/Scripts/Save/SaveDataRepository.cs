using System.IO;
using Controller;
using UnityEngine;

namespace Controller
{
    public class SaveDataRepository
    {
        private readonly IData<SaveData> _data;
        private readonly string _path;
        
        private const string _folderName = "dataSave";
        private const string _fileName = "data.bat";
        
        public SaveDataRepository()
        {
            _data = new JsonData<SaveData>();
            _path = Path.Combine(Application.dataPath, _folderName);
        }

        public void Save(PlayerView player)
        {
            if (!Directory.Exists(Path.Combine(_path)))
            {
                Directory.CreateDirectory(_path);
            }
            var savePlayer = new SaveData()
            {
                Position = player.transform.position,
                IsEnabled = true
            };
            _data.Save(savePlayer,Path.Combine(_path,_fileName));
        }

        public void Load(PlayerView player)
        {
            var file = Path.Combine(_path, _fileName);
            if(!File.Exists(file)) return;
            var newPlayer = _data.Load(file);
            player.transform.position = newPlayer.Position;
            player.gameObject.SetActive(newPlayer.IsEnabled);
            
            Debug.Log(player.transform.position);
        }

        
    }
}