/// <summary>
/// Table Type
/// </summary>
public enum TableType
{
  NONE = 0,
  BASE = 1,
  Language = 2,
}

/// <summary>
/// AnchorPresets Type
/// </summary>
public enum AnchorPresets
{
  TopLeft,
  TopCenter,
  TopRight,

  MiddleLeft,
  MiddleCenter,
  MiddleRight,

  BottomLeft,
  BottonCenter,
  BottomRight,

  VertStretchLeft,
  VertStretchRight,
  VertStretchCenter,

  HorStretchTop,
  HorStretchMiddle,
  HorStretchBottom,

  StretchAll
}

/// <summary>
/// ����� Ÿ��
/// </summary>
public enum AudioType
{
  SFX = 1,
  BGM = 2,
  MasterBGM = 3,
}

/// <summary>
/// ä�� Ÿ��
/// </summary>
[System.Flags]
public enum ChatType
{
  None = 0,
  General = 1 << 1, 
  Server = 1 << 2,
  System = 1 << 3,
  Notice = 1 << 4,

  All = int.MaxValue,

}

[System.Serializable]
public enum ResetType
{
  None = 0,
  Daily = 4,
  Weekly = 5,
  Monthly = 6,
}

/// <summary>
/// �κ��丮 ���� ���� �����ִ��� ���� ��
/// </summary>
public enum InventoryEmptySlotState
{
  None = 0,
  Free = 1,   //���� �����
  Full = 2,   // ������
  Over = 3,   // ������ ���� �����־� ���� �� �� ����
}

