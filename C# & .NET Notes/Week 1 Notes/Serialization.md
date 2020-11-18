# Serialization (FileIO, Regular expressions, Serializer-JSON/text/XML)
* Process of converting an object into a stream of bytes to store the object or transmit it to memory, a database, or a file
* Save the state of the object for latter recreation (when needed)
* Deserialization is the process of unpacking serialized objects
* Formats: 
    * Custom binary (error prone, don't do it)
    * Custom text (built in support in C#)
        * JSON
        * XML
# File I/O
* Byte Stream
    * Stream of bytes used in writing to an external file
    * Can be thought of as a bridge between C# code and the file
    * You send bytes to the byte stream so they can be written externally
    * Types of bytestreams in C#: Stream, FileStream, MemoryStream and BufferedStream
* Character Streams
    * Similar to byte stream, also used to write to external files
    * Stream of characters to be written to a file as text
    * Types of character streams: TextReader, TextWriter, StreamReader, StreamWriter