using System.Collections.Generic;

[System.Serializable]
public class ScenarioNodeData
{
    // ノードID
    public string nodeId;
    // 表示タイトル
    public string title;
    // サムネのアドレス or アセット名
    public string thumbnailPath;
    // 分岐先ノードID一覧
    public List<string> nextNodeIds;
    // 開放に必要なフラグ
    public List<string> requiredFlags;
    // エンディング判定（任意）
    public bool isEnding;
}
