# LoveCompatibility

Simple love compatibility calculator API between two different names. Different modes will be developed in the future

## Running
```bash
git clone git@github.com:Jirubizu/LoveCompatibility.git
cd LoveCompatibility/LoveCompatibility
dotnet run --urls="http://localhost:<port>"
```

## API Usage
Currently only mode `0` supported but more will be added in the future.
```curl
http://localhost:<port>/api/Love?nameOne=<name>&nameTwo=<name>&mode=0
```
