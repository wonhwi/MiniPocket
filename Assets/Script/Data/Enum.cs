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
/// 오디오 타입
/// </summary>
public enum AudioType
{
  SFX = 1,
  BGM = 2,
  MasterBGM = 3,
}

/// <summary>
/// 채팅 타입
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
/// 인벤토리 여분 공간 남아있는지 상태 값
/// </summary>
public enum InventoryEmptySlotState
{
  None = 0,
  Free = 1,   //공간 충분함
  Full = 2,   // 가득참
  Over = 3,   // 공간이 조금 남아있어 누락 될 수 있음
}

