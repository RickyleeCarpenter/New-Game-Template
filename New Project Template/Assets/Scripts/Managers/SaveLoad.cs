using UnityEngine;
using System.IO;
using System.Xml.Serialization;

public class SaveLoad : MonoBehaviour
{
    [SerializeField] private string directory;
    [SerializeField] private string extention = "example.nitwit";

    public SaveData _saveData;

    public void Initialise()
    {
        directory = Application.persistentDataPath;
        LoadData();
    }

    [ContextMenu("Load")]
    public void LoadData()
    {
        if (System.IO.File.Exists(directory + "/" + extention))
        {
            var serializer = new XmlSerializer(typeof(SaveData));
            var stream = new FileStream(directory + "/" + extention, FileMode.Open);
            _saveData = serializer.Deserialize(stream) as SaveData;
            stream.Close();

            ApplyData();
        }
        else
            SaveData();
    }

    [ContextMenu("Save")]
    public void SaveData()
    {
        SetData();

        var serializer = new XmlSerializer(typeof(SaveData));
        var stream = new FileStream(directory + "/" + extention, FileMode.Create);
        serializer.Serialize(stream, _saveData);
        stream.Close();
    }

    [ContextMenu("Delete")]
    public void DeleteSaveData()
    {
        if (System.IO.File.Exists(directory + "/" + extention))
            File.Delete(directory + "/" + extention);
    }

    private void ApplyData()
    {
        GameManager.instance._audio.volume = _saveData.s_volume;

        GameManager.instance._progress.level = _saveData.s_level;
    }

    private void SetData()
    {
        _saveData.s_volume = GameManager.instance._audio.volume;

        _saveData.s_level = GameManager.instance._progress.level;
    }
}

[System.Serializable]
public class SaveData
{
    // Audio
    public float s_volume;

    // Progress
    public int s_level;
}
