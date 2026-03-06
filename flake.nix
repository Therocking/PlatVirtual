{
  description = "Plataforma Virtual API";

  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixos-25.05";
  };

  outputs = { self, nixpkgs }:
  let
    lib = nixpkgs.lib;

    supportedSystems = [
      "x86_64-linux"
      "aarch64-linux"
      "x86_64-darwin"
      "aarch64-darwin"
    ];

    forAllSystems = lib.genAttrs supportedSystems;

    dockerTag =
      let env = builtins.getEnv "DOCKER_TAG";
      in if env != "" then env else "latest";

  in {

    packages = forAllSystems (system:
      let
        pkgs = import nixpkgs { inherit system; };

        app = import ./nix/packages.nix {
          inherit pkgs;
        };

        dockerImages = import ./nix/docker.nix {
          inherit pkgs app dockerTag;
        };

      in
      {
        default = app;

        docker-amd64 = dockerImages.amd64;
        docker-arm64 = dockerImages.arm64;
        docker-multiarch = dockerImages.multiarch;

        fetch-deps = app.passthru.fetch-deps;
      }
    );

  };
}
