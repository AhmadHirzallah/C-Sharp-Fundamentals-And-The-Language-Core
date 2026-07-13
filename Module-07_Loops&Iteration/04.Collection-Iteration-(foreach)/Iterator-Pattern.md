Check Link: https://medium.com/@lakstutor/iterator-pattern-in-c-from-basics-to-advanced-c232cc4584e

----

- foreach implements the Iterator Pattern in C#. 
	- The Iterator Pattern is a design pattern that allows sequential access to elements of a collection without exposing its underlying representation. In C#, the `foreach` loop provides a simple and elegant way to iterate over collections, such as arrays, lists, and other enumerable types.
	- When you use `foreach`, the compiler generates code that uses the `GetEnumerator()` method of the collection, which returns an enumerator object. This enumerator object implements the `IEnumerator` interface, which provides the `MoveNext()` and `Current` properties to traverse the collection.

---

# Iterator Pattern in C#: From Basics to Advanced

The **Iterator pattern** is a behavioral design pattern that lets you walk through the elements of a collection one at a time, without the client ever needing to know how that collection stores its data internally. C# takes this pattern so seriously that it's baked directly into the language through the `IEnumerable` / `IEnumerator` interfaces and the `foreach` loop.

---

## The Core Idea

At its heart, iteration is about **decoupling traversal from storage**. Whether the underlying data lives in an array, a linked list, or a tree, the client should be able to say *"give me the next element"* in a uniform way. The pattern hides the structure and exposes only the sequence.

## Participants

The classic Gang-of-Four formulation has four roles:

| Role | Responsibility |
|------|----------------|
| **Iterator** | Declares the interface for accessing and traversing elements (`First`, `Next`, `IsDone`, `CurrentItem`). |
| **ConcreteIterator** | Implements the iterator interface and tracks the current position in the traversal. |
| **Aggregate** | Declares an interface for creating an iterator object. |
| **ConcreteAggregate** | Implements the aggregate interface and returns a concrete iterator. |

---

## Classic (Manual) Implementation

Here's the pattern spelled out by hand for a collection of book titles — useful for seeing what C# does for you under the hood.

```csharp
// Aggregate
public interface IBookCollection
{
    Iterator CreateIterator();
}

// ConcreteAggregate
public class BookCollection : IBookCollection
{
    private List<string> _titles = new List<string>();

    public void Add(string title)
    {
        _titles.Add(title);
    }

    public Iterator CreateIterator()
    {
        return new BookIterator(this);
    }

    public int Count => _titles.Count;

    public string this[int index]
    {
        get { return _titles[index]; }
    }
}

// Iterator
public abstract class Iterator
{
    public abstract string First();
    public abstract string Next();
    public abstract bool IsDone();
    public abstract string CurrentItem();
}

// ConcreteIterator
public class BookIterator : Iterator
{
    private BookCollection _books;
    private int _current = 0;

    public BookIterator(BookCollection books)
    {
        _books = books;
    }

    public override string First()
    {
        return _books[0];
    }

    public override string Next()
    {
        _current++;
        if (IsDone())
            return null;
        else
            return _books[_current];
    }

    public override bool IsDone()
    {
        return _current >= _books.Count;
    }

    public override string CurrentItem()
    {
        return _books[_current];
    }
}

// Client
var books = new BookCollection();
books.Add("Design Patterns");
books.Add("Clean Code");
books.Add("Refactoring");

var iterator = books.CreateIterator();
while (!iterator.IsDone())
{
    Console.WriteLine(iterator.CurrentItem());
    iterator.Next();
}
```

---

## The C# Way: `IEnumerable` + `yield`

In practice you rarely write iterators by hand. Implementing `IEnumerable<T>` and using the `yield return` keyword lets the compiler generate the entire state machine for you.

```csharp
public class BookCollection : IEnumerable<string>
{
    private List<string> _titles = new List<string>();

    public void Add(string title)
    {
        _titles.Add(title);
    }

    public IEnumerator<string> GetEnumerator()
    {
        foreach (var title in _titles)
        {
            yield return title;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// Client
var books = new BookCollection();
books.Add("Design Patterns");
books.Add("Clean Code");
books.Add("Refactoring");

foreach (var book in books)
{
    Console.WriteLine(book);
}
```

The `yield return` statement is the key: each time the consumer asks for the next value, execution resumes exactly where it left off. That single keyword replaces all the manual position-tracking from the previous example — and `foreach` itself is just syntactic sugar over `GetEnumerator()` → `MoveNext()` → `Current`.

---

## Advanced Variations

Once the basics click, the pattern flexes in several directions:

- **Two-way (bidirectional) iterators** — extend the interface with a `Previous()` so you can walk backward as well as forward.
- **Composite iterators** — for tree-like structures, build an iterator that performs a depth-first or breadth-first traversal, flattening the hierarchy into a linear sequence.
- **Filtered iterators** — yield only the elements that satisfy a predicate, so the collection *appears* to contain just the matching items.
- **Lazy iterators** — defer computing each element until it's actually requested. Because `yield` is inherently lazy, C# gives you this almost for free — invaluable for large collections or when producing the next item is expensive.

---

## Key Takeaways

- The Iterator pattern separates **how you traverse** from **how data is stored**.
- In C#, you almost never implement `IEnumerator` manually — `yield return` generates the state machine automatically.
- `foreach` is sugar over `GetEnumerator()` / `MoveNext()` / `Current`.
- Laziness, filtering, and composite traversal all layer naturally on top of the same abstraction.

---

*Adapted from "Iterator Pattern in C#: From Basics to Advanced" by Laks Tutor (Medium).*