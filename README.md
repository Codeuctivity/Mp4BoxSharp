Mp4BoxSharp
===========

## How to get Mp4BoxSharp

- Grab the source from GitHub, or
- Get it from Nuget:

**PM> Install-Package Mp4BoxSharp**
https://www.nuget.org/packages/Mp4BoxSharp/

## Example

### Concatenate mp4s synchron
```
function test() {
  mp4boxSharp.mp4BoxSharpSync mp4boxSync = new mp4boxSharp.mp4BoxSharpSync();
  var sourcelist = new List<Uri>();
  sourcelist.Add(new Uri(getDirectoryOfAssembly() + "\\source1.mp4"));
  sourcelist.Add(new Uri(getDirectoryOfAssembly() + "\\source2.mp4"));
  mp4boxSync.concatMp4s(sourcelist, new Uri("\\TestOutput.mp4"));
}
```

### Concatenate mp4s asynchron
```
private mp4boxSharp.mp4BoxSharpAsync mp4BoxSharpAsync = new mp4boxSharp.mp4BoxSharpAsync();
private void buttonStartConcatinationAsync_Click(object sender, EventArgs e)
{
    List<Uri> destinations = new List<Uri>();
    foreach (var item in openFileDialog2.FileNames)
        destinations.Add(new Uri(item));
    richTextBoxLogAsync.Clear();
    mp4BoxSharpAsync.startConcatAsync(destinations, new Uri(textBoxDestinationAsync.Text));
}

private void Form1_Load(object sender, EventArgs e)
{
    mp4BoxSharpAsync.Progress += mp4BoxSharpAsync_Progress;
    mp4BoxSharpAsync.Finished += mp4BoxSharpAsync_Finished;
}

private void mp4BoxSharpAsync_Finished(object sender, EventArgs e)
{
    richTextBoxLogAsync.Text += "done\n";
}

private void mp4BoxSharpAsync_Progress(object sender, EventArgs e)
{
    progressBar1.Value = mp4BoxSharpAsync.progress;
}
```

## FAQ
Does it work on non x86-compatibile systems?
No
Does ist work on x86 and x64 systems?
Yes

