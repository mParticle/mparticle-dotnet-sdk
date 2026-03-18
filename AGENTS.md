# AGENTS.md

## Cursor Cloud specific instructions

This is the **mParticle Dotnet Server Events SDK** — a .NET library for sending event data to the mParticle platform via their server-side Events API.

### Project structure

- `src/mParticle.Sdk/` — SDK library (targets `netstandard2.1`)
- `src/mParticle.Sdk.Test/` — xUnit test project (targets `net6.0`)
- `mParticle.sln` — Visual Studio solution file

### Prerequisites

.NET 6.0 SDK is required. It is installed to `$HOME/.dotnet` with `DOTNET_ROOT` and `PATH` configured in `~/.bashrc`.

### Key commands

See `.github/workflows/test.yml` for the CI commands. Summary:

- **Restore:** `dotnet restore`
- **Build:** `dotnet build --configuration Release --no-restore`
- **Test:** `dotnet test --no-restore --verbosity normal`

All 642 unit tests use dummy API credentials and do not require a live mParticle API connection. Some tests make HTTP calls that return `Forbidden` — this is expected and tests still pass.

### Caveats

- No linter is configured in this repo (no `.editorconfig` enforcement, no `dotnet format` in CI). The CI only runs build + test.
- No Docker, database, or external service dependencies.
- The `bump-version.sh` script is for release version management, not for development setup.
