# Variance (As, Boxing, Casting, Contravariant, Covariant, Invariant, Is, Out, Ref, Typeof)
## Type Variance
* Describes the type that may be substituted in place of another type
* Covariance: A substitution is covariant with a type, Foo, if Foo or any other class with a subclass relationship to Foo is valid
* Contravariance: A substitution is contravariant with a type, Bar, if Bar or any other class with a superclass relationship to Bar is valid.
* Invariance: A substitution is invariant with a type, Foo, if only types that are exactly Foo are valid.
## Type Casting
* Boxing (Autoboxing)
    * Upcasting
    * Casting to a supertype
    * implicit typecasting
* Unboxing
    * Downcasting
    * Casting to a subtype
    * Explicit Typecasting
* Note that types that are similar to each other such as numeric types can be casted to another similar type (int to double)
## Type Checking
* **is** operator
    * used to check if the run-time type of an object is compatible with the given type or not.
    * returns true if the given object is of the same type otherwise, return false. Also returns false for null objects.
* **typeof** operator
    * used to get a type at the compile-time. Or, in other words, this operator is used to get the System.Type object for a type.
    * Gives you the CTS version of the type.
    * This operator takes the type itself as an argument and returns the marked type of the argument.
    * Often confused with the GetType() method of an object, which returns the C# version of the type.