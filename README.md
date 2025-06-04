## Data Types
### Variables and Constants

- Variable: a name given to a storage location in memory
- Constant: an immutable value. (Pi = 3.14)

In `C#` to declare a variable we start with defining `type` and then identifier;
```csharp
int Number = 1;

const float Pi = 3.14f; // "f" we tell compailer to treat this number as float. Double is default type for real numbers.
// Same for decimals:
decimal number = 1.4m;
```
We have to **assign a value** to the variable before we **read** it!

### Identifiers

- Cannot start with a number!
- Cannot include white spaces
- Cannot include a reserver word;
- Always use meaningful names.

#### Naming Conventions

- CamelCase: `firstLetter`;
- PascalCase: `FirstName`;
- Hungarian Notation: `strFirstName`.

For local **variables** we use **camelCase**:
```csharp
int number;
```

For **constants**, we use **PascalCase**:
```csharp
const int MaxZoom = 5;
```
### Primitive Types

_Group Type / C# Type / .NET Type / Bytes_

**Integral Numbers**

- **byte** | Byte | _(Bytes: 1)_
- **short** | Int16 | _(Bytes: 2)_
- **int** | Int32 | _(Bytes: 4)_
- **long** | int64 | _(Bytes: 8)_

**Real Numbers**
- **float** | Single | _(Bytes: 4)_
- **double** | Double |_(Bytes: 8)_
- **decimal** | Decimal | _(Bytes: 16)_

**Character**
- **char** | Char | _(Bytes: 2)_

**Boolean**
- **bool** | Boolean | _(Bytes: 1)_

### Non-Primitive Types

- String
- Array
- Enum
- Class

## Overflowing

```csharp
// If we use `checked`-keyword overflow will not happen, instead program will throw an exception
checked 
{
    byte number = 255;
    number = number + 1; // Exception will be thrown
}
```

## Scope

```csharp
{
    byte a = 1;
    {
        byte b = 2;
        {
            byte c = 3;
        }
    }
}
```

Variable `a` is accesible to all its children (`b` and `c`), but not outside of block where variable `a` is declared.

Within the code editor, everything in blue color is a `keyword`: `byte`, `string`, `true`, etc...

`var`-keyword - Program compiler will detect data type for variable from its context:
```csharp
var number = 2; // It knows that is int
```

Use `int` in most cases.

## Type Conversion

- Implicit Type Conversion;
- Explicit Type Conversion (casting);
- Conversion between non-compatible types.

### Implicit Type Conversion

```csharp
int i = 1;
byte b = i; // won't compile -> might do the data loss.
```

### Explicit Type Conversion

```csharp
int i = 1;
byte b = (byte)i; // casting -> we are aware ov data loss

// or...
float f = 1.0f;
int i = (int)f; // casting -> we are aware ov data loss
```

### Non-compatible Types

```csharp
string s = "123";
int i = Convert.ToInt32(s); // 32(bits): An `int` has 4 bytes. Each byte has 8 bits -> 4 x 8 = 32 bits.
int j = int.Parse(s);
```

Some of the methods in `Convert` class:
- `ToByte()`;
- `ToInt16()`; // short
- `ToInt32()`; // integer
- `ToInt64()`; // long

## Exceptions

Exceptions are used for Error handling. We can wrap the code we need to handle errors within, with `try/catch` block.

## Operations
### Arithmetic Operations

**Add** | `+` |

**Subtract** | `-` |

**Multiply** | `*` |

**Divide** | `/` |

**Reminder** | `%` |

#### Postfix Increment
```csharp
int a = 1;

int b = a++; // first `b` is going to be one, and then `a` is going to be incremented by 1!

// Result: a = 2; b = 1;
```

#### Prefix Increment
```csharp
int a = 1;
int b = ++a; // first `a` is going to be incremented by a, then `b` is going to be set to a variable `a`.

// Result: a = 2; b = 2;
```

### Comparison Operators

**Equal** | `==` |

**Not Equal** | `!=` |

**Greater than** | `>` |

**Greater than or Equal to** | `>=` |

**Less than** | < |

**Less than or Equal to** | `<=` |

### Assignment Operators

**Assignment** | `=` |

**Addition assignment** | `+=` | `a += 3` the same as `a = a + 3;`

**Subtraction assignment** | `-=` |

**Multiplication assignment** | `*=` |

**Division assignment** | `/=` |

### Logical Operators

**And** | `&&` |

**Or** | `||` |

**Not** | `!` |

### Bitwise Operators
Often used in Low-level Programming (Web API, WebSockets, etc...) 

**And** | `&` |

**Or** | `|` |