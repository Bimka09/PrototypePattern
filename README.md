# PrototypePattern

# Описание интерфейсов

IMyCloneable - Интерфейс для реализации шаблона прототипа


# Описание классов

BaseMob - базовый класс, реализующий интерфейсы ICloneable,IMyCloneable
EarthMob - класс расширяющий класс BaseMob, добавлено поле StoneDamage и TotalDamage 
SupremeBaseMob - класс расширяющий класс EarthMob, добавлено поле Artefact
BossBaseMob - класс расширяющий класс SupremeBaseMob, добавлено поле Ultimate
