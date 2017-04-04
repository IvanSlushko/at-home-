
// Наследование.

namespace Inheritance
{
    class DerivedClass : BaseClass
    {
        // Конструктор.
        public DerivedClass()
        {
            // Изменяем все доступные поля унаследованные от базового класса.
            // Только паблик и протектед можно передать в наследуемый класс!!!!!
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";    
                   
        }
    }
}
