# Unity3D + SQLite example

This is a minimal, ready to run example on how to use SQLite from Unity3D

## Using it in your project

To use Sqlite make sure `System.Data.dll` and `Mono.Data.Sqlite.dll` are included in your project
Both files can be found in:
/Applications/Unity/Unity.app/Contents/Frameworks/Mono/lib/mono/unity/

For more info refer to DBAccess.cs

```
using Mono.Data.Sqlite; // Requires Mono.Data.Sqlite.dll
using System.Data;      // Requires System.Data.dll

IDbConnection connection = new SqliteConnection(path) as IDbConnection;
IDbCommand cmd = connection.CreateCommand();
IDataReaded reader = cmd.ExecuteReader();
...
```
