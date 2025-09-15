using System;

namespace OSK
{
    [Flags]
    public enum ModuleType
    {
        None = 0,
        MonoManager = 1 << 0,
        EventBusManager = 1 << 1,
        PoolManager = 1 << 2,
        DirectorManager = 1 << 3,
        ResourceManager = 1 << 4,
        StorageManager = 1 << 5,
        GameConfigsManager = 1 << 6,
        SoundManager = 1 << 7,
        EntityManager = 1 << 8,
        BlackboardManager = 1 << 9,
        ProcedureManager = 1 << 10,
    }
}