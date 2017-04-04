
// Наследование.

namespace Inheritance
{
    class DerivedClass : BaseClass //наследуется от базового класса
    {
        // Конструктор.
        public DerivedClass()
        {
            publicField = "DerivedClass.publicField";
            protectedField = "DerivedClass.protectedField";            
        }
    }
}
