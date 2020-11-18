# Collections (In-memory storage of data)
## Arrays 
1D, 2D, jagged, multidimensional
* Fixed Size, memory contiguous, elements must have values
* Rank of an array is the number of dimensions of an array.
* Jagged arrays are arrays where the array has a set number of rows, but the rows can be of differing lengths, like a bar graph shape. It is NOT 2D. In 2D arrays, every row has the same number of columns.
## Non-Generics 
All items are converted to object form when added to these collections i.e. Boxing.
* Stack
* Queue
* ArrayList
* HashTable (KeyValue)
## Generics 
Avoid the need for boxing by using Arrays internally, which are reference types that store the contents directly, not objects that refer to the data indirectly
* Stack&lt;T&gt;: Linear Data Structure LiFo 
* Queues&lt;T&gt;: Linear Data Structure FiFo
* List&lt;T&gt;: Dynamic Array
* Dictionary&lt;T,T&gt;: Key Value pairs, don't need to iterate to get the data you need
* SortedList&lt;T&gt;: Array of Key Value pairs sorted by keys.
## Collections inherit from interfaces that determine functionality
* IIterator (iteratability) -> IEnumerable (GetEnumerator func.) -> IEnumerable&lt;T&gt; -> ICollection (Add and Remove func.)
* From ICollection we get IList&lt;T&gt; -> List&lt;T&gt;, Stack&lt;T&gt;, Queue&lt;T&gt;, IDictionary&lt;TKey, TValue&gt; -> Dictionary&lt;TKey, TValue&gt;