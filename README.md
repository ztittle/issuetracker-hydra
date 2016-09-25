# Overview

Implementation of the [Hydra](http://www.hydra-cg.com/) Hypermedia API [Issue Tracker](http://www.markus-lanthaler.com/hydra/console/?url=http://www.markus-lanthaler.com/hydra/api-demo/) using the [Argolis .NET](https://github.com/wikibus/argolis) Hypermedia Controls.

# Getting Started

1. Install Microsoft Visual Studio 2015
2. Build Solution
3. Access the API Document

```
HTTP GET http://localhost:59917/api
Accept: application/ld+json
```

4. Access the entrypoint document

```
HTTP GET http://localhost:59917/entrypoint
Accept: application/ld+json
```
