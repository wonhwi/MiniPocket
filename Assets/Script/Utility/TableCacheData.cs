using System.Collections.Generic;

public class TableCacheData
{
  public Dictionary<TableType, object> tableDic = new Dictionary<TableType, object>();

  public void Add<T>(TableType key, T data) where T : class
  {
    if (tableDic.ContainsKey(key))
    {
      tableDic[key] = data;
    }
    else
    {
      tableDic.Add(key, data);
    }
  }

  public T GetValue<T>(TableType key) where T : class
  {
    return tableDic[key] as T;
  }
}