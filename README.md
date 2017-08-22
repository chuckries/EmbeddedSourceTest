To use this test project:
1. Build the solution with x86, x64 or both
2. Copy the outputs in bin to another machine or to another location on the same machine and either delete or rename the source (it is important that the original source does not exist at the original location where it was built, otherwise VS will find it first).
3. Open an exe as an EXE project in VS and start debugging with managed engine.
4. VS should obtain embedded source from the pdb.