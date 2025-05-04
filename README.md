# IV.RSG.Promises
[![Build](https://github.com/hasarden/iv-rsg-promises/actions/workflows/test.yml/badge.svg)](https://github.com/hasarden/iv-rsg-promises/actions)
[![codecov](https://codecov.io/gh/hasarden/iv-rsg-promises/branch/main/graph/badge.svg)](https://codecov.io/gh/hasarden/iv-rsg-promises)
[![GitHub Package](https://img.shields.io/badge/package-GitHub-blue)](https://github.com/hasarden/iv-rsg-promises/packages)
[![GitHub release](https://img.shields.io/github/v/release/hasarden/iv-rsg-promises)](https://github.com/hasarden/iv-rsg-promises/releases)
[![.NET Standard](https://img.shields.io/badge/.NET%20Standard-2.1-blue)](https://learn.microsoft.com/en-us/dotnet/standard/net-standard)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

This is a lightweight promise library for C# based on https://github.com/Real-Serious-Games/C-Sharp-Promise

## Installation

### Unity - Through `Packages/manifest.json`
```json
{
  "dependencies": {
    "com.iv.rsg.promises": "https://github.com/hasarden/iv-rsg-promises.git?path=/src/IV.RSG.Promises/Package"
  }
}
```
### Unity - Through Package Manager
You can also install this package using Unity's built-in Package Manager:

1. Open **Unity** and go to **Window > Package Manager**
2. Click the **`+`** button in the top-left corner
3. Select **"Add package from Git URL..."**
4. Paste the following URL: `https://github.com/hasarden/iv-rsg-promises.git?path=/src/IV.RSG.Promises/Package`
5. Click **Add**

### Through GitHub Package
To use `IV.RSG.Promises` in your project via **GitHub Packages**, follow these steps:

##### 1. Add a `nuget.config` file

Create (or edit) a `nuget.config` file in the root of your project or solution directory:

```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <add key="github" value="https://nuget.pkg.github.com/hasarden/index.json" />
  </packageSources>
</configuration>
```

##### 2. Install the package
Use the .NET CLI:
```
dotnet add package IV.RSG.Promises --version 1.0.0
```
Or add a reference in your .csproj:
```xml
<PackageReference Include="IV.RSG.Promises" Version="1.0.0" />
```