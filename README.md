# Unity3D + SQLite example

This is a minimal, ready to run example on how to use SQLite from Unity3D originally taken from: https://github.com/PangeranWiguan/W.G.-Unity3D-SQLite

## Using it in your project

To use Sqlite make sure `System.Data.dll` and `Mono.Data.Sqlite.dll` are included in your project.
Both files can be found in:
`/Applications/Unity/Unity.app/Contents/Frameworks/Mono/lib/mono/unity/`

For more info refer to DBAccess.cs

```
using Mono.Data.Sqlite; // Requires Mono.Data.Sqlite.dll
using System.Data;      // Requires System.Data.dll

IDbConnection connection = new SqliteConnection(path) as IDbConnection;
IDbCommand cmd = connection.CreateCommand();
IDataReaded reader = cmd.ExecuteReader();
...
```

Note: dlls included in this project were taken from `/Applications/Unity/Unity.app/Contents/Frameworks/MonoBleedingEdge/lib/mono/2.0/` but I think we should not be using that stuff. I am pretty sure Unity uses non-MonoBleadingEdge dlls when compiling apps.