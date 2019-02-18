using System.Collections;
using System.Collections.Generic;
using System.IO;

// 바이너리 파일 포맷을 위한 네임스페이스
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

// 데이터 저장 클래스에 접근하기 위한 네임스페이스
using IndexInfo;

public class DataMgr : MonoBehaviour
{
    // 파일이 저장될 물리적인 경로 및 파일명을 저장할 변수
    private string dataPath;

    // 파일 저장 경로와 파일명 지정
    public void Initialize()
    {
        dataPath = Application.persistentDataPath + "/gameData.dat";
    }

    // 데이터 저장 및 파일을 생성하는 함수
    public void Save(ItemIndex gameData)
    {
        // 바이너리 파일 포맷을 위한 BinaryFormatter 생성
        BinaryFormatter bf = new BinaryFormatter();
        // 데이터 저장을 위한 파일 생성
        FileStream file = File.Create(dataPath);

        // 파일에 저장할 클래스에 데이터 할당
        ItemIndex QI = new ItemIndex();
        QI.Q = gameData.Q;
        // BinaryFormatter를 사용해 파일에 데이터 기록
        bf.Serialize(file, QI);
        file.Close();
    }

    // 파일에서 데이터를 추출하는 함수
    public ItemIndex Load()
    {
        if (File.Exists(dataPath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(dataPath, FileMode.Open);

            // GameData 클래스에 파일로부터 읽은 데이터를 기록
            ItemIndex data = (ItemIndex)bf.Deserialize(file);
            file.Close();

            return data;
        }
        else
        {
            // 파일이 없을 경우 기본값을 변환
            ItemIndex data = new ItemIndex();
            return data;
        }
    }
}
