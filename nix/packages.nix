{ pkgs }:

pkgs.buildDotnetModule {
  pname = "plataforma-virtual";
  version = "1.0.0";

  src = ../.;

  projectFile = "src/PlatVirtual/PlatVirtual.csproj";
  nugetDeps = ../deps.json;

  dotnet-sdk = pkgs.dotnetCorePackages.sdk_9_0;
  dotnet-runtime = pkgs.dotnetCorePackages.runtime_9_0;

  selfContainedBuild = true;
}
