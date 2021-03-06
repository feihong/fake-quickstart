# Feihong's FAKE Quickstart

http://fsharp.github.io/FAKE/

> "FAKE - F# Make" is a build automation system with capabilities which are similar to make and rake. It is using an easy domain-specific language (DSL) so that you can start using it without learning F#. If you need more than the default functionality you can either write F# or simply reference .NET assemblies.

## Installation

```
mono .paket/paket.bootstrapper.exe
mono .paket/paket.exe install
```

Add to `.bashrc`:

`alias fake='mono packages/FAKE/tools/FAKE.exe'`

## Sources

- [Scripting in F# Using Fake and Paket](https://www.infoq.com/news/2016/12/fsharp-scripting-fake-paket)
- [Any way to have a many-buildfile structure in FAKE?](http://stackoverflow.com/questions/20319061/any-way-to-have-a-many-buildfile-structure-in-fake)
- [Markdown parser](https://tpetricek.github.io/FSharp.Formatting/markdown.html)
- [Can I pass a parameter to a F# FAKE build script?](http://stackoverflow.com/questions/26267601/can-i-pass-a-parameter-to-a-f-fake-build-script)
- [FileHelper](http://fsharp.github.io/FAKE/apidocs/fake-filehelper.html)