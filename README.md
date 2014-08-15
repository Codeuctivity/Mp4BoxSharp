Mp4BoxSharp
===========

Here's an example concat synchron:

```
function test() {
  mp4boxSharp.mp4BoxSharpSync mp4boxSync = new mp4boxSharp.mp4BoxSharpSync();
  var sourcelist = new List<Uri>();
  sourcelist.Add(new Uri(getDirectoryOfAssembly() + "\\source1.mp4"));
  sourcelist.Add(new Uri(getDirectoryOfAssembly() + "\\source2.mp4"));
  mp4boxSync.concatMp4s(sourcelist, new Uri("\\TestOutput.mp4"));
}
```
