# UniIL2CPPChecker

IL2CPP でビルドされたかどうかを返すクラス

## 使用例

### 通常

```cs
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        bool isIL2CPP = false;

#if ENABLE_IL2CPP
        isIL2CPP = true;
#endif
        
        Debug.Log( isIL2CPP );
    }
}
```

### UniIL2CPPChecker

```cs
using Kogane;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log( IL2CPPChecker.IsIL2CPP );
    }
}
```
